
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.map = new GMap.NET.WindowsForms.GMapControl();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.longtitude = new System.Windows.Forms.TextBox();
            this.latitude = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureZoomIn = new System.Windows.Forms.PictureBox();
            this.pictureZoomOut = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureZoomIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureZoomOut)).BeginInit();
            this.SuspendLayout();
            // 
            // map
            // 
            this.map.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.map.Bearing = 0F;
            this.map.CanDragMap = true;
            this.map.EmptyTileColor = System.Drawing.Color.Navy;
            this.map.GrayScaleMode = false;
            this.map.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.map.LevelsKeepInMemmory = 5;
            this.map.Location = new System.Drawing.Point(-81, -146);
            this.map.MarkersEnabled = true;
            this.map.MaxZoom = 2;
            this.map.MinZoom = 2;
            this.map.MouseWheelZoomEnabled = true;
            this.map.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.map.Name = "map";
            this.map.NegativeMode = false;
            this.map.PolygonsEnabled = true;
            this.map.RetryLoadTile = 0;
            this.map.RoutesEnabled = true;
            this.map.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.map.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.map.ShowTileGridLines = false;
            this.map.Size = new System.Drawing.Size(1012, 973);
            this.map.TabIndex = 0;
            this.map.Zoom = 0D;
            this.map.Load += new System.EventHandler(this.gMapControl1_Load);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "经度";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "纬度";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // longtitude
            // 
            this.longtitude.Location = new System.Drawing.Point(111, 30);
            this.longtitude.Name = "longtitude";
            this.longtitude.Size = new System.Drawing.Size(100, 25);
            this.longtitude.TabIndex = 3;
            this.longtitude.TextChanged += new System.EventHandler(this.longtitude_TextChanged);
            // 
            // latitude
            // 
            this.latitude.Location = new System.Drawing.Point(111, 72);
            this.latitude.Name = "latitude";
            this.latitude.Size = new System.Drawing.Size(100, 25);
            this.latitude.TabIndex = 4;
            this.latitude.TextChanged += new System.EventHandler(this.latitude_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(79, 119);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 34);
            this.button1.TabIndex = 5;
            this.button1.Text = "跳转";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.AllowNavigation = false;
            this.webBrowser1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.webBrowser1.IsWebBrowserContextMenuEnabled = false;
            this.webBrowser1.Location = new System.Drawing.Point(-203, 404);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScrollBarsEnabled = false;
            this.webBrowser1.Size = new System.Drawing.Size(459, 250);
            this.webBrowser1.TabIndex = 6;
            this.webBrowser1.Url = new System.Uri("https://hanyu.baidu.com/zici/s?wd=%E5%AF%84&query=%E5%AF%84&srcid=28232&from=kg0", System.UriKind.Absolute);
            this.webBrowser1.WebBrowserShortcutsEnabled = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.pictureZoomIn);
            this.panel1.Controls.Add(this.pictureZoomOut);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.webBrowser1);
            this.panel1.Controls.Add(this.longtitude);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.latitude);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(955, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(259, 657);
            this.panel1.TabIndex = 7;
            // 
            // pictureZoomIn
            // 
            this.pictureZoomIn.Image = global::WindowsFormsApp1.Properties.Resources.放大;
            this.pictureZoomIn.Location = new System.Drawing.Point(43, 174);
            this.pictureZoomIn.Name = "pictureZoomIn";
            this.pictureZoomIn.Size = new System.Drawing.Size(43, 42);
            this.pictureZoomIn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureZoomIn.TabIndex = 9;
            this.pictureZoomIn.TabStop = false;
            this.pictureZoomIn.Click += new System.EventHandler(this.pictureZoomIn_Click);
            // 
            // pictureZoomOut
            // 
            this.pictureZoomOut.Image = global::WindowsFormsApp1.Properties.Resources.缩小;
            this.pictureZoomOut.InitialImage = global::WindowsFormsApp1.Properties.Resources.缩小;
            this.pictureZoomOut.Location = new System.Drawing.Point(143, 174);
            this.pictureZoomOut.Name = "pictureZoomOut";
            this.pictureZoomOut.Size = new System.Drawing.Size(45, 42);
            this.pictureZoomOut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureZoomOut.TabIndex = 8;
            this.pictureZoomOut.TabStop = false;
            this.pictureZoomOut.Click += new System.EventHandler(this.pictureZoomOut_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1226, 673);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.map);
            this.Name = "Form1";
            this.Text = "寄Map";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureZoomIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureZoomOut)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl map;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox longtitude;
        private System.Windows.Forms.TextBox latitude;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureZoomOut;
        private System.Windows.Forms.PictureBox pictureZoomIn;
    }
}

