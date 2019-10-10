using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WmsDemo;
using Point = WmsDemo.Point;

namespace WmsView
{
    public partial class FrmSetContainer : Form
    {
        public FrmSetContainer()
        {
            InitializeComponent();
        }

        public string WareCode = "";

        public string AreaCode = "";

        public string PointCode = "";

        private void FrmSetContainer_Load(object sender, EventArgs e)
        {
            cbpoints.SelectedItem = PointCode;
            Btn_select_point_Click(null, null);
        }

        private void Btn_select_point_Click(object sender, EventArgs e)
        {
            data_point.Rows.Clear();
            var points = new List<Point>();
            if (AreaCode == "全部区域")
            {
                points = PointManage.SelectPointByWare(WareCode);
            }
            else
            {
                points = PointManage.SelectPointByArea(WareCode, AreaCode);
            }
            points.ForEach(point =>
            {
                cbpoints.Items.Add(point.pointcode);
            });
            cbpoints.SelectedItem = PointCode;
        }

        private void Btn_select_container_Click(object sender, EventArgs e)
        {
            data_point.Rows.Clear();
            var containers = ContainerManage.SelectContainer(cbpoints.SelectedItem.ToString());
            containers.ForEach(container =>
            {
                data_point.Rows.Add(container.containercode, container.materielcode, container.capacity);
            });
        }

        private void Btn_add_container_Click(object sender, EventArgs e)
        {
            FrmAddPointContainer f = new FrmAddPointContainer();
            f.WareCode = WareCode;
            f.PointCode = cbpoints.SelectedItem.ToString();
            f.ShowDialog();
        }

        private void Btn_delete_container_Click(object sender, EventArgs e)
        {
            PointManage.RemoveContainer(cbpoints.SelectedItem.ToString(), data_point.SelectedRows[0].Cells[0].Value.ToString());
            MessageBox.Show("删除完成！");
        }
    }
}
