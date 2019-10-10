using System;
using System.Windows.Forms;
using WmsDemo;

namespace WmsView
{
    public partial class FrmAddAreaPoint : Form
    {
        public FrmAddAreaPoint()
        {
            InitializeComponent();
        }

        public string WareCode = "";

        public string AreaCode = "";

        private void FrmAddAreaPoint_Load(object sender, EventArgs e)
        {
            txtareacode.Text = AreaCode;
            Btn_select_point_Click(null, null);
        }

        private void Btn_select_point_Click(object sender, EventArgs e)
        {
            cbpointcode.Items.Clear();
            var points = PointManage.SelectPointByArea(WareCode, "");
            points.ForEach(point =>
            {
                cbpointcode.Items.Add(point.pointcode);
            });
            if (cbpointcode.Items.Count > 0)
                cbpointcode.SelectedIndex = 0;
        }

        private void Btn_add_Click(object sender, EventArgs e)
        {
            AreaManage.SetPoint(txtareacode.Text, cbpointcode.SelectedItem.ToString());
            MessageBox.Show("添加完成！");
            Close();
        }
    }
}
