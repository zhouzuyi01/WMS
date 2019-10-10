namespace WmsView
{
    partial class FrmSetMateriel
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
            this.data_area = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cbareacode = new System.Windows.Forms.ComboBox();
            this.cbmaterielcode = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_select = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.area_areacode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materielcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.data_area)).BeginInit();
            this.SuspendLayout();
            // 
            // data_area
            // 
            this.data_area.AllowUserToAddRows = false;
            this.data_area.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_area.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.data_area.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_area.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.area_areacode,
            this.materielcode});
            this.data_area.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.data_area.Location = new System.Drawing.Point(0, 84);
            this.data_area.Name = "data_area";
            this.data_area.ReadOnly = true;
            this.data_area.RowTemplate.Height = 23;
            this.data_area.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data_area.Size = new System.Drawing.Size(686, 402);
            this.data_area.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "区域编码";
            // 
            // cbareacode
            // 
            this.cbareacode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbareacode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbareacode.FormattingEnabled = true;
            this.cbareacode.Location = new System.Drawing.Point(71, 25);
            this.cbareacode.Name = "cbareacode";
            this.cbareacode.Size = new System.Drawing.Size(148, 20);
            this.cbareacode.TabIndex = 4;
            // 
            // cbmaterielcode
            // 
            this.cbmaterielcode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmaterielcode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbmaterielcode.FormattingEnabled = true;
            this.cbmaterielcode.Location = new System.Drawing.Point(292, 25);
            this.cbmaterielcode.Name = "cbmaterielcode";
            this.cbmaterielcode.Size = new System.Drawing.Size(148, 20);
            this.cbmaterielcode.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(233, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "物料编码";
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(527, 23);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 7;
            this.btn_add.Text = "添加";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.Btn_add_Click);
            // 
            // btn_select
            // 
            this.btn_select.Location = new System.Drawing.Point(446, 23);
            this.btn_select.Name = "btn_select";
            this.btn_select.Size = new System.Drawing.Size(75, 23);
            this.btn_select.TabIndex = 8;
            this.btn_select.Text = "查询";
            this.btn_select.UseVisualStyleBackColor = true;
            this.btn_select.Click += new System.EventHandler(this.Btn_select_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(608, 23);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 9;
            this.btn_delete.Text = "删除";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.Btn_delete_Click);
            // 
            // area_areacode
            // 
            this.area_areacode.HeaderText = "区域编码";
            this.area_areacode.Name = "area_areacode";
            this.area_areacode.ReadOnly = true;
            // 
            // materielcode
            // 
            this.materielcode.HeaderText = "物料编码";
            this.materielcode.Name = "materielcode";
            this.materielcode.ReadOnly = true;
            // 
            // FrmSetMateriel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 486);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_select);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.cbmaterielcode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbareacode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.data_area);
            this.Name = "FrmSetMateriel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "设置物料类型";
            this.Load += new System.EventHandler(this.FrmSetMateriel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_area)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView data_area;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbareacode;
        private System.Windows.Forms.ComboBox cbmaterielcode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_select;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn area_areacode;
        private System.Windows.Forms.DataGridViewTextBoxColumn materielcode;
    }
}