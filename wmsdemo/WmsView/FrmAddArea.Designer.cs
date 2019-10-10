namespace WmsView
{
    partial class FrmAddArea
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtwarecode = new System.Windows.Forms.TextBox();
            this.txtareacode = new System.Windows.Forms.TextBox();
            this.txtareaname = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "仓库编号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "区域编号";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "区域名称";
            // 
            // txtwarecode
            // 
            this.txtwarecode.Location = new System.Drawing.Point(129, 57);
            this.txtwarecode.Name = "txtwarecode";
            this.txtwarecode.ReadOnly = true;
            this.txtwarecode.Size = new System.Drawing.Size(193, 21);
            this.txtwarecode.TabIndex = 3;
            // 
            // txtareacode
            // 
            this.txtareacode.Location = new System.Drawing.Point(129, 107);
            this.txtareacode.Name = "txtareacode";
            this.txtareacode.Size = new System.Drawing.Size(193, 21);
            this.txtareacode.TabIndex = 4;
            // 
            // txtareaname
            // 
            this.txtareaname.Location = new System.Drawing.Point(129, 157);
            this.txtareaname.Name = "txtareaname";
            this.txtareaname.Size = new System.Drawing.Size(193, 21);
            this.txtareaname.TabIndex = 5;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(147, 216);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 6;
            this.btn_add.Text = "添加区域";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.Btn_add_Click);
            // 
            // FrmAddArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 274);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txtareaname);
            this.Controls.Add(this.txtareacode);
            this.Controls.Add(this.txtwarecode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmAddArea";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加区域";
            this.Load += new System.EventHandler(this.FrmAddArea_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtwarecode;
        private System.Windows.Forms.TextBox txtareacode;
        private System.Windows.Forms.TextBox txtareaname;
        private System.Windows.Forms.Button btn_add;
    }
}