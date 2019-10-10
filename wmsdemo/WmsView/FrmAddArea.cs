using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WmsDemo;

namespace WmsView
{
    public partial class FrmAddArea : Form
    {
        public FrmAddArea()
        {
            InitializeComponent();
        }

        public string WareCode = "";

        private void Btn_add_Click(object sender, EventArgs e)
        {
            Area area = new Area();
            area.warecode = txtwarecode.Text;
            area.areacode = txtareacode.Text;
            area.areaname = txtareaname.Text;
            AreaManage.AddArea(area);

            MessageBox.Show("添加完成！");
            Close();
        }

        private void FrmAddArea_Load(object sender, EventArgs e)
        {
            txtwarecode.Text = WareCode;
            txtareacode.Text = WareCode + "_" + "001";
            txtareaname.Text = txtareacode.Text;
        }
    }
}
