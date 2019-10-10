namespace WmsView
{
    partial class FrmAddAreaPoint
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtareacode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbpointcode = new System.Windows.Forms.ComboBox();
            this.btn_select_point = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "区域编码";
            // 
            // txtareacode
            // 
            this.txtareacode.Location = new System.Drawing.Point(107, 40);
            this.txtareacode.Name = "txtareacode";
            this.txtareacode.ReadOnly = true;
            this.txtareacode.Size = new System.Drawing.Size(163, 21);
            this.txtareacode.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "库位编码";
            // 
            // cbpointcode
            // 
            this.cbpointcode.FormattingEnabled = true;
            this.cbpointcode.Location = new System.Drawing.Point(107, 103);
            this.cbpointcode.Name = "cbpointcode";
            this.cbpointcode.Size = new System.Drawing.Size(163, 20);
            this.cbpointcode.TabIndex = 3;
            // 
            // btn_select_point
            // 
            this.btn_select_point.Location = new System.Drawing.Point(276, 101);
            this.btn_select_point.Name = "btn_select_point";
            this.btn_select_point.Size = new System.Drawing.Size(60, 23);
            this.btn_select_point.TabIndex = 4;
            this.btn_select_point.Text = "刷新";
            this.btn_select_point.UseVisualStyleBackColor = true;
            this.btn_select_point.Click += new System.EventHandler(this.Btn_select_point_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(146, 169);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 5;
            this.btn_add.Text = "添加";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.Btn_add_Click);
            // 
            // FrmAddAreaPoint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 218);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_select_point);
            this.Controls.Add(this.cbpointcode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtareacode);
            this.Controls.Add(this.label1);
            this.Name = "FrmAddAreaPoint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加库位";
            this.Load += new System.EventHandler(this.FrmAddAreaPoint_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtareacode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbpointcode;
        private System.Windows.Forms.Button btn_select_point;
        private System.Windows.Forms.Button btn_add;
    }
}