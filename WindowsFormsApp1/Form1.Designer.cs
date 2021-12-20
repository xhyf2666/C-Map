
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
            this.components = new System.ComponentModel.Container();
            this.map = new GMap.NET.WindowsForms.GMapControl();
            this.poiDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.latitude = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.longtitude = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureZoomOut = new System.Windows.Forms.PictureBox();
            this.pictureZoomIn = new System.Windows.Forms.PictureBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.buttonAddressSearch = new System.Windows.Forms.Button();
            this.comboBoxProvince = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxCity = new System.Windows.Forms.ComboBox();
            this.dataGridViewPOI = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.provinceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.latDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lngDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.toolStripProgressBarDownload = new System.Windows.Forms.ProgressBar();
            this.toolStripStatusDownload = new System.Windows.Forms.Label();
            this.buttonDrawDistance = new System.Windows.Forms.Button();
            this.buttonPoiSave = new System.Windows.Forms.Button();
            this.toolStripStatusPOIDownload = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.poiDataBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.矩形ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.圆形ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.多边形ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.图层清理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.清理画图ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.清理测距ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.清理标记ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.清理缓存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除下载文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.advTreeChina = new System.Windows.Forms.TreeView();
            ((System.ComponentModel.ISupportInitialize)(this.poiDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureZoomOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureZoomIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPOI)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.poiDataBindingSource1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.map.Size = new System.Drawing.Size(924, 973);
            this.map.TabIndex = 0;
            this.map.Zoom = 0D;
            this.map.Load += new System.EventHandler(this.gMapControl1_Load);
            this.map.MouseClick += new System.Windows.Forms.MouseEventHandler(this.map_MouseClick);
            // 
            // poiDataBindingSource
            // 
            this.poiDataBindingSource.DataSource = typeof(GMapPOI.PoiData);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "纬度";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // latitude
            // 
            this.latitude.Location = new System.Drawing.Point(88, 116);
            this.latitude.Name = "latitude";
            this.latitude.Size = new System.Drawing.Size(100, 25);
            this.latitude.TabIndex = 4;
            this.latitude.TextChanged += new System.EventHandler(this.latitude_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "经度";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // longtitude
            // 
            this.longtitude.Location = new System.Drawing.Point(88, 74);
            this.longtitude.Name = "longtitude";
            this.longtitude.Size = new System.Drawing.Size(100, 25);
            this.longtitude.TabIndex = 3;
            this.longtitude.TextChanged += new System.EventHandler(this.longtitude_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(244, 74);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 34);
            this.button1.TabIndex = 5;
            this.button1.Text = "跳转";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureZoomOut
            // 
            this.pictureZoomOut.Image = global::WindowsFormsApp1.Properties.Resources.缩小;
            this.pictureZoomOut.InitialImage = global::WindowsFormsApp1.Properties.Resources.缩小;
            this.pictureZoomOut.Location = new System.Drawing.Point(143, 147);
            this.pictureZoomOut.Name = "pictureZoomOut";
            this.pictureZoomOut.Size = new System.Drawing.Size(45, 42);
            this.pictureZoomOut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureZoomOut.TabIndex = 8;
            this.pictureZoomOut.TabStop = false;
            this.pictureZoomOut.Click += new System.EventHandler(this.pictureZoomOut_Click);
            // 
            // pictureZoomIn
            // 
            this.pictureZoomIn.Image = global::WindowsFormsApp1.Properties.Resources.放大;
            this.pictureZoomIn.Location = new System.Drawing.Point(29, 147);
            this.pictureZoomIn.Name = "pictureZoomIn";
            this.pictureZoomIn.Size = new System.Drawing.Size(43, 42);
            this.pictureZoomIn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureZoomIn.TabIndex = 9;
            this.pictureZoomIn.TabStop = false;
            this.pictureZoomIn.Click += new System.EventHandler(this.pictureZoomIn_Click);
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(22, 244);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(166, 25);
            this.textBoxAddress.TabIndex = 11;
            // 
            // buttonAddressSearch
            // 
            this.buttonAddressSearch.Location = new System.Drawing.Point(197, 244);
            this.buttonAddressSearch.Name = "buttonAddressSearch";
            this.buttonAddressSearch.Size = new System.Drawing.Size(75, 26);
            this.buttonAddressSearch.TabIndex = 12;
            this.buttonAddressSearch.Text = "搜索";
            this.buttonAddressSearch.UseVisualStyleBackColor = true;
            this.buttonAddressSearch.Click += new System.EventHandler(this.buttonAddressSearch_Click);
            // 
            // comboBoxProvince
            // 
            this.comboBoxProvince.FormattingEnabled = true;
            this.comboBoxProvince.Location = new System.Drawing.Point(47, 202);
            this.comboBoxProvince.Name = "comboBoxProvince";
            this.comboBoxProvince.Size = new System.Drawing.Size(116, 23);
            this.comboBoxProvince.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "省";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(169, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "市";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // comboBoxCity
            // 
            this.comboBoxCity.FormattingEnabled = true;
            this.comboBoxCity.Location = new System.Drawing.Point(197, 202);
            this.comboBoxCity.Name = "comboBoxCity";
            this.comboBoxCity.Size = new System.Drawing.Size(113, 23);
            this.comboBoxCity.TabIndex = 16;
            // 
            // dataGridViewPOI
            // 
            this.dataGridViewPOI.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewPOI.AutoGenerateColumns = false;
            this.dataGridViewPOI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPOI.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.provinceDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.latDataGridViewTextBoxColumn,
            this.lngDataGridViewTextBoxColumn});
            this.dataGridViewPOI.DataSource = this.poiDataBindingSource;
            this.dataGridViewPOI.Location = new System.Drawing.Point(3, 276);
            this.dataGridViewPOI.Name = "dataGridViewPOI";
            this.dataGridViewPOI.ReadOnly = true;
            this.dataGridViewPOI.RowHeadersWidth = 51;
            this.dataGridViewPOI.RowTemplate.Height = 27;
            this.dataGridViewPOI.Size = new System.Drawing.Size(368, 333);
            this.dataGridViewPOI.TabIndex = 17;
            this.dataGridViewPOI.TabStop = false;
            this.dataGridViewPOI.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPOI_CellContentClick);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "名称";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "地址";
            this.addressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            this.addressDataGridViewTextBoxColumn.Width = 125;
            // 
            // provinceDataGridViewTextBoxColumn
            // 
            this.provinceDataGridViewTextBoxColumn.DataPropertyName = "Province";
            this.provinceDataGridViewTextBoxColumn.HeaderText = "Province";
            this.provinceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.provinceDataGridViewTextBoxColumn.Name = "provinceDataGridViewTextBoxColumn";
            this.provinceDataGridViewTextBoxColumn.ReadOnly = true;
            this.provinceDataGridViewTextBoxColumn.Width = 125;
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "City";
            this.cityDataGridViewTextBoxColumn.HeaderText = "City";
            this.cityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            this.cityDataGridViewTextBoxColumn.ReadOnly = true;
            this.cityDataGridViewTextBoxColumn.Width = 125;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.ReadOnly = true;
            this.typeDataGridViewTextBoxColumn.Width = 125;
            // 
            // latDataGridViewTextBoxColumn
            // 
            this.latDataGridViewTextBoxColumn.DataPropertyName = "Lat";
            this.latDataGridViewTextBoxColumn.HeaderText = "Lat";
            this.latDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.latDataGridViewTextBoxColumn.Name = "latDataGridViewTextBoxColumn";
            this.latDataGridViewTextBoxColumn.ReadOnly = true;
            this.latDataGridViewTextBoxColumn.Width = 125;
            // 
            // lngDataGridViewTextBoxColumn
            // 
            this.lngDataGridViewTextBoxColumn.DataPropertyName = "Lng";
            this.lngDataGridViewTextBoxColumn.HeaderText = "Lng";
            this.lngDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lngDataGridViewTextBoxColumn.Name = "lngDataGridViewTextBoxColumn";
            this.lngDataGridViewTextBoxColumn.ReadOnly = true;
            this.lngDataGridViewTextBoxColumn.Width = 125;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.toolStripProgressBarDownload);
            this.panel1.Controls.Add(this.toolStripStatusDownload);
            this.panel1.Controls.Add(this.buttonDrawDistance);
            this.panel1.Controls.Add(this.buttonPoiSave);
            this.panel1.Controls.Add(this.toolStripStatusPOIDownload);
            this.panel1.Controls.Add(this.dataGridViewPOI);
            this.panel1.Controls.Add(this.comboBoxCity);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.comboBoxProvince);
            this.panel1.Controls.Add(this.buttonAddressSearch);
            this.panel1.Controls.Add(this.textBoxAddress);
            this.panel1.Controls.Add(this.pictureZoomIn);
            this.panel1.Controls.Add(this.pictureZoomOut);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.longtitude);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.latitude);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(854, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(380, 657);
            this.panel1.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(29, 26);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 26);
            this.button2.TabIndex = 24;
            this.button2.Text = "选择区域";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // toolStripProgressBarDownload
            // 
            this.toolStripProgressBarDownload.Location = new System.Drawing.Point(240, 631);
            this.toolStripProgressBarDownload.Name = "toolStripProgressBarDownload";
            this.toolStripProgressBarDownload.Size = new System.Drawing.Size(100, 23);
            this.toolStripProgressBarDownload.TabIndex = 23;
            this.toolStripProgressBarDownload.Visible = false;
            // 
            // toolStripStatusDownload
            // 
            this.toolStripStatusDownload.AutoSize = true;
            this.toolStripStatusDownload.Location = new System.Drawing.Point(5, 633);
            this.toolStripStatusDownload.Name = "toolStripStatusDownload";
            this.toolStripStatusDownload.Size = new System.Drawing.Size(67, 15);
            this.toolStripStatusDownload.TabIndex = 22;
            this.toolStripStatusDownload.Text = "下载进度";
            this.toolStripStatusDownload.Visible = false;
            this.toolStripStatusDownload.Click += new System.EventHandler(this.toolStripStatusDownload_Click);
            // 
            // buttonDrawDistance
            // 
            this.buttonDrawDistance.Location = new System.Drawing.Point(197, 26);
            this.buttonDrawDistance.Name = "buttonDrawDistance";
            this.buttonDrawDistance.Size = new System.Drawing.Size(75, 26);
            this.buttonDrawDistance.TabIndex = 21;
            this.buttonDrawDistance.Text = "测距";
            this.buttonDrawDistance.UseVisualStyleBackColor = true;
            this.buttonDrawDistance.Click += new System.EventHandler(this.buttonDrawDistance_Click);
            // 
            // buttonPoiSave
            // 
            this.buttonPoiSave.Location = new System.Drawing.Point(287, 244);
            this.buttonPoiSave.Name = "buttonPoiSave";
            this.buttonPoiSave.Size = new System.Drawing.Size(75, 26);
            this.buttonPoiSave.TabIndex = 20;
            this.buttonPoiSave.Text = "保存";
            this.buttonPoiSave.UseVisualStyleBackColor = true;
            this.buttonPoiSave.Click += new System.EventHandler(this.buttonPoiSave_Click);
            // 
            // toolStripStatusPOIDownload
            // 
            this.toolStripStatusPOIDownload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.toolStripStatusPOIDownload.AutoSize = true;
            this.toolStripStatusPOIDownload.Location = new System.Drawing.Point(5, 612);
            this.toolStripStatusPOIDownload.Name = "toolStripStatusPOIDownload";
            this.toolStripStatusPOIDownload.Size = new System.Drawing.Size(67, 15);
            this.toolStripStatusPOIDownload.TabIndex = 19;
            this.toolStripStatusPOIDownload.Text = "搜索结果";
            this.toolStripStatusPOIDownload.Visible = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(27, 9);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(89, 28);
            this.button3.TabIndex = 0;
            this.button3.Text = "切换模式";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // poiDataBindingSource1
            // 
            this.poiDataBindingSource1.DataSource = typeof(GMapPOI.PoiData);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.图层清理ToolStripMenuItem,
            this.清理缓存ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1246, 28);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.矩形ToolStripMenuItem1,
            this.圆形ToolStripMenuItem1,
            this.多边形ToolStripMenuItem1});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(83, 24);
            this.toolStripMenuItem1.Text = "画图工具";
            // 
            // 矩形ToolStripMenuItem1
            // 
            this.矩形ToolStripMenuItem1.Name = "矩形ToolStripMenuItem1";
            this.矩形ToolStripMenuItem1.Size = new System.Drawing.Size(137, 26);
            this.矩形ToolStripMenuItem1.Text = "矩形";
            this.矩形ToolStripMenuItem1.Click += new System.EventHandler(this.矩形ToolStripMenuItem1_Click_1);
            // 
            // 圆形ToolStripMenuItem1
            // 
            this.圆形ToolStripMenuItem1.Name = "圆形ToolStripMenuItem1";
            this.圆形ToolStripMenuItem1.Size = new System.Drawing.Size(137, 26);
            this.圆形ToolStripMenuItem1.Text = "圆形";
            this.圆形ToolStripMenuItem1.Click += new System.EventHandler(this.圆形ToolStripMenuItem1_Click);
            // 
            // 多边形ToolStripMenuItem1
            // 
            this.多边形ToolStripMenuItem1.Name = "多边形ToolStripMenuItem1";
            this.多边形ToolStripMenuItem1.Size = new System.Drawing.Size(137, 26);
            this.多边形ToolStripMenuItem1.Text = "多边形";
            this.多边形ToolStripMenuItem1.Click += new System.EventHandler(this.多边形ToolStripMenuItem1_Click);
            // 
            // 图层清理ToolStripMenuItem
            // 
            this.图层清理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.清理画图ToolStripMenuItem1,
            this.清理测距ToolStripMenuItem1,
            this.清理标记ToolStripMenuItem});
            this.图层清理ToolStripMenuItem.Name = "图层清理ToolStripMenuItem";
            this.图层清理ToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.图层清理ToolStripMenuItem.Text = "图层清理";
            // 
            // 清理画图ToolStripMenuItem1
            // 
            this.清理画图ToolStripMenuItem1.Name = "清理画图ToolStripMenuItem1";
            this.清理画图ToolStripMenuItem1.Size = new System.Drawing.Size(152, 26);
            this.清理画图ToolStripMenuItem1.Text = "清理画图";
            this.清理画图ToolStripMenuItem1.Click += new System.EventHandler(this.清理画图ToolStripMenuItem1_Click);
            // 
            // 清理测距ToolStripMenuItem1
            // 
            this.清理测距ToolStripMenuItem1.Name = "清理测距ToolStripMenuItem1";
            this.清理测距ToolStripMenuItem1.Size = new System.Drawing.Size(152, 26);
            this.清理测距ToolStripMenuItem1.Text = "清理测距";
            // 
            // 清理标记ToolStripMenuItem
            // 
            this.清理标记ToolStripMenuItem.Name = "清理标记ToolStripMenuItem";
            this.清理标记ToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.清理标记ToolStripMenuItem.Text = "清理标记";
            this.清理标记ToolStripMenuItem.Click += new System.EventHandler(this.清理标记ToolStripMenuItem_Click);
            // 
            // 清理缓存ToolStripMenuItem
            // 
            this.清理缓存ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.删除下载文件ToolStripMenuItem});
            this.清理缓存ToolStripMenuItem.Name = "清理缓存ToolStripMenuItem";
            this.清理缓存ToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.清理缓存ToolStripMenuItem.Text = "清理缓存";
            this.清理缓存ToolStripMenuItem.Click += new System.EventHandler(this.清理缓存ToolStripMenuItem_Click);
            // 
            // 删除下载文件ToolStripMenuItem
            // 
            this.删除下载文件ToolStripMenuItem.Name = "删除下载文件ToolStripMenuItem";
            this.删除下载文件ToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.删除下载文件ToolStripMenuItem.Text = "删除下载文件";
            this.删除下载文件ToolStripMenuItem.Click += new System.EventHandler(this.删除下载文件ToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.advTreeChina);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Enabled = false;
            this.panel2.Location = new System.Drawing.Point(855, 29);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(380, 641);
            this.panel2.TabIndex = 10;
            this.panel2.Visible = false;
            // 
            // advTreeChina
            // 
            this.advTreeChina.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.advTreeChina.BackColor = System.Drawing.SystemColors.Control;
            this.advTreeChina.Location = new System.Drawing.Point(-6, 57);
            this.advTreeChina.Name = "advTreeChina";
            this.advTreeChina.Size = new System.Drawing.Size(397, 591);
            this.advTreeChina.TabIndex = 1;
            this.advTreeChina.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.advTreeChina_NodeMouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1246, 673);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.map);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "GMap在线地图";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.poiDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureZoomOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureZoomIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPOI)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.poiDataBindingSource1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl map;
        private System.Windows.Forms.BindingSource poiDataBindingSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox latitude;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox longtitude;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureZoomOut;
        private System.Windows.Forms.PictureBox pictureZoomIn;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Button buttonAddressSearch;
        private System.Windows.Forms.ComboBox comboBoxProvince;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxCity;
        private System.Windows.Forms.DataGridView dataGridViewPOI;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn provinceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn latDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lngDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label toolStripStatusPOIDownload;
        private System.Windows.Forms.Button buttonPoiSave;
        private System.Windows.Forms.BindingSource poiDataBindingSource1;
        private System.Windows.Forms.Button buttonDrawDistance;
        private System.Windows.Forms.Label toolStripStatusDownload;
        private System.Windows.Forms.ProgressBar toolStripProgressBarDownload;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 圆形ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 多边形ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 图层清理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 清理画图ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 清理测距ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 清理缓存ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除下载文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 矩形ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 清理标记ToolStripMenuItem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TreeView advTreeChina;
    }
}

