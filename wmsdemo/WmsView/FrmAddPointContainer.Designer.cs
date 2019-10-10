namespace WmsView
{
    partial class FrmAddPointContainer
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
            this.txtpointcode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbcontainers = new System.Windows.Forms.ComboBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "库位编码";
            // 
            // txtpointcode
            // 
            this.txtpointcode.Location = new System.Drawing.Point(82, 54);
            this.txtpointcode.Name = "txtpointcode";
            this.txtpointcode.ReadOnly = true;
            this.txtpointcode.Size = new System.Drawing.Size(168, 21);
            this.txtpointcode.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "容器编码";
            // 
            // cbcontainers
            // 
            this.cbcontainers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbcontainers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbcontainers.FormattingEnabled = true;
            this.cbcontainers.Location = new System.Drawing.Point(82, 102);
            this.cbcontainers.Name = "cbcontainers";
            this.cbcontainers.Size = new System.Drawing.Size(168, 20);
            this.cbcontainers.TabIndex = 3;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(115, 176);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 4;
            this.btn_add.Text = "添加";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.Btn_add_Click);
            // 
            // FrmAddPointContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 248);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.cbcontainers);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtpointcode);
            this.Controls.Add(this.label1);
            this.Name = "FrmAddPointContainer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加容器";
            this.Load += new System.EventHandler(this.FrmAddPointContainer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtpointcode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbcontainers;
        private System.Windows.Forms.Button btn_add;
    }
}