namespace WmsView
{
    partial class FrmAddWare
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtwarecode = new System.Windows.Forms.TextBox();
            this.txtwarename = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.txtrowcount = new System.Windows.Forms.TextBox();
            this.txtcolumncount = new System.Windows.Forms.TextBox();
            this.txtlayercount = new System.Windows.Forms.TextBox();
            this.btn_add_ware = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "仓库编码";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "仓库名称";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "是否启用";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "层数";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "列数";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "排数";
            // 
            // txtwarecode
            // 
            this.txtwarecode.Location = new System.Drawing.Point(115, 56);
            this.txtwarecode.Name = "txtwarecode";
            this.txtwarecode.Size = new System.Drawing.Size(161, 21);
            this.txtwarecode.TabIndex = 6;
            // 
            // txtwarename
            // 
            this.txtwarename.Location = new System.Drawing.Point(115, 96);
            this.txtwarename.Name = "txtwarename";
            this.txtwarename.Size = new System.Drawing.Size(161, 21);
            this.txtwarename.TabIndex = 7;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(190, 139);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // txtrowcount
            // 
            this.txtrowcount.Location = new System.Drawing.Point(115, 183);
            this.txtrowcount.Name = "txtrowcount";
            this.txtrowcount.Size = new System.Drawing.Size(161, 21);
            this.txtrowcount.TabIndex = 9;
            // 
            // txtcolumncount
            // 
            this.txtcolumncount.Location = new System.Drawing.Point(115, 226);
            this.txtcolumncount.Name = "txtcolumncount";
            this.txtcolumncount.Size = new System.Drawing.Size(161, 21);
            this.txtcolumncount.TabIndex = 10;
            // 
            // txtlayercount
            // 
            this.txtlayercount.Location = new System.Drawing.Point(115, 271);
            this.txtlayercount.Name = "txtlayercount";
            this.txtlayercount.Size = new System.Drawing.Size(161, 21);
            this.txtlayercount.TabIndex = 11;
            // 
            // btn_add_ware
            // 
            this.btn_add_ware.Location = new System.Drawing.Point(137, 338);
            this.btn_add_ware.Name = "btn_add_ware";
            this.btn_add_ware.Size = new System.Drawing.Size(75, 23);
            this.btn_add_ware.TabIndex = 12;
            this.btn_add_ware.Text = "添加仓库";
            this.btn_add_ware.UseVisualStyleBackColor = true;
            this.btn_add_ware.Click += new System.EventHandler(this.Btn_add_ware_Click);
            // 
            // FrmAddWare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 384);
            this.Controls.Add(this.btn_add_ware);
            this.Controls.Add(this.txtlayercount);
            this.Controls.Add(this.txtcolumncount);
            this.Controls.Add(this.txtrowcount);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.txtwarename);
            this.Controls.Add(this.txtwarecode);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmAddWare";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加仓库";
            this.Load += new System.EventHandler(this.FrmAddWare_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtwarecode;
        private System.Windows.Forms.TextBox txtwarename;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox txtrowcount;
        private System.Windows.Forms.TextBox txtcolumncount;
        private System.Windows.Forms.TextBox txtlayercount;
        private System.Windows.Forms.Button btn_add_ware;
    }
}