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
    public partial class FrmSetPoint : Form
    {
        public FrmSetPoint()
        {
            InitializeComponent();
        }

        public string WareCode = "";

        public string AreaCode = "";

        private void FrmSetPoint_Load(object sender, EventArgs e)
        {
            Btn_select_areas_Click(null, null);
        }

        private void Btn_select_areas_Click(object sender, EventArgs e)
        {
            cbareas.Items.Clear();
            var areas = AreaManage.SelectArea(WareCode);
            areas.ForEach(area =>
            {
                cbareas.Items.Add(area.areacode);
            });
            cbareas.SelectedItem = AreaCode;
        }

        private void Btn_select_Click(object sender, EventArgs e)
        {
            data_point.Rows.Clear();
            var points = PointManage.SelectPointByArea(WareCode, cbareas.SelectedItem.ToString());
            points.ForEach(point =>
            {
                data_point.Rows.Add(point.pointcode, point.pointstate, point.warecode);
            });
        }

        private void Btn_add_Click(object sender, EventArgs e)
        {
            FrmAddAreaPoint f = new FrmAddAreaPoint();
            f.WareCode = WareCode;
            f.AreaCode = cbareas.SelectedItem.ToString();
            f.ShowDialog();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            AreaManage.RemovePoint(cbareas.SelectedItem.ToString(), data_point.SelectedRows[0].Cells[0].Value.ToString());
            MessageBox.Show("删除完成！");
        }
    }
}
