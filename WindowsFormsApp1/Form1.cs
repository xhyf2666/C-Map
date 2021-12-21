using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMapChinaRegion;
using GMapPOI;
using GMapProvidersExt;
using GMapProvidersExt.AMap;
using GMapProvidersExt.Baidu;
using GMapWinForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NetUtil;
using GMapTools;
using GMapDrawTools;
using GMapPolygonLib;
using GMapDownload;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private Country china;
        public static GMapOverlay OverlayMarker;//放在全局使用
        private GMapOverlay routeOverlay = new GMapOverlay("routeOverlay");
        private GMapOverlay objects = new GMapOverlay("objects"); //放置marker的图层
        private GMapMarkerImage currentMarker;
        private bool isLeftButtonDown = false;
        private Timer blinkTimer = new Timer();
        //private GMapAreaPolygon currentAreaPolygon;
        private string currentCenterCityName = "北京市";
        private bool isCountryLoad = false;
        private GMapOverlay poiOverlay = new GMapOverlay("poiOverlay");
        bool mouseMove = true;
        private GMapOverlay regionOverlay = new GMapOverlay("region");
        private List<PoiData> poiDataList = new List<PoiData>();
        private List<Placemark> poisQueryResult = new List<Placemark>();
        private int poiQueryCount = 0;
        private string searchProvince;
        private string searchCity;
        private DrawDistance drawDistance;
        private Draw draw;
        private GMapOverlay polygonsOverlay = new GMapOverlay("polygonsOverlay");
        private TileDownloader tileDownloader = new TileDownloader(5);
        private string tilePath = "D:\\Map";
        private int retryNum = 3;

        private GMapAreaPolygon currentAreaPolygon;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            map.MapProvider = GMapProvidersExt.AMap.AMapProvider.Instance;
            map.MinZoom = 2;      //最小比例
            map.MaxZoom = 18;     //最大比例
            map.Zoom = 8;        //当前比例
            this.map.DragButton = System.Windows.Forms.MouseButtons.Left;//左键拖拽地图
            map.MouseWheelZoomType = MouseWheelZoomType.MousePositionAndCenter;//鼠标缩放模式
            this.map.Position= new PointLatLng(39.9, 116.47);
            OverlayMarker = new GMapOverlay("OverlayMarker"); //创建一个名为“OverlayMarker”的图层
            this.map.Overlays.Add(OverlayMarker);

            byte[] buffer = Properties.Resources.ChinaBoundary;
            china = GMapChinaRegion.ChinaMapRegion.GetChinaRegionFromJsonBinaryBytes(buffer);
            InitPOICountrySearchCondition();

            map.Overlays.Add(polygonsOverlay);
            map.Overlays.Add(regionOverlay);
            map.Overlays.Add(poiOverlay);
            map.Overlays.Add(routeOverlay);

            draw = new Draw(map);
            draw.DrawComplete += new EventHandler<DrawEventArgs>(draw_DrawComplete);

            map.OnMarkerClick += new MarkerClick(MapControl_OnMarkerClick);
            drawDistance = new DrawDistance(map);
            drawDistance.DrawComplete += new EventHandler<DrawDistanceEventArgs>(drawDistance_DrawComplete);

            map.OnPolygonDoubleClick += new PolygonDoubleClick(mapControl_OnPolygonDoubleClick);
            DrawMarker(OverlayMarker, 39.9, 116.4);
            PointLatLng start = new PointLatLng(38.264822, 120.357477);
            PointLatLng end = new PointLatLng(38.164822, 120.357477);
            GMapOverlay locations = new GMapOverlay();
            GMapOverlay markersOverlay = new GMapOverlay("markers");
            this.dataGridViewPOI.AutoSize = true;
        }
        public void DrawMarker(GMapOverlay overlay, double lat, double lng)
        {
            GMapMarker marker = new GMarkerGoogle(new PointLatLng(lat, lng), GMarkerGoogleType.blue_small);
            //将标记添加到图层
            overlay.Markers.Add(marker);
            //将图层添加到地图
            this.map.Overlays.Add(overlay);
            //鼠标标记点提示框ToolTip
            marker.ToolTip = new GMapToolTip(marker);
            //Brush tooltipBackColor = new SolidBrush(Color.Transparent);//颜色获取，可用于填充背景
            marker.ToolTipText = "实时坐标";
            marker.ToolTip.Font = new Font("微软雅黑", 11);
            marker.ToolTip.Fill = new SolidBrush(Color.FromArgb(100, Color.Black));
            marker.ToolTip.Foreground = Brushes.White;
            marker.ToolTip.TextPadding = new Size(20, 20);
            marker.ToolTip.Offset = new System.Drawing.Point(marker.Offset.X - (int)((float)marker.ToolTipText.Length / 2) * 15, marker.Offset.Y + 28);//显示位置

        }
        void mapControl_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left && isLeftButtonDown)
            {
                if (currentMarker != null)
                {
                    PointLatLng point = map.FromLocalToLatLng(e.X, e.Y);
                    currentMarker.Position = point;
                    currentMarker.ToolTipText = string.Format("{0},{1}", point.Lat, point.Lng);
                }
            }
        }

        private void gMapControl1_Load(object sender, EventArgs e)
        {

        }

        private void InitPOICountrySearchCondition()
        {
            if (china != null)
            {
                foreach (var provice in china.Province)
                {
                    this.comboBoxProvince.Items.Add(provice);
                }
                this.comboBoxProvince.DisplayMember = "name";
                //this.comboBoxProvince.SelectedIndex = 0;
                this.comboBoxProvince.SelectedValueChanged += ComboBoxProvince_SelectedValueChanged;
                this.comboBoxProvince.SelectedIndex = 0;
            }
        }

        private void ComboBoxProvince_SelectedValueChanged(object sender, EventArgs e)
        {
            Province province = this.comboBoxProvince.SelectedItem as Province;
            if (province != null)
            {
                this.comboBoxCity.Items.Clear();
                foreach (var city in province.City)
                {
                    this.comboBoxCity.Items.Add(city);
                }
                this.comboBoxCity.DisplayMember = "name";
                this.comboBoxCity.SelectedIndex = 0;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double lat = latitude.Text.Length>0?Convert.ToDouble(latitude.Text):map.Position.Lat;
            double lng = longtitude.Text.Length > 0 ? Convert.ToDouble(longtitude.Text) : map.Position.Lng;
            PointLatLng p=new PointLatLng(lat,lng);
            map.Position = p;
            GMapMarker marker = new GMarkerGoogle(p, GMarkerGoogleType.blue_dot);
            OverlayMarker.Markers.Add(marker);
        }

        private void longtitude_TextChanged(object sender, EventArgs e)
        {

        }

        private void latitude_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureZoomOut_Click(object sender, EventArgs e)
        {
            map.Zoom--;
        }

        private void pictureZoomIn_Click(object sender, EventArgs e)
        {
            map.Zoom++;
        }



        //搜索按钮的点击时间
        private void buttonAddressSearch_Click(object sender, EventArgs e)
        {
            string address = this.textBoxAddress.Text.Trim();//获取输入的关键字
            Province province = this.comboBoxProvince.SelectedItem as Province;//搜索时优先的省份
            City city = this.comboBoxCity.SelectedItem as City;//搜索时优先的程序

            if (!string.IsNullOrEmpty(address))
            {
                this.dataGridViewPOI.DataSource = null;
                this.dataGridViewPOI.Update();
                searchProvince = province.name;
                searchCity = city.name;
                GetPOIFromMap(city.name,address, 2);//调用搜索函数
            }

        }
        private void GetPOIFromMap(string cityName, string keywords, int mapIndex)
        {
            this.poiOverlay.Markers.Clear();
            this.poiDataList.Clear();
            POISearchArgument argument = new POISearchArgument();
            argument.KeyWord = keywords;
            argument.Region = cityName;
            argument.MapIndex = mapIndex;

            toolStripStatusPOIDownload.Visible = true;//修改下载进度条为可见
            BackgroundWorker poiWorker = new BackgroundWorker();//创建一个单独的线程进行搜索
            poiWorker.DoWork += new DoWorkEventHandler(poiWorker_DoWork);//设置线程的行为
            poiWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(poiWorker_RunWorkerCompleted);//设置线程结束时的行为
            poiWorker.RunWorkerAsync(argument);//启动线程
        }

        void poiWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            POISearchArgument argument = e.Argument as POISearchArgument;
            if (argument != null)
            {
                string regionName = argument.Region;
                string poiQueryRectangleStr = argument.Rectangle;
                string keyWords = argument.KeyWord;
                int mapIndex = argument.MapIndex;
                this.poiDataList.Clear();
                this.poisQueryResult.Clear();//poisQueryResult用来存放搜索结果
                this.poiQueryCount = 0;//poiQueryCount表示搜索结果的个数
                switch (mapIndex)
                {
                    case 2://使用高德地图搜索
                        AMapProvider.Instance.GetPlacemarksByKeywords(keyWords, regionName, poiQueryRectangleStr, this.queryProgressEvent, out this.poisQueryResult, ref this.poiQueryCount);
                        break;
                    case 3://使用百度地图搜索
                        BaiduMapProvider.Instance.GetPlacemarksByKeywords(keyWords, regionName, poiQueryRectangleStr, this.queryProgressEvent, out this.poisQueryResult, ref this.poiQueryCount);
                    break;
                }
            }
        }

        void poiWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (poisQueryResult != null && poisQueryResult.Count > 0)
            {
                foreach (Placemark place in poisQueryResult)
                {
                    //搜索完成后，为每个搜索结果添加一个标记，在地图上显示出来，并将搜索信息输出到表格中
                    GMarkerGoogle marker = new GMarkerGoogle(place.Point, GMarkerGoogleType.blue_dot);
                    marker.ToolTipText = place.Name + "\r\n" + place.Address + "\r\n" + place.Category;
                    this.poiOverlay.Markers.Add(marker);
                    PoiData poiData = new PoiData();
                    poiData.Name = place.Name;
                    poiData.Address = place.Address;
                    poiData.Province = searchProvince;
                    poiData.City = searchCity;
                    poiData.Lat = place.Point.Lat;
                    poiData.Lng = place.Point.Lng;
                    this.poiDataList.Add(poiData);
                }

                this.dataGridViewPOI.DataSource = poiDataList;
            }
            this.toolStripStatusPOIDownload.Text = string.Format("共找到：{0}条POI数据", poisQueryResult.Count);
        }

        delegate void changeToolStripStatusPOIDownloadTextCallBack(string text);
        private void setToolStripStatusPOIDownloadText(string text) {
            if (this.toolStripStatusPOIDownload.InvokeRequired) {
                changeToolStripStatusPOIDownloadTextCallBack stcb = new changeToolStripStatusPOIDownloadTextCallBack(setToolStripStatusPOIDownloadText);
                this.Invoke(stcb, new object[] { text }); } 
            else { 
                this.toolStripStatusPOIDownload.Text = text; } 
        }
        private void queryProgressEvent(long completedCount, long total)
        {
            setToolStripStatusPOIDownloadText(string.Format("已找到{0}条POI，还在查询中...", completedCount));
            //this.toolStripStatusPOIDownload.Text = string.Format("已找到{0}条POI，还在查询中...", completedCount);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewPOI_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int row=dataGridViewPOI.SelectedCells[0].RowIndex;
            map.Position = new PointLatLng(poiDataList[row].Lat, poiDataList[row].Lng);
            map.Zoom = 13;
        }

        private void map_MouseClick(object sender, MouseEventArgs e)
        {
            return;
            if (mouseMove)
            {
                PointLatLng p = map.FromLocalToLatLng(e.X, e.Y);
                map.Position = p;
                latitude.Text = p.Lat.ToString();
                longtitude.Text = p.Lng.ToString();
            }
        }

        private void buttonPoiSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (poiDataList.Count <= 0)
                {
                    MessageBox.Show("POI数据为空，无法保存！");
                    return;
                }
                BackgroundWorker poiExportWorker = new BackgroundWorker();
                poiExportWorker.DoWork += new DoWorkEventHandler(poiExportWorker_DoWork);
                poiExportWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(poiExportWorker_RunWorkerCompleted);

                int selectIndex = 0;
                if (selectIndex == 0)
                {
                    SaveFileDialog saveDlg = new SaveFileDialog();
                    saveDlg.Filter = "Excel File (*.xls)|*.xls|(*.xlsx)|*.xlsx";
                    saveDlg.FilterIndex = 1;
                    saveDlg.RestoreDirectory = true;
                    if (saveDlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        string file = saveDlg.FileName;

                        DataTable dt = new DataTable();
                        dt.Columns.Add("名称", typeof(string));
                        dt.Columns.Add("地址", typeof(string));
                        dt.Columns.Add("省份", typeof(string));
                        dt.Columns.Add("城市", typeof(string));
                        dt.Columns.Add("经度", typeof(double));
                        dt.Columns.Add("纬度", typeof(double));

                        foreach (PoiData data in poiDataList)
                        {
                            DataRow dr = dt.NewRow();
                            dr["名称"] = data.Name;
                            dr["地址"] = data.Address;
                            dr["省份"] = data.Province;
                            dr["城市"] = data.City;
                            dr["经度"] = data.Lng;
                            dr["纬度"] = data.Lat;
                            dt.Rows.Add(dr);
                        }
                        PoiExportParameter para = new PoiExportParameter();
                        para.Path = file;
                        para.Data = dt;
                        para.ExportType = selectIndex;
                        poiExportWorker.RunWorkerAsync(para);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("POI保存失败！");
            }
        }

        void poiExportWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("POI保存完成！");
        }

        void poiExportWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            if (e != null)
            {
                PoiExportParameter para = e.Argument as PoiExportParameter;
                if (para.ExportType == 0)
                {
                    DataTable dt = para.Data;
                    string file = para.Path;
                    ExcelHelper.DataTableToExcel(dt, file, null, true);
                }
            }
        }

        private void buttonDrawDistance_Click(object sender, EventArgs e)
        {
            drawDistance.IsEnable = true;
            mouseMove = false;
            /*
            drawDistance.IsEnable = !drawDistance.IsEnable;
            mouseMove = !mouseMove;
            */
        }

        void drawDistance_DrawComplete(object sender, DrawDistanceEventArgs e)
        {
            if (e != null)
            {
                GMapOverlay distanceOverlay = new GMapOverlay();
                map.Overlays.Add(distanceOverlay);
                foreach (LineMarker line in e.LineMarkers)
                {
                    distanceOverlay.Markers.Add(line);
                }
                foreach (DrawDistanceMarker marker in e.DistanceMarkers)
                {
                    distanceOverlay.Markers.Add(marker);
                }
                distanceOverlay.Markers.Add(e.DistanceDeleteMarker);
            }
            drawDistance.IsEnable = false;
            mouseMove = true;
        }

        void MapControl_OnMarkerClick(GMapMarker item, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (item is DrawDeleteMarker)
                {
                    GMapOverlay overlay = item.Overlay;
                    if (overlay.Markers.Contains(item))
                    {
                        overlay.Markers.Remove(item);
                    }

                    if (map.Overlays.Contains(overlay))
                    {
                        map.Overlays.Remove(overlay);
                    }
                }
            }
        }

        private void toolStripSplitButton2_ButtonClick(object sender, EventArgs e)
        {

        }

        void draw_DrawComplete(object sender, DrawEventArgs e)
        {
            try
            {
                if (e != null && (e.Polygon != null || e.Rectangle != null || e.Circle != null || e.Line != null || e.Route != null))
                {
                    GMapPolygon drawPolygon = null;
                    switch (e.DrawingMode)
                    {
                        case DrawingMode.Polygon:
                            drawPolygon = e.Polygon;
                            break;
                        case DrawingMode.Rectangle:
                            drawPolygon = e.Rectangle;
                            break;
                        case DrawingMode.Circle:
                            polygonsOverlay.Markers.Add(e.Circle);
                            break;
                        default:
                            draw.IsEnable = false;
                            break;
                    }

                    if (drawPolygon != null)
                    {
                        GMapAreaPolygon areaPolygon = new GMapAreaPolygon(drawPolygon.Points, "下载区域");
                        currentAreaPolygon = areaPolygon;
                        RectLatLng rect = GMapUtil.PolygonUtils.GetRegionMaxRect(currentAreaPolygon);
                        GMapTextMarker textMarker = new GMapTextMarker(rect.LocationMiddle, "双击下载");
                        regionOverlay.Clear();
                        regionOverlay.Polygons.Add(areaPolygon);
                        regionOverlay.Markers.Add(textMarker);
                        map.SetZoomToFitRect(rect);
                    }
                }
            }
            finally
            {
                draw.IsEnable = false;
            }
        }

        private void 矩形ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 圆形ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 多边形ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        void mapControl_OnPolygonDoubleClick(GMapPolygon item, MouseEventArgs e)
        {
            if (item is GMapAreaPolygon)
            {
                if (currentAreaPolygon != null)
                {
                    DownloadMap(currentAreaPolygon);
                }
                else
                {
                    //CommonTools.MessageBox.ShowTipMessage("请先用画图工具画下载的区域多边形或选择省市区域！");
                }
            }
        }

        //下载地图分片
        private void DownloadMap(GMapPolygon polygon)
        {
            if (polygon != null)
            {
                if (!tileDownloader.IsComplete)
                {
                    MessageBox.Show("正在下载地图，等待下载完成！");
                }
                else
                {
                    RectLatLng area = GMapUtil.PolygonUtils.GetRegionMaxRect(polygon);
                    //获取用户选择的区域，将其转化为矩形区域
                    try
                    {
                        DownloadCfgForm downloadCfgForm = new DownloadCfgForm(area, map.MapProvider);
                        if (downloadCfgForm.ShowDialog() == DialogResult.OK)
                        {
                            TileDownloaderArgs downloaderArgs = downloadCfgForm.GetDownloadTileGPoints();
                            ResetToServerAndCacheMode();
                            //tileDownloader是独立的下载线程
                            tileDownloader.TilePath = this.tilePath;
                            tileDownloader.Retry = retryNum;
                            tileDownloader.PrefetchTileStart += new EventHandler<TileDownloadEventArgs>(tileDownloader_PrefetchTileStart);//初始化
                            tileDownloader.PrefetchTileProgress += new EventHandler<TileDownloadEventArgs>(tileDownloader_PrefetchTileProgress);//执行时
                            tileDownloader.PrefetchTileComplete += new EventHandler<TileDownloadEventArgs>(tileDownloader_PrefetchTileComplete);//完成后
                            tileDownloader.StartDownload(downloaderArgs);//开始下载
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("请先用画图工具画下载的区域多边形或选择省市区域！");
            }
        }

        private void ResetToServerAndCacheMode()
        {
            if (this.map.Manager.Mode != AccessMode.ServerAndCache)
            {
                this.map.Manager.Mode = AccessMode.ServerAndCache;
            }
        }
        void tileDownloader_PrefetchTileStart(object sender, TileDownloadEventArgs e)
        {
            ShowDownloadTip(true);
        }

        void tileDownloader_PrefetchTileProgress(object sender, TileDownloadEventArgs e)
        {
            if (e != null)
            {
                if (this.IsDisposed || !this.IsHandleCreated) return;
                this.Invoke(new UpdateDownloadProress(UpdateDownloadBar), e.TileCompleteNum, e.TileAllNum);
                //唤醒下载线程
            }
        }
        private delegate void UpdateDownloadProress(int completedCount, int totalCount);
        private void toolStripStatusDownload_Click(object sender, EventArgs e)
        {

        }

        void tileDownloader_PrefetchTileComplete(object sender, TileDownloadEventArgs e)
        {
            MessageBox.Show("地图下载完成！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            ShowDownloadTip(false);
        }

        //更新下载进度条
        private void UpdateDownloadBar(int completedCount, int totalCount)
        {
            if (this.toolStripStatusDownload.Visible)
            {
                int value = completedCount * 100 / totalCount;
                this.toolStripStatusDownload.Text = string.Format("下载进度：{0}/{1}", completedCount, totalCount);
                this.toolStripProgressBarDownload.Value = value;
            }
        }

        private void ShowDownloadTip(bool isVisible)
        {
            if (this.Created && this.InvokeRequired)
            {
                this.Invoke(new Action(() =>
                {
                    this.toolStripProgressBarDownload.Visible = isVisible;
                    this.toolStripStatusDownload.Visible = isVisible;
                }));
            }
            else
            {
                this.toolStripProgressBarDownload.Visible = isVisible;
                this.toolStripStatusDownload.Visible = isVisible;
            }
        }

        private void 删除下载图片ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 清理缓存ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 删除下载文件ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DirectoryInfo di = new DirectoryInfo(tilePath);
            if (di.Exists)
            {
                di.Delete(true);
                MessageBox.Show("删除完成！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void 矩形ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            mouseMove = false;
            draw.DrawingMode = DrawingMode.Rectangle;
            draw.IsEnable = true;
        }

        private void 圆形ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            mouseMove = false;
            draw.DrawingMode = DrawingMode.Circle;
            draw.IsEnable = true;
        }

        private void 多边形ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            mouseMove = false;
            draw.DrawingMode = DrawingMode.Polygon;
            draw.IsEnable = true;
        }

        private void 清理标记ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.poiOverlay.Clear();
            if (map.Overlays.Contains(poiOverlay))
            {
                map.Overlays.Remove(poiOverlay);
            }
            mouseMove = true;
        }

        private void 矩形ToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            mouseMove = false;
            draw.DrawingMode = DrawingMode.Rectangle;
            draw.IsEnable = true;
        }

        private void 清理画图ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            regionOverlay.Clear();
            polygonsOverlay.Clear();
            mouseMove = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel1.Enabled = false;
            panel2.Visible = true;
            panel2.Enabled = true;
            if (!isCountryLoad)
            {
                InitChinaRegion();
                isCountryLoad = true;
            }
        }

        private void InitChinaRegion()
        {
            TreeNode rootNode = new TreeNode("中国");
            this.advTreeChina.Nodes.Add(rootNode);
            rootNode.Expand();

            //异步加载中国省市边界
            BackgroundWorker loadChinaWorker = new BackgroundWorker();
            loadChinaWorker.DoWork += new DoWorkEventHandler(loadChinaWorker_DoWork);
            loadChinaWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(loadChinaWorker_RunWorkerCompleted);
            loadChinaWorker.RunWorkerAsync();
        }

        void loadChinaWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (china == null)
            {
                return;
            }

            InitPOICountrySearchCondition();

            InitCountryTree();
        }

        void loadChinaWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                byte[] buffer = Properties.Resources.ChinaBoundary;
                china = GMapChinaRegion.ChinaMapRegion.GetChinaRegionFromJsonBinaryBytes(buffer);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void InitCountryTree()
        {
            try
            {
                if (china.Province != null)
                {
                    foreach (var provice in china.Province)
                    {
                        TreeNode pNode = new TreeNode(provice.name);
                        pNode.Tag = provice;
                        if (provice.City != null)
                        {
                            foreach (var city in provice.City)
                            {
                                TreeNode cNode = new TreeNode(city.name);
                                cNode.Tag = city;
                                if (city.Piecearea != null)
                                {
                                    foreach (var piecearea in city.Piecearea)
                                    {
                                        TreeNode areaNode = new TreeNode(piecearea.name);
                                        areaNode.Tag = piecearea;
                                        cNode.Nodes.Add(areaNode);
                                    }
                                }
                                pNode.Nodes.Add(cNode);
                            }
                        }
                        TreeNode rootNode = this.advTreeChina.Nodes[0];
                        rootNode.Nodes.Add(pNode);
                    }
                }
            }
            catch (Exception ex)
            {
            }

            this.advTreeChina.NodeMouseClick += new TreeNodeMouseClickEventHandler(advTreeChina_NodeMouseClick);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel2.Enabled = false;
            panel1.Visible = true;
            panel1.Enabled = true;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        void advTreeChina_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            this.advTreeChina.SelectedNode = sender as TreeNode;
            if (e.Button == MouseButtons.Left || e.Button == MouseButtons.Right)
            {
                string name = e.Node.Text;
                string rings = null;
                switch (e.Node.Level)
                {
                    case 0:
                        break;
                    case 1:
                        Province province = e.Node.Tag as Province;
                        name = province.name;
                        rings = province.rings;
                        break;
                    case 2:
                        City city = e.Node.Tag as City;
                        name = city.name;
                        rings = city.rings;
                        break;
                    case 3:
                        Piecearea piecearea = e.Node.Tag as Piecearea;
                        name = piecearea.name;
                        rings = piecearea.rings;
                        break;
                }
                if (rings != null && !string.IsNullOrEmpty(rings))
                {
                    GMapPolygon polygon = ChinaMapRegion.GetRegionPolygon(name, rings);
                    if (polygon != null)
                    {
                        GMapAreaPolygon areaPolygon = new GMapAreaPolygon(polygon.Points, name);
                        currentAreaPolygon = areaPolygon;
                        RectLatLng rect = GMapUtil.PolygonUtils.GetRegionMaxRect(polygon);
                        GMapTextMarker textMarker = new GMapTextMarker(rect.LocationMiddle, "双击下载");
                        regionOverlay.Clear();
                        regionOverlay.Polygons.Add(areaPolygon);
                        regionOverlay.Markers.Add(textMarker);
                        this.map.SetZoomToFitRect(rect);
                    }
                }
            }
        }

    }
}
