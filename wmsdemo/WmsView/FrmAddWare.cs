using System;
using System.Windows.Forms;
using WmsDemo;

namespace WmsView
{
    public partial class FrmAddWare : Form
    {
        public FrmAddWare()
        {
            InitializeComponent();
        }

        private void Btn_add_ware_Click(object sender, EventArgs e)
        {
            Ware ware = new Ware();
            ware.warecode = txtwarecode.Text;
            ware.warename = txtwarename.Text;
            ware.enable = checkBox1.Checked;
            ware.rowcount = Convert.ToInt32(txtrowcount.Text);
            ware.columncount = Convert.ToInt32(txtcolumncount.Text);
            ware.layercount = Convert.ToInt32(txtlayercount.Text);

            WareManage.AddWare(ware);

            for (int i = 1; i <= ware.rowcount; i++)
            {
                for (int j = 1; j <= ware.columncount; j++)
                {
                    for (int k = 1; k <= ware.layercount; k++)
                    {
                        Point point = new Point();
                        point.pointcode = ware.warecode + "_" + i.ToString("00") + j.ToString("00") + k.ToString("00");
                        point.areacode = "";
                        point.pointstate = "";
                        point.warecode = ware.warecode;
                        PointManage.AddPoint(point);
                    }
                }
            }


            MessageBox.Show("添加成功!");
            Close();
        }

        private void FrmAddWare_Load(object sender, EventArgs e)
        {
            txtwarecode.Text = DateTime.Now.ToString("yyyyMMddHHmmss");
            txtwarename.Text= DateTime.Now.ToString("yyyyMMddHHmmss");
            checkBox1.Checked = true;
            txtrowcount.Text = "10";
            txtcolumncount.Text = "10";
            txtlayercount.Text = "10";
        }
    }
}
