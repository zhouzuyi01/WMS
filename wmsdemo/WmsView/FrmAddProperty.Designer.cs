﻿namespace WmsView
{
    partial class FrmAddProperty
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
            this.txtmaterielcode = new System.Windows.Forms.TextBox();
            this.txtpropertyname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtpropertyvalue = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "物料编码";
            // 
            // txtmaterielcode
            // 
            this.txtmaterielcode.Location = new System.Drawing.Point(107, 45);
            this.txtmaterielcode.Name = "txtmaterielcode";
            this.txtmaterielcode.ReadOnly = true;
            this.txtmaterielcode.Size = new System.Drawing.Size(147, 21);
            this.txtmaterielcode.TabIndex = 1;
            // 
            // txtpropertyname
            // 
            this.txtpropertyname.Location = new System.Drawing.Point(107, 102);
            this.txtpropertyname.Name = "txtpropertyname";
            this.txtpropertyname.Size = new System.Drawing.Size(147, 21);
            this.txtpropertyname.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "属性名称";
            // 
            // txtpropertyvalue
            // 
            this.txtpropertyvalue.Location = new System.Drawing.Point(107, 156);
            this.txtpropertyvalue.Name = "txtpropertyvalue";
            this.txtpropertyvalue.Size = new System.Drawing.Size(147, 21);
            this.txtpropertyvalue.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "属性值";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(139, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "添加";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // FrmAddProperty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 280);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtpropertyvalue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtpropertyname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtmaterielcode);
            this.Controls.Add(this.label1);
            this.Name = "FrmAddProperty";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加属性";
            this.Load += new System.EventHandler(this.FrmAddProperty_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmaterielcode;
        private System.Windows.Forms.TextBox txtpropertyname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtpropertyvalue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}