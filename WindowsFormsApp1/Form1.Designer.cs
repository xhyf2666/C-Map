
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
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
            this.toolStripStatusPOIDownload = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            ((System.ComponentModel.ISupportInitialize)(this.poiDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureZoomOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureZoomIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPOI)).BeginInit();
            this.panel1.SuspendLayout();
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
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1246, 25);
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "纬度";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // latitude
            // 
            this.latitude.Location = new System.Drawing.Point(88, 69);
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
            this.label1.Location = new System.Drawing.Point(26, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "经度";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // longtitude
            // 
            this.longtitude.Location = new System.Drawing.Point(88, 27);
            this.longtitude.Name = "longtitude";
            this.longtitude.Size = new System.Drawing.Size(100, 25);
            this.longtitude.TabIndex = 3;
            this.longtitude.TextChanged += new System.EventHandler(this.longtitude_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(244, 27);
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
            this.pictureZoomOut.Location = new System.Drawing.Point(143, 100);
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
            this.pictureZoomIn.Location = new System.Drawing.Point(29, 100);
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
            this.panel1.Controls.Add(this.toolStripStatusPOIDownload);
            this.panel1.Controls.Add(this.statusStrip1);
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
            this.panel1.Location = new System.Drawing.Point(854, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(380, 657);
            this.panel1.TabIndex = 7;
            // 
            // toolStripStatusPOIDownload
            // 
            this.toolStripStatusPOIDownload.AutoSize = true;
            this.toolStripStatusPOIDownload.Location = new System.Drawing.Point(5, 619);
            this.toolStripStatusPOIDownload.Name = "toolStripStatusPOIDownload";
            this.toolStripStatusPOIDownload.Size = new System.Drawing.Size(67, 15);
            this.toolStripStatusPOIDownload.TabIndex = 19;
            this.toolStripStatusPOIDownload.Text = "搜索结果";
            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(7, 612);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(202, 22);
            this.statusStrip1.TabIndex = 18;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1246, 673);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.map);
            this.Name = "Form1";
            this.Text = "寄Map";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.poiDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureZoomOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureZoomIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPOI)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl map;
        private System.Windows.Forms.ToolStrip toolStrip1;
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
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Label toolStripStatusPOIDownload;
    }
}

