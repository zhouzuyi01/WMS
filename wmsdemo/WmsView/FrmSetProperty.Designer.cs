namespace WmsView
{
    partial class FrmSetProperty
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
            this.data_property = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.cbmateriels = new System.Windows.Forms.ComboBox();
            this.btn_selectmateriel = new System.Windows.Forms.Button();
            this.btn_selectproperty = new System.Windows.Forms.Button();
            this.btn_addproperty = new System.Windows.Forms.Button();
            this.btn_deleteproperty = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.data_property)).BeginInit();
            this.SuspendLayout();
            // 
            // data_property
            // 
            this.data_property.AllowUserToAddRows = false;
            this.data_property.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_property.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.data_property.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_property.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.data_property.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.data_property.Location = new System.Drawing.Point(0, 103);
            this.data_property.Name = "data_property";
            this.data_property.ReadOnly = true;
            this.data_property.RowTemplate.Height = 23;
            this.data_property.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data_property.Size = new System.Drawing.Size(509, 405);
            this.data_property.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "属性名称";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "属性值";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "物料";
            // 
            // cbmateriels
            // 
            this.cbmateriels.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmateriels.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbmateriels.FormattingEnabled = true;
            this.cbmateriels.Location = new System.Drawing.Point(58, 19);
            this.cbmateriels.Name = "cbmateriels";
            this.cbmateriels.Size = new System.Drawing.Size(121, 20);
            this.cbmateriels.TabIndex = 6;
            // 
            // btn_selectmateriel
            // 
            this.btn_selectmateriel.Location = new System.Drawing.Point(185, 17);
            this.btn_selectmateriel.Name = "btn_selectmateriel";
            this.btn_selectmateriel.Size = new System.Drawing.Size(92, 23);
            this.btn_selectmateriel.TabIndex = 7;
            this.btn_selectmateriel.Text = "刷新物料列表";
            this.btn_selectmateriel.UseVisualStyleBackColor = true;
            this.btn_selectmateriel.Click += new System.EventHandler(this.Btn_selectmateriel_Click);
            // 
            // btn_selectproperty
            // 
            this.btn_selectproperty.Location = new System.Drawing.Point(58, 65);
            this.btn_selectproperty.Name = "btn_selectproperty";
            this.btn_selectproperty.Size = new System.Drawing.Size(75, 23);
            this.btn_selectproperty.TabIndex = 8;
            this.btn_selectproperty.Text = "查询属性";
            this.btn_selectproperty.UseVisualStyleBackColor = true;
            this.btn_selectproperty.Click += new System.EventHandler(this.Btn_selectproperty_Click);
            // 
            // btn_addproperty
            // 
            this.btn_addproperty.Location = new System.Drawing.Point(185, 65);
            this.btn_addproperty.Name = "btn_addproperty";
            this.btn_addproperty.Size = new System.Drawing.Size(75, 23);
            this.btn_addproperty.TabIndex = 9;
            this.btn_addproperty.Text = "添加属性";
            this.btn_addproperty.UseVisualStyleBackColor = true;
            this.btn_addproperty.Click += new System.EventHandler(this.Btn_addproperty_Click);
            // 
            // btn_deleteproperty
            // 
            this.btn_deleteproperty.Location = new System.Drawing.Point(302, 65);
            this.btn_deleteproperty.Name = "btn_deleteproperty";
            this.btn_deleteproperty.Size = new System.Drawing.Size(75, 23);
            this.btn_deleteproperty.TabIndex = 10;
            this.btn_deleteproperty.Text = "删除属性";
            this.btn_deleteproperty.UseVisualStyleBackColor = true;
            this.btn_deleteproperty.Click += new System.EventHandler(this.Btn_deleteproperty_Click);
            // 
            // FrmSetProperty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 508);
            this.Controls.Add(this.btn_deleteproperty);
            this.Controls.Add(this.btn_addproperty);
            this.Controls.Add(this.btn_selectproperty);
            this.Controls.Add(this.btn_selectmateriel);
            this.Controls.Add(this.cbmateriels);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.data_property);
            this.Name = "FrmSetProperty";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "设置属性";
            this.Load += new System.EventHandler(this.FrmSetProperty_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_property)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView data_property;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbmateriels;
        private System.Windows.Forms.Button btn_selectmateriel;
        private System.Windows.Forms.Button btn_selectproperty;
        private System.Windows.Forms.Button btn_addproperty;
        private System.Windows.Forms.Button btn_deleteproperty;
    }
}