using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMapProvidersExt;
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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public static GMapOverlay OverlayMarker;//放在全局使用
        private GMapOverlay objects = new GMapOverlay("objects"); //放置marker的图层
        private GMapMarkerImage currentMarker;
        private bool isLeftButtonDown = false;
        private Timer blinkTimer = new Timer();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //string mapPath = Application.StartupPath + "C:\\Users\\xyx\\source\\repos\\C#\\map\\map\\DataExp.gmdb";
            //GMap.NET.GMaps.Instance.ImportFromGMDB(mapPath);
            //gMapControl1.Manager.Mode = AccessMode.CacheOnly;//  ServerOnly,ServerAndCache设置从服务器和缓存中获取地图数据
            //gMapControl1.MapProvider = AMapProvider.Instance;//GMapProviders.GoogleChinaMap;   //谷歌中国地图
            map.MapProvider = GMapProviders.BingMap;
            map.MinZoom = 1;      //最小比例
            map.MaxZoom = 18;     //最大比例
            map.Zoom = 8;        //当前比例
            this.map.DragButton = System.Windows.Forms.MouseButtons.Left;//左键拖拽地图
            map.MouseWheelZoomType = MouseWheelZoomType.MousePositionAndCenter;//鼠标缩放模式
            //this.gMapControl1.SetPositionByKeywords("china,beijing");
            this.map.Position= new PointLatLng(39.9, 116.47);
            OverlayMarker = new GMapOverlay("OverlayMarker"); //创建一个名为“OverlayMarker”的图层
            this.map.Overlays.Add(OverlayMarker);

            //添加标记
            DrawMarker(OverlayMarker, 39.9, 116.4);
            PointLatLng start = new PointLatLng(38.264822, 120.357477);
            PointLatLng end = new PointLatLng(38.164822, 120.357477);

           GDirections myDirections;
            RoutingProvider rp = map.MapProvider as RoutingProvider;
            if (rp == null)
            {
                rp = GMapProviders.OpenStreetMap; // use OpenStreetMap if provider does not implement routing
            }
            map.MouseDown += new MouseEventHandler(gMapControl1_MouseDown);
            map.MouseUp += new MouseEventHandler(gMapControl1_MouseUp);
            map.MouseMove += new MouseEventHandler(gMapControl1_MouseMove);

            map.OnMarkerClick += new MarkerClick(gMapControl1_OnMarkerClick);
            map.OnMarkerEnter += new MarkerEnter(gMapControl1_OnMarkerEnter);
            map.OnMarkerLeave += new MarkerLeave(gMapControl1_OnMarkerLeave);
            MapRoute route = rp.GetRoute(start, end, false, false, (int)map.Zoom);
            if (route == null)
            {
                //MessageBox.Show("寄Map！", "寄", MessageBoxButtons.OK);
            }
            GMapOverlay locations = new GMapOverlay();
            GMapOverlay markersOverlay = new GMapOverlay("markers");
            if (route != null)
            {
                // add route
                GMapRoute r = new GMapRoute(route.Points, route.Name);
                r.IsHitTestVisible = true;
                locations.Routes.Add(r);

                // add route start/end marks
                GMapMarker m1 = new GMarkerGoogle(start, GMarkerGoogleType.green_big_go);
                m1.ToolTipText = "Start: " + route.Name;
                m1.ToolTipMode = MarkerTooltipMode.Always;

                GMapMarker m2 = new GMarkerGoogle(end, GMarkerGoogleType.red_big_stop);
                m2.ToolTipText = "End: " + end.ToString();
                m2.ToolTipMode = MarkerTooltipMode.Always;

                markersOverlay.Markers.Add(m1);
                markersOverlay.Markers.Add(m2);
                map.ZoomAndCenterRoute(r);
                map.Overlays.Add(objects);
            }
        }
        public void DrawMarker(GMapOverlay overlay, double lat, double lng)
        {
            //创建一个名为“overlay”的图层
            //GMapOverlay overlay = new GMapOverlay("overlay");

            //创建标记，并设置位置及样式
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
            //marker.ToolTipMode= MarkerTooltipMode.Always;//标注一直显示
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

        void gMapControl1_MouseMove(object sender, MouseEventArgs e)
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

        void gMapControl1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                isLeftButtonDown = false;
            }
        }

        void gMapControl1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                isLeftButtonDown = true;
            }
        }

        void gMapControl1_OnMarkerLeave(GMapMarker item)
        {
            if (item is GMapMarkerImage)
            {
                currentMarker = null;
                GMapMarkerImage m = item as GMapMarkerImage;
                m.Pen.Dispose();
                m.Pen = null;
            }
        }

        void gMapControl1_OnMarkerEnter(GMapMarker item)
        {
            if (item is GMapMarkerImage)
            {
                currentMarker = item as GMapMarkerImage;
                currentMarker.Pen = new Pen(Brushes.Red, 2);
            }
        }

        void gMapControl1_OnMarkerClick(GMapMarker item, MouseEventArgs e)
        {
        }

        void gMapControl1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                //objects.Markers.Clear();
                PointLatLng point = map.FromLocalToLatLng(e.X, e.Y);
                //GMapMarker marker = new GMarkerGoogle(point, GMarkerGoogleType.green);
                Bitmap bitmap = Bitmap.FromFile("E:\\学习\\大三上\\C#\\GUI.png") as Bitmap;
                //GMapMarker marker = new GMarkerGoogle(point, bitmap);
                GMapMarker marker = new GMapMarkerImage(point, bitmap);
                marker.ToolTipMode = MarkerTooltipMode.OnMouseOver;
                marker.ToolTipText = string.Format("{0},{1}", point.Lat, point.Lng);
                objects.Markers.Add(marker);
            }
        }

        void gMapControl1_OnMapZoomChanged()
        {
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
    }
}
