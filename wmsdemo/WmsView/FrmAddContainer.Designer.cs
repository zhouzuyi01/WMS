namespace WmsView
{
    partial class FrmAddContainer
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
            this.txtwarecode = new System.Windows.Forms.TextBox();
            this.txtcontainercode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbmateriels = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtcapacity = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_select_materiel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "仓库编码";
            // 
            // txtwarecode
            // 
            this.txtwarecode.Location = new System.Drawing.Point(75, 51);
            this.txtwarecode.Name = "txtwarecode";
            this.txtwarecode.ReadOnly = true;
            this.txtwarecode.Size = new System.Drawing.Size(180, 21);
            this.txtwarecode.TabIndex = 1;
            // 
            // txtcontainercode
            // 
            this.txtcontainercode.Location = new System.Drawing.Point(75, 90);
            this.txtcontainercode.Name = "txtcontainercode";
            this.txtcontainercode.Size = new System.Drawing.Size(180, 21);
            this.txtcontainercode.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "容器编码";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "物料编码";
            // 
            // cbmateriels
            // 
            this.cbmateriels.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmateriels.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbmateriels.FormattingEnabled = true;
            this.cbmateriels.Location = new System.Drawing.Point(75, 130);
            this.cbmateriels.Name = "cbmateriels";
            this.cbmateriels.Size = new System.Drawing.Size(180, 20);
            this.cbmateriels.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "容量";
            // 
            // txtcapacity
            // 
            this.txtcapacity.Location = new System.Drawing.Point(75, 169);
            this.txtcapacity.Name = "txtcapacity";
            this.txtcapacity.Size = new System.Drawing.Size(180, 21);
            this.txtcapacity.TabIndex = 7;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(107, 219);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 8;
            this.btn_add.Text = "添加";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.Btn_add_Click);
            // 
            // btn_select_materiel
            // 
            this.btn_select_materiel.Location = new System.Drawing.Point(261, 128);
            this.btn_select_materiel.Name = "btn_select_materiel";
            this.btn_select_materiel.Size = new System.Drawing.Size(41, 23);
            this.btn_select_materiel.TabIndex = 9;
            this.btn_select_materiel.Text = "刷新";
            this.btn_select_materiel.UseVisualStyleBackColor = true;
            this.btn_select_materiel.Click += new System.EventHandler(this.Btn_select_materiel_Click);
            // 
            // FrmAddContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 258);
            this.Controls.Add(this.btn_select_materiel);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txtcapacity);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbmateriels);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtcontainercode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtwarecode);
            this.Controls.Add(this.label1);
            this.Name = "FrmAddContainer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加容器";
            this.Load += new System.EventHandler(this.FrmContainer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtwarecode;
        private System.Windows.Forms.TextBox txtcontainercode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbmateriels;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtcapacity;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_select_materiel;
    }
}