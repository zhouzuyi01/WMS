namespace WmsView
{
    partial class FrmSetContainer
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
            this.cbpoints = new System.Windows.Forms.ComboBox();
            this.btn_select_point = new System.Windows.Forms.Button();
            this.btn_select_container = new System.Windows.Forms.Button();
            this.btn_add_container = new System.Windows.Forms.Button();
            this.btn_delete_container = new System.Windows.Forms.Button();
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
            this.data_point.Location = new System.Drawing.Point(0, 86);
            this.data_point.Name = "data_point";
            this.data_point.ReadOnly = true;
            this.data_point.RowTemplate.Height = 23;
            this.data_point.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data_point.Size = new System.Drawing.Size(643, 399);
            this.data_point.TabIndex = 3;
            // 
            // point_pointcode
            // 
            this.point_pointcode.HeaderText = "容器编码";
            this.point_pointcode.Name = "point_pointcode";
            this.point_pointcode.ReadOnly = true;
            // 
            // point_areacode
            // 
            this.point_areacode.HeaderText = "物料类型";
            this.point_areacode.Name = "point_areacode";
            this.point_areacode.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "容量";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "库位编码";
            // 
            // cbpoints
            // 
            this.cbpoints.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbpoints.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbpoints.FormattingEnabled = true;
            this.cbpoints.Location = new System.Drawing.Point(67, 29);
            this.cbpoints.Name = "cbpoints";
            this.cbpoints.Size = new System.Drawing.Size(178, 20);
            this.cbpoints.TabIndex = 5;
            // 
            // btn_select_point
            // 
            this.btn_select_point.Location = new System.Drawing.Point(251, 27);
            this.btn_select_point.Name = "btn_select_point";
            this.btn_select_point.Size = new System.Drawing.Size(87, 23);
            this.btn_select_point.TabIndex = 15;
            this.btn_select_point.Text = "刷新区域列表";
            this.btn_select_point.UseVisualStyleBackColor = true;
            this.btn_select_point.Click += new System.EventHandler(this.Btn_select_point_Click);
            // 
            // btn_select_container
            // 
            this.btn_select_container.Location = new System.Drawing.Point(362, 27);
            this.btn_select_container.Name = "btn_select_container";
            this.btn_select_container.Size = new System.Drawing.Size(75, 23);
            this.btn_select_container.TabIndex = 16;
            this.btn_select_container.Text = "查询容器";
            this.btn_select_container.UseVisualStyleBackColor = true;
            this.btn_select_container.Click += new System.EventHandler(this.Btn_select_container_Click);
            // 
            // btn_add_container
            // 
            this.btn_add_container.Location = new System.Drawing.Point(454, 27);
            this.btn_add_container.Name = "btn_add_container";
            this.btn_add_container.Size = new System.Drawing.Size(75, 23);
            this.btn_add_container.TabIndex = 17;
            this.btn_add_container.Text = "添加容器";
            this.btn_add_container.UseVisualStyleBackColor = true;
            this.btn_add_container.Click += new System.EventHandler(this.Btn_add_container_Click);
            // 
            // btn_delete_container
            // 
            this.btn_delete_container.Location = new System.Drawing.Point(547, 27);
            this.btn_delete_container.Name = "btn_delete_container";
            this.btn_delete_container.Size = new System.Drawing.Size(75, 23);
            this.btn_delete_container.TabIndex = 18;
            this.btn_delete_container.Text = "删除容器";
            this.btn_delete_container.UseVisualStyleBackColor = true;
            this.btn_delete_container.Click += new System.EventHandler(this.Btn_delete_container_Click);
            // 
            // FrmSetContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 485);
            this.Controls.Add(this.btn_delete_container);
            this.Controls.Add(this.btn_add_container);
            this.Controls.Add(this.btn_select_container);
            this.Controls.Add(this.btn_select_point);
            this.Controls.Add(this.cbpoints);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.data_point);
            this.Name = "FrmSetContainer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "设置容器";
            this.Load += new System.EventHandler(this.FrmSetContainer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_point)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView data_point;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbpoints;
        private System.Windows.Forms.Button btn_select_point;
        private System.Windows.Forms.Button btn_select_container;
        private System.Windows.Forms.Button btn_add_container;
        private System.Windows.Forms.Button btn_delete_container;
        private System.Windows.Forms.DataGridViewTextBoxColumn point_pointcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn point_areacode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}