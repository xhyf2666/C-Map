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
        private GMapOverlay poiOverlay = new GMapOverlay("poiOverlay");
        private List<PoiData> poiDataList = new List<PoiData>();
        private List<Placemark> poisQueryResult = new List<Placemark>();
        private int poiQueryCount = 0;
        private string searchProvince;
        private string searchCity;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            map.MapProvider = GMapProvidersExt.AMap.AMapProvider.Instance;
            //map.MapProvider = GMapProvidersExt.Baidu.BaiduMapProvider.Instance;
            map.MinZoom = 1;      //最小比例
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
            //添加标记
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




        private void buttonAddressSearch_Click(object sender, EventArgs e)
        {
            string address = this.textBoxAddress.Text.Trim();
            Province province = this.comboBoxProvince.SelectedItem as Province;
            City city = this.comboBoxCity.SelectedItem as City;

            if (!string.IsNullOrEmpty(address))
            {
                this.dataGridViewPOI.DataSource = null;
                this.dataGridViewPOI.Update();
                searchProvince = province.name;
                searchCity = city.name;
                //mapIndex
                GetPOIFromMap(city.name,address, 2);
                /*
                this.routeOverlay.Markers.Clear();
                Placemark placemark = new Placemark(address);
                placemark.CityName = currentCenterCityName;
                List<PointLatLng> points = new List<PointLatLng>();
                GeoCoderStatusCode statusCode = AMapProvider.Instance.GetPoints(placemark, out points);
                if (statusCode == GeoCoderStatusCode.G_GEO_SUCCESS)
                {
                    foreach (PointLatLng p in points)
                    {
                        GMarkerGoogle marker = new GMarkerGoogle(p, GMarkerGoogleType.blue_dot);
                        marker.ToolTipText = placemark.Address;
                        this.routeOverlay.Markers.Add(marker);
                        this.map.Position = p;
                        this.map.Zoom = 14;
                    }
                }
                */
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

            //toolStripStatusPOIDownload.Visible = true;
            BackgroundWorker poiWorker = new BackgroundWorker();
            poiWorker.DoWork += new DoWorkEventHandler(poiWorker_DoWork);
            poiWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(poiWorker_RunWorkerCompleted);
            poiWorker.RunWorkerAsync(argument);
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
                this.poisQueryResult.Clear();
                this.poiQueryCount = 0;
                switch (mapIndex)
                {
                    case 2:
                        AMapProvider.Instance.GetPlacemarksByKeywords(keyWords, regionName, poiQueryRectangleStr, this.queryProgressEvent, out this.poisQueryResult, ref this.poiQueryCount);
                        break;
                    case 3:
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
            PointLatLng p = map.FromLocalToLatLng(e.X, e.Y);
            map.Position = p;
            latitude.Text = p.Lat.ToString();
            longtitude.Text = p.Lng.ToString();
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
    }
}
