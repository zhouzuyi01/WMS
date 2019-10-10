namespace WmsView
{
    partial class FrmAddMateriel
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
            this.txtmaterielname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_add_materiel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "物料编码";
            // 
            // txtmaterielcode
            // 
            this.txtmaterielcode.Location = new System.Drawing.Point(110, 34);
            this.txtmaterielcode.Name = "txtmaterielcode";
            this.txtmaterielcode.Size = new System.Drawing.Size(155, 21);
            this.txtmaterielcode.TabIndex = 1;
            // 
            // txtmaterielname
            // 
            this.txtmaterielname.Location = new System.Drawing.Point(110, 80);
            this.txtmaterielname.Name = "txtmaterielname";
            this.txtmaterielname.Size = new System.Drawing.Size(155, 21);
            this.txtmaterielname.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "物料名称";
            // 
            // btn_add_materiel
            // 
            this.btn_add_materiel.Location = new System.Drawing.Point(137, 143);
            this.btn_add_materiel.Name = "btn_add_materiel";
            this.btn_add_materiel.Size = new System.Drawing.Size(75, 23);
            this.btn_add_materiel.TabIndex = 4;
            this.btn_add_materiel.Text = "添加";
            this.btn_add_materiel.UseVisualStyleBackColor = true;
            this.btn_add_materiel.Click += new System.EventHandler(this.Btn_add_materiel_Click);
            // 
            // FrmAddMateriel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 201);
            this.Controls.Add(this.btn_add_materiel);
            this.Controls.Add(this.txtmaterielname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtmaterielcode);
            this.Controls.Add(this.label1);
            this.Name = "FrmAddMateriel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加物料";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmaterielcode;
        private System.Windows.Forms.TextBox txtmaterielname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_add_materiel;
    }
}