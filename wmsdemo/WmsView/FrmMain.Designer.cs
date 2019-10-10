namespace WmsView
{
    partial class FrmMain
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
            this.tb1 = new System.Windows.Forms.TabControl();
            this.p_ware = new System.Windows.Forms.TabPage();
            this.btn_add_ware = new System.Windows.Forms.Button();
            this.btn_select_ware = new System.Windows.Forms.Button();
            this.data_ware = new System.Windows.Forms.DataGridView();
            this.ware_warecode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ware_warename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ware_enable = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ware_rowcount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ware_columncount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ware_layercount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p_area = new System.Windows.Forms.TabPage();
            this.btn_setpoint_area = new System.Windows.Forms.Button();
            this.btn_setmateriel_area = new System.Windows.Forms.Button();
            this.btn_add_area = new System.Windows.Forms.Button();
            this.btn_select_area = new System.Windows.Forms.Button();
            this.btn_selectware_area = new System.Windows.Forms.Button();
            this.cbWares_area = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.data_area = new System.Windows.Forms.DataGridView();
            this.area_areacode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.area_areaname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.area_warecode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p_point = new System.Windows.Forms.TabPage();
            this.btn_setcontainer_point = new System.Windows.Forms.Button();
            this.btn_select_point = new System.Windows.Forms.Button();
            this.btn_selectareas_point = new System.Windows.Forms.Button();
            this.cbareas_point = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_selectwares_point = new System.Windows.Forms.Button();
            this.cbwares_point = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.data_point = new System.Windows.Forms.DataGridView();
            this.point_pointcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.point_areacode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.point_warecode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.point_pointstate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p_container = new System.Windows.Forms.TabPage();
            this.btn_add_container = new System.Windows.Forms.Button();
            this.btn_select_container = new System.Windows.Forms.Button();
            this.btn_selectwares_container = new System.Windows.Forms.Button();
            this.cbwares_container = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.data_container = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p_materiel = new System.Windows.Forms.TabPage();
            this.btn_setproperty_materiel = new System.Windows.Forms.Button();
            this.btn_add_materiel = new System.Windows.Forms.Button();
            this.btn_select_materiel = new System.Windows.Forms.Button();
            this.data_materiel = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p_pointstate = new System.Windows.Forms.TabPage();
            this.data_pointstate = new System.Windows.Forms.DataGridView();
            this.tb1.SuspendLayout();
            this.p_ware.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_ware)).BeginInit();
            this.p_area.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_area)).BeginInit();
            this.p_point.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_point)).BeginInit();
            this.p_container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_container)).BeginInit();
            this.p_materiel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_materiel)).BeginInit();
            this.p_pointstate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_pointstate)).BeginInit();
            this.SuspendLayout();
            // 
            // tb1
            // 
            this.tb1.Controls.Add(this.p_ware);
            this.tb1.Controls.Add(this.p_area);
            this.tb1.Controls.Add(this.p_point);
            this.tb1.Controls.Add(this.p_container);
            this.tb1.Controls.Add(this.p_materiel);
            this.tb1.Controls.Add(this.p_pointstate);
            this.tb1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb1.Location = new System.Drawing.Point(0, 0);
            this.tb1.Name = "tb1";
            this.tb1.SelectedIndex = 0;
            this.tb1.Size = new System.Drawing.Size(776, 519);
            this.tb1.TabIndex = 0;
            // 
            // p_ware
            // 
            this.p_ware.Controls.Add(this.btn_add_ware);
            this.p_ware.Controls.Add(this.btn_select_ware);
            this.p_ware.Controls.Add(this.data_ware);
            this.p_ware.Location = new System.Drawing.Point(4, 22);
            this.p_ware.Name = "p_ware";
            this.p_ware.Padding = new System.Windows.Forms.Padding(3);
            this.p_ware.Size = new System.Drawing.Size(768, 493);
            this.p_ware.TabIndex = 0;
            this.p_ware.Text = "仓库管理";
            this.p_ware.UseVisualStyleBackColor = true;
            // 
            // btn_add_ware
            // 
            this.btn_add_ware.Location = new System.Drawing.Point(130, 17);
            this.btn_add_ware.Name = "btn_add_ware";
            this.btn_add_ware.Size = new System.Drawing.Size(75, 23);
            this.btn_add_ware.TabIndex = 2;
            this.btn_add_ware.Text = "添加仓库";
            this.btn_add_ware.UseVisualStyleBackColor = true;
            this.btn_add_ware.Click += new System.EventHandler(this.Btn_add_ware_Click);
            // 
            // btn_select_ware
            // 
            this.btn_select_ware.Location = new System.Drawing.Point(19, 17);
            this.btn_select_ware.Name = "btn_select_ware";
            this.btn_select_ware.Size = new System.Drawing.Size(75, 23);
            this.btn_select_ware.TabIndex = 1;
            this.btn_select_ware.Text = "查询仓库";
            this.btn_select_ware.UseVisualStyleBackColor = true;
            this.btn_select_ware.Click += new System.EventHandler(this.Btn_select_ware_Click);
            // 
            // data_ware
            // 
            this.data_ware.AllowUserToAddRows = false;
            this.data_ware.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_ware.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.data_ware.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_ware.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ware_warecode,
            this.ware_warename,
            this.ware_enable,
            this.ware_rowcount,
            this.ware_columncount,
            this.ware_layercount});
            this.data_ware.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.data_ware.Location = new System.Drawing.Point(3, 65);
            this.data_ware.Name = "data_ware";
            this.data_ware.ReadOnly = true;
            this.data_ware.RowTemplate.Height = 23;
            this.data_ware.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data_ware.Size = new System.Drawing.Size(762, 425);
            this.data_ware.TabIndex = 0;
            // 
            // ware_warecode
            // 
            this.ware_warecode.HeaderText = "仓库编码";
            this.ware_warecode.Name = "ware_warecode";
            this.ware_warecode.ReadOnly = true;
            // 
            // ware_warename
            // 
            this.ware_warename.HeaderText = "仓库名称";
            this.ware_warename.Name = "ware_warename";
            this.ware_warename.ReadOnly = true;
            // 
            // ware_enable
            // 
            this.ware_enable.HeaderText = "是否启用";
            this.ware_enable.Name = "ware_enable";
            this.ware_enable.ReadOnly = true;
            // 
            // ware_rowcount
            // 
            this.ware_rowcount.HeaderText = "排数";
            this.ware_rowcount.Name = "ware_rowcount";
            this.ware_rowcount.ReadOnly = true;
            this.ware_rowcount.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ware_rowcount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ware_columncount
            // 
            this.ware_columncount.HeaderText = "列数";
            this.ware_columncount.Name = "ware_columncount";
            this.ware_columncount.ReadOnly = true;
            this.ware_columncount.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ware_columncount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ware_layercount
            // 
            this.ware_layercount.HeaderText = "层数";
            this.ware_layercount.Name = "ware_layercount";
            this.ware_layercount.ReadOnly = true;
            this.ware_layercount.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ware_layercount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // p_area
            // 
            this.p_area.Controls.Add(this.btn_setpoint_area);
            this.p_area.Controls.Add(this.btn_setmateriel_area);
            this.p_area.Controls.Add(this.btn_add_area);
            this.p_area.Controls.Add(this.btn_select_area);
            this.p_area.Controls.Add(this.btn_selectware_area);
            this.p_area.Controls.Add(this.cbWares_area);
            this.p_area.Controls.Add(this.label1);
            this.p_area.Controls.Add(this.data_area);
            this.p_area.Location = new System.Drawing.Point(4, 22);
            this.p_area.Name = "p_area";
            this.p_area.Padding = new System.Windows.Forms.Padding(3);
            this.p_area.Size = new System.Drawing.Size(768, 493);
            this.p_area.TabIndex = 1;
            this.p_area.Text = "区域管理";
            this.p_area.UseVisualStyleBackColor = true;
            // 
            // btn_setpoint_area
            // 
            this.btn_setpoint_area.Location = new System.Drawing.Point(643, 11);
            this.btn_setpoint_area.Name = "btn_setpoint_area";
            this.btn_setpoint_area.Size = new System.Drawing.Size(89, 23);
            this.btn_setpoint_area.TabIndex = 8;
            this.btn_setpoint_area.Text = "设置库位";
            this.btn_setpoint_area.UseVisualStyleBackColor = true;
            this.btn_setpoint_area.Click += new System.EventHandler(this.Btn_setpoint_area_Click);
            // 
            // btn_setmateriel_area
            // 
            this.btn_setmateriel_area.Location = new System.Drawing.Point(534, 11);
            this.btn_setmateriel_area.Name = "btn_setmateriel_area";
            this.btn_setmateriel_area.Size = new System.Drawing.Size(89, 23);
            this.btn_setmateriel_area.TabIndex = 7;
            this.btn_setmateriel_area.Text = "设置物料类型";
            this.btn_setmateriel_area.UseVisualStyleBackColor = true;
            this.btn_setmateriel_area.Click += new System.EventHandler(this.Btn_setmateriel_area_Click);
            // 
            // btn_add_area
            // 
            this.btn_add_area.Location = new System.Drawing.Point(436, 11);
            this.btn_add_area.Name = "btn_add_area";
            this.btn_add_area.Size = new System.Drawing.Size(75, 23);
            this.btn_add_area.TabIndex = 6;
            this.btn_add_area.Text = "添加区域";
            this.btn_add_area.UseVisualStyleBackColor = true;
            this.btn_add_area.Click += new System.EventHandler(this.Btn_add_area_Click);
            // 
            // btn_select_area
            // 
            this.btn_select_area.Location = new System.Drawing.Point(335, 11);
            this.btn_select_area.Name = "btn_select_area";
            this.btn_select_area.Size = new System.Drawing.Size(75, 23);
            this.btn_select_area.TabIndex = 5;
            this.btn_select_area.Text = "查询区域";
            this.btn_select_area.UseVisualStyleBackColor = true;
            this.btn_select_area.Click += new System.EventHandler(this.Btn_select_area_Click);
            // 
            // btn_selectware_area
            // 
            this.btn_selectware_area.Location = new System.Drawing.Point(211, 11);
            this.btn_selectware_area.Name = "btn_selectware_area";
            this.btn_selectware_area.Size = new System.Drawing.Size(92, 23);
            this.btn_selectware_area.TabIndex = 4;
            this.btn_selectware_area.Text = "刷新仓库列表";
            this.btn_selectware_area.UseVisualStyleBackColor = true;
            this.btn_selectware_area.Click += new System.EventHandler(this.Btn_selectware_area_Click);
            // 
            // cbWares_area
            // 
            this.cbWares_area.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbWares_area.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbWares_area.FormattingEnabled = true;
            this.cbWares_area.Location = new System.Drawing.Point(67, 13);
            this.cbWares_area.Name = "cbWares_area";
            this.cbWares_area.Size = new System.Drawing.Size(121, 20);
            this.cbWares_area.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "选择仓库";
            // 
            // data_area
            // 
            this.data_area.AllowUserToAddRows = false;
            this.data_area.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_area.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.data_area.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_area.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.area_areacode,
            this.area_areaname,
            this.area_warecode});
            this.data_area.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.data_area.Location = new System.Drawing.Point(3, 65);
            this.data_area.Name = "data_area";
            this.data_area.ReadOnly = true;
            this.data_area.RowTemplate.Height = 23;
            this.data_area.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data_area.Size = new System.Drawing.Size(762, 425);
            this.data_area.TabIndex = 1;
            // 
            // area_areacode
            // 
            this.area_areacode.HeaderText = "区域编码";
            this.area_areacode.Name = "area_areacode";
            this.area_areacode.ReadOnly = true;
            // 
            // area_areaname
            // 
            this.area_areaname.HeaderText = "区域名称";
            this.area_areaname.Name = "area_areaname";
            this.area_areaname.ReadOnly = true;
            // 
            // area_warecode
            // 
            this.area_warecode.HeaderText = "所属仓库";
            this.area_warecode.Name = "area_warecode";
            this.area_warecode.ReadOnly = true;
            this.area_warecode.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.area_warecode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // p_point
            // 
            this.p_point.Controls.Add(this.btn_setcontainer_point);
            this.p_point.Controls.Add(this.btn_select_point);
            this.p_point.Controls.Add(this.btn_selectareas_point);
            this.p_point.Controls.Add(this.cbareas_point);
            this.p_point.Controls.Add(this.label3);
            this.p_point.Controls.Add(this.btn_selectwares_point);
            this.p_point.Controls.Add(this.cbwares_point);
            this.p_point.Controls.Add(this.label2);
            this.p_point.Controls.Add(this.data_point);
            this.p_point.Location = new System.Drawing.Point(4, 22);
            this.p_point.Name = "p_point";
            this.p_point.Padding = new System.Windows.Forms.Padding(3);
            this.p_point.Size = new System.Drawing.Size(768, 493);
            this.p_point.TabIndex = 2;
            this.p_point.Text = "库位管理";
            this.p_point.UseVisualStyleBackColor = true;
            // 
            // btn_setcontainer_point
            // 
            this.btn_setcontainer_point.Location = new System.Drawing.Point(685, 13);
            this.btn_setcontainer_point.Name = "btn_setcontainer_point";
            this.btn_setcontainer_point.Size = new System.Drawing.Size(75, 23);
            this.btn_setcontainer_point.TabIndex = 10;
            this.btn_setcontainer_point.Text = "设置容器";
            this.btn_setcontainer_point.UseVisualStyleBackColor = true;
            this.btn_setcontainer_point.Click += new System.EventHandler(this.Btn_setcontainer_point_Click);
            // 
            // btn_select_point
            // 
            this.btn_select_point.Location = new System.Drawing.Point(604, 13);
            this.btn_select_point.Name = "btn_select_point";
            this.btn_select_point.Size = new System.Drawing.Size(75, 23);
            this.btn_select_point.TabIndex = 9;
            this.btn_select_point.Text = "查询库位";
            this.btn_select_point.UseVisualStyleBackColor = true;
            this.btn_select_point.Click += new System.EventHandler(this.Btn_select_point_Click);
            // 
            // btn_selectareas_point
            // 
            this.btn_selectareas_point.Location = new System.Drawing.Point(501, 13);
            this.btn_selectareas_point.Name = "btn_selectareas_point";
            this.btn_selectareas_point.Size = new System.Drawing.Size(87, 23);
            this.btn_selectareas_point.TabIndex = 8;
            this.btn_selectareas_point.Text = "刷新区域列表";
            this.btn_selectareas_point.UseVisualStyleBackColor = true;
            this.btn_selectareas_point.Click += new System.EventHandler(this.Btn_selectareas_point_Click);
            // 
            // cbareas_point
            // 
            this.cbareas_point.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbareas_point.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbareas_point.FormattingEnabled = true;
            this.cbareas_point.Location = new System.Drawing.Point(353, 15);
            this.cbareas_point.Name = "cbareas_point";
            this.cbareas_point.Size = new System.Drawing.Size(142, 20);
            this.cbareas_point.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(294, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "区域编码";
            // 
            // btn_selectwares_point
            // 
            this.btn_selectwares_point.Location = new System.Drawing.Point(199, 13);
            this.btn_selectwares_point.Name = "btn_selectwares_point";
            this.btn_selectwares_point.Size = new System.Drawing.Size(87, 23);
            this.btn_selectwares_point.TabIndex = 5;
            this.btn_selectwares_point.Text = "刷新仓库列表";
            this.btn_selectwares_point.UseVisualStyleBackColor = true;
            this.btn_selectwares_point.Click += new System.EventHandler(this.Btn_selectwares_point_Click);
            // 
            // cbwares_point
            // 
            this.cbwares_point.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbwares_point.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbwares_point.FormattingEnabled = true;
            this.cbwares_point.Location = new System.Drawing.Point(65, 15);
            this.cbwares_point.Name = "cbwares_point";
            this.cbwares_point.Size = new System.Drawing.Size(128, 20);
            this.cbwares_point.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "仓库编码";
            // 
            // data_point
            // 
            this.data_point.AllowUserToAddRows = false;
            this.data_point.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_point.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.data_point.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_point.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.point_pointcode,
            this.point_areacode,
            this.point_warecode,
            this.point_pointstate});
            this.data_point.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.data_point.Location = new System.Drawing.Point(3, 72);
            this.data_point.Name = "data_point";
            this.data_point.ReadOnly = true;
            this.data_point.RowTemplate.Height = 23;
            this.data_point.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data_point.Size = new System.Drawing.Size(762, 418);
            this.data_point.TabIndex = 2;
            // 
            // point_pointcode
            // 
            this.point_pointcode.HeaderText = "库位编码";
            this.point_pointcode.Name = "point_pointcode";
            this.point_pointcode.ReadOnly = true;
            // 
            // point_areacode
            // 
            this.point_areacode.HeaderText = "所在区域";
            this.point_areacode.Name = "point_areacode";
            this.point_areacode.ReadOnly = true;
            // 
            // point_warecode
            // 
            this.point_warecode.HeaderText = "所属仓库";
            this.point_warecode.Name = "point_warecode";
            this.point_warecode.ReadOnly = true;
            this.point_warecode.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.point_warecode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // point_pointstate
            // 
            this.point_pointstate.HeaderText = "库位状态";
            this.point_pointstate.Name = "point_pointstate";
            this.point_pointstate.ReadOnly = true;
            // 
            // p_container
            // 
            this.p_container.Controls.Add(this.btn_add_container);
            this.p_container.Controls.Add(this.btn_select_container);
            this.p_container.Controls.Add(this.btn_selectwares_container);
            this.p_container.Controls.Add(this.cbwares_container);
            this.p_container.Controls.Add(this.label4);
            this.p_container.Controls.Add(this.data_container);
            this.p_container.Location = new System.Drawing.Point(4, 22);
            this.p_container.Name = "p_container";
            this.p_container.Padding = new System.Windows.Forms.Padding(3);
            this.p_container.Size = new System.Drawing.Size(768, 493);
            this.p_container.TabIndex = 3;
            this.p_container.Text = "容器管理";
            this.p_container.UseVisualStyleBackColor = true;
            // 
            // btn_add_container
            // 
            this.btn_add_container.Location = new System.Drawing.Point(437, 16);
            this.btn_add_container.Name = "btn_add_container";
            this.btn_add_container.Size = new System.Drawing.Size(75, 23);
            this.btn_add_container.TabIndex = 8;
            this.btn_add_container.Text = "添加容器";
            this.btn_add_container.UseVisualStyleBackColor = true;
            this.btn_add_container.Click += new System.EventHandler(this.Btn_add_container_Click);
            // 
            // btn_select_container
            // 
            this.btn_select_container.Location = new System.Drawing.Point(341, 16);
            this.btn_select_container.Name = "btn_select_container";
            this.btn_select_container.Size = new System.Drawing.Size(75, 23);
            this.btn_select_container.TabIndex = 7;
            this.btn_select_container.Text = "查询容器";
            this.btn_select_container.UseVisualStyleBackColor = true;
            this.btn_select_container.Click += new System.EventHandler(this.Btn_select_container_Click);
            // 
            // btn_selectwares_container
            // 
            this.btn_selectwares_container.Location = new System.Drawing.Point(219, 16);
            this.btn_selectwares_container.Name = "btn_selectwares_container";
            this.btn_selectwares_container.Size = new System.Drawing.Size(87, 23);
            this.btn_selectwares_container.TabIndex = 6;
            this.btn_selectwares_container.Text = "刷新仓库列表";
            this.btn_selectwares_container.UseVisualStyleBackColor = true;
            this.btn_selectwares_container.Click += new System.EventHandler(this.Btn_selectwares_container_Click);
            // 
            // cbwares_container
            // 
            this.cbwares_container.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbwares_container.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbwares_container.FormattingEnabled = true;
            this.cbwares_container.Location = new System.Drawing.Point(67, 18);
            this.cbwares_container.Name = "cbwares_container";
            this.cbwares_container.Size = new System.Drawing.Size(146, 20);
            this.cbwares_container.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "仓库编码";
            // 
            // data_container
            // 
            this.data_container.AllowUserToAddRows = false;
            this.data_container.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_container.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.data_container.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_container.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.data_container.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.data_container.Location = new System.Drawing.Point(3, 65);
            this.data_container.Name = "data_container";
            this.data_container.ReadOnly = true;
            this.data_container.RowTemplate.Height = 23;
            this.data_container.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data_container.Size = new System.Drawing.Size(762, 425);
            this.data_container.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "容器编码";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "物料编码";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "容量";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // p_materiel
            // 
            this.p_materiel.Controls.Add(this.btn_setproperty_materiel);
            this.p_materiel.Controls.Add(this.btn_add_materiel);
            this.p_materiel.Controls.Add(this.btn_select_materiel);
            this.p_materiel.Controls.Add(this.data_materiel);
            this.p_materiel.Location = new System.Drawing.Point(4, 22);
            this.p_materiel.Name = "p_materiel";
            this.p_materiel.Padding = new System.Windows.Forms.Padding(3);
            this.p_materiel.Size = new System.Drawing.Size(768, 493);
            this.p_materiel.TabIndex = 4;
            this.p_materiel.Text = "物料管理";
            this.p_materiel.UseVisualStyleBackColor = true;
            // 
            // btn_setproperty_materiel
            // 
            this.btn_setproperty_materiel.Location = new System.Drawing.Point(291, 30);
            this.btn_setproperty_materiel.Name = "btn_setproperty_materiel";
            this.btn_setproperty_materiel.Size = new System.Drawing.Size(75, 23);
            this.btn_setproperty_materiel.TabIndex = 6;
            this.btn_setproperty_materiel.Text = "设置属性";
            this.btn_setproperty_materiel.UseVisualStyleBackColor = true;
            this.btn_setproperty_materiel.Click += new System.EventHandler(this.Btn_setproperty_materiel_Click);
            // 
            // btn_add_materiel
            // 
            this.btn_add_materiel.Location = new System.Drawing.Point(166, 30);
            this.btn_add_materiel.Name = "btn_add_materiel";
            this.btn_add_materiel.Size = new System.Drawing.Size(75, 23);
            this.btn_add_materiel.TabIndex = 5;
            this.btn_add_materiel.Text = "添加物料";
            this.btn_add_materiel.UseVisualStyleBackColor = true;
            this.btn_add_materiel.Click += new System.EventHandler(this.Btn_add_materiel_Click);
            // 
            // btn_select_materiel
            // 
            this.btn_select_materiel.Location = new System.Drawing.Point(51, 30);
            this.btn_select_materiel.Name = "btn_select_materiel";
            this.btn_select_materiel.Size = new System.Drawing.Size(75, 23);
            this.btn_select_materiel.TabIndex = 4;
            this.btn_select_materiel.Text = "查询物料";
            this.btn_select_materiel.UseVisualStyleBackColor = true;
            this.btn_select_materiel.Click += new System.EventHandler(this.Btn_select_materiel_Click);
            // 
            // data_materiel
            // 
            this.data_materiel.AllowUserToAddRows = false;
            this.data_materiel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_materiel.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.data_materiel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_materiel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.data_materiel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.data_materiel.Location = new System.Drawing.Point(3, 85);
            this.data_materiel.Name = "data_materiel";
            this.data_materiel.ReadOnly = true;
            this.data_materiel.RowTemplate.Height = 23;
            this.data_materiel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data_materiel.Size = new System.Drawing.Size(762, 405);
            this.data_materiel.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "物料编码";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "物料名称";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // p_pointstate
            // 
            this.p_pointstate.Controls.Add(this.data_pointstate);
            this.p_pointstate.Location = new System.Drawing.Point(4, 22);
            this.p_pointstate.Name = "p_pointstate";
            this.p_pointstate.Padding = new System.Windows.Forms.Padding(3);
            this.p_pointstate.Size = new System.Drawing.Size(768, 493);
            this.p_pointstate.TabIndex = 5;
            this.p_pointstate.Text = "库位状态管理";
            this.p_pointstate.UseVisualStyleBackColor = true;
            // 
            // data_pointstate
            // 
            this.data_pointstate.AllowUserToAddRows = false;
            this.data_pointstate.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_pointstate.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.data_pointstate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_pointstate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.data_pointstate.Location = new System.Drawing.Point(3, 65);
            this.data_pointstate.Name = "data_pointstate";
            this.data_pointstate.ReadOnly = true;
            this.data_pointstate.RowTemplate.Height = 23;
            this.data_pointstate.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data_pointstate.Size = new System.Drawing.Size(762, 425);
            this.data_pointstate.TabIndex = 3;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 519);
            this.Controls.Add(this.tb1);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WMS";
            this.tb1.ResumeLayout(false);
            this.p_ware.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data_ware)).EndInit();
            this.p_area.ResumeLayout(false);
            this.p_area.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_area)).EndInit();
            this.p_point.ResumeLayout(false);
            this.p_point.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_point)).EndInit();
            this.p_container.ResumeLayout(false);
            this.p_container.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_container)).EndInit();
            this.p_materiel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data_materiel)).EndInit();
            this.p_pointstate.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data_pointstate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tb1;
        private System.Windows.Forms.TabPage p_ware;
        private System.Windows.Forms.TabPage p_area;
        private System.Windows.Forms.TabPage p_point;
        private System.Windows.Forms.TabPage p_container;
        private System.Windows.Forms.TabPage p_materiel;
        private System.Windows.Forms.TabPage p_pointstate;
        private System.Windows.Forms.DataGridView data_ware;
        private System.Windows.Forms.DataGridView data_area;
        private System.Windows.Forms.DataGridViewTextBoxColumn ware_warecode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ware_warename;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ware_enable;
        private System.Windows.Forms.DataGridViewTextBoxColumn ware_rowcount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ware_columncount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ware_layercount;
        private System.Windows.Forms.DataGridViewTextBoxColumn area_areacode;
        private System.Windows.Forms.DataGridViewTextBoxColumn area_areaname;
        private System.Windows.Forms.DataGridViewTextBoxColumn area_warecode;
        private System.Windows.Forms.DataGridView data_point;
        private System.Windows.Forms.DataGridViewTextBoxColumn point_pointcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn point_areacode;
        private System.Windows.Forms.DataGridViewTextBoxColumn point_warecode;
        private System.Windows.Forms.DataGridViewTextBoxColumn point_pointstate;
        private System.Windows.Forms.Button btn_add_ware;
        private System.Windows.Forms.Button btn_select_ware;
        private System.Windows.Forms.Button btn_select_area;
        private System.Windows.Forms.Button btn_selectware_area;
        private System.Windows.Forms.ComboBox cbWares_area;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_add_area;
        private System.Windows.Forms.Button btn_setpoint_area;
        private System.Windows.Forms.Button btn_setmateriel_area;
        private System.Windows.Forms.DataGridView data_container;
        private System.Windows.Forms.DataGridView data_materiel;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridView data_pointstate;
        private System.Windows.Forms.Button btn_add_materiel;
        private System.Windows.Forms.Button btn_select_materiel;
        private System.Windows.Forms.Button btn_setproperty_materiel;
        private System.Windows.Forms.Button btn_selectareas_point;
        private System.Windows.Forms.ComboBox cbareas_point;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_selectwares_point;
        private System.Windows.Forms.ComboBox cbwares_point;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_select_point;
        private System.Windows.Forms.Button btn_setcontainer_point;
        private System.Windows.Forms.Button btn_selectwares_container;
        private System.Windows.Forms.ComboBox cbwares_container;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button btn_add_container;
        private System.Windows.Forms.Button btn_select_container;
    }
}

