namespace WmsView
{
    partial class FrmSetPoint
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.data_point = new System.Windows.Forms.DataGridView();
            this.point_pointcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.point_areacode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.cbareas = new System.Windows.Forms.ComboBox();
            this.btn_select_areas = new System.Windows.Forms.Button();
            this.btn_select = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.data_point)).BeginInit();
            this.SuspendLayout();
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
            this.Column1});
            this.data_point.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.data_point.Location = new System.Drawing.Point(0, 75);
            this.data_point.Name = "data_point";
            this.data_point.ReadOnly = true;
            this.data_point.RowTemplate.Height = 23;
            this.data_point.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data_point.Size = new System.Drawing.Size(665, 399);
            this.data_point.TabIndex = 4;
            // 
            // point_pointcode
            // 
            this.point_pointcode.HeaderText = "库位编码";
            this.point_pointcode.Name = "point_pointcode";
            this.point_pointcode.ReadOnly = true;
            // 
            // point_areacode
            // 
            this.point_areacode.HeaderText = "库位状态";
            this.point_areacode.Name = "point_areacode";
            this.point_areacode.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "所属仓库";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "区域";
            // 
            // cbareas
            // 
            this.cbareas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbareas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbareas.FormattingEnabled = true;
            this.cbareas.Location = new System.Drawing.Point(47, 22);
            this.cbareas.Name = "cbareas";
            this.cbareas.Size = new System.Drawing.Size(162, 20);
            this.cbareas.TabIndex = 6;
            // 
            // btn_select_areas
            // 
            this.btn_select_areas.Location = new System.Drawing.Point(215, 20);
            this.btn_select_areas.Name = "btn_select_areas";
            this.btn_select_areas.Size = new System.Drawing.Size(85, 23);
            this.btn_select_areas.TabIndex = 7;
            this.btn_select_areas.Text = "刷新区域列表";
            this.btn_select_areas.UseVisualStyleBackColor = true;
            this.btn_select_areas.Click += new System.EventHandler(this.Btn_select_areas_Click);
            // 
            // btn_select
            // 
            this.btn_select.Location = new System.Drawing.Point(319, 20);
            this.btn_select.Name = "btn_select";
            this.btn_select.Size = new System.Drawing.Size(75, 23);
            this.btn_select.TabIndex = 8;
            this.btn_select.Text = "查询库位";
            this.btn_select.UseVisualStyleBackColor = true;
            this.btn_select.Click += new System.EventHandler(this.Btn_select_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(414, 20);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 9;
            this.btn_add.Text = "添加库位";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.Btn_add_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(515, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "移除库位";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // FrmSetPoint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 474);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_select);
            this.Controls.Add(this.btn_select_areas);
            this.Controls.Add(this.cbareas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.data_point);
            this.Name = "FrmSetPoint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "设置库位";
            this.Load += new System.EventHandler(this.FrmSetPoint_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_point)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView data_point;
        private System.Windows.Forms.DataGridViewTextBoxColumn point_pointcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn point_areacode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbareas;
        private System.Windows.Forms.Button btn_select_areas;
        private System.Windows.Forms.Button btn_select;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button button1;
    }
}