using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WmsDemo;
namespace WmsView
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        #region 仓库管理
        private void Btn_select_ware_Click(object sender, EventArgs e)
        {
            var wares = WareManage.SelectWare();
            data_ware.Rows.Clear();
            wares.ForEach(ware =>
            {
                data_ware.Rows.Add(ware.warecode, ware.warename, ware.enable, ware.rowcount, ware.columncount, ware.layercount);
            });
        }

        private void Btn_add_ware_Click(object sender, EventArgs e)
        {
            FrmAddWare f = new FrmAddWare();
            f.ShowDialog();
        }
        #endregion

        #region 区域管理
        private void Btn_selectware_area_Click(object sender, EventArgs e)
        {
            var wares = WareManage.SelectWare();
            cbWares_area.Items.Clear();
            wares.ForEach(ware =>
            {
                cbWares_area.Items.Add(ware.warecode);
            });
            cbWares_area.SelectedIndex = 0;
        }

        private void Btn_select_area_Click(object sender, EventArgs e)
        {
            data_area.Rows.Clear();
            var areas = AreaManage.SelectArea(cbWares_area.SelectedItem.ToString());
            areas.ForEach(area =>
            {
                data_area.Rows.Add(area.areacode, area.areaname, area.warecode);
            });
        }

        private void Btn_add_area_Click(object sender, EventArgs e)
        {
            FrmAddArea f = new FrmAddArea();
            f.WareCode = cbWares_area.SelectedItem.ToString();
            f.ShowDialog();
        }

        private void Btn_setmateriel_area_Click(object sender, EventArgs e)
        {
            FrmSetMateriel f = new FrmSetMateriel();
            f.WareCode = cbWares_area.SelectedItem.ToString();
            f.AreaCode = data_area.SelectedRows[0].Cells[0].Value.ToString();
            f.ShowDialog();
        }

        private void Btn_setpoint_area_Click(object sender, EventArgs e)
        {
            FrmSetPoint f = new FrmSetPoint();
            f.WareCode = cbWares_area.SelectedItem.ToString();
            f.AreaCode = data_area.SelectedRows[0].Cells[0].Value.ToString();
            f.ShowDialog();
        }
        #endregion

        #region 物料管理
        private void Btn_select_materiel_Click(object sender, EventArgs e)
        {
            data_materiel.Rows.Clear();
            var materiels = MaterielManage.SelectMateriel();
            materiels.ForEach(materiel =>
            {
                data_materiel.Rows.Add(materiel.materielcode, materiel.materielname);
            });
        }

        private void Btn_add_materiel_Click(object sender, EventArgs e)
        {
            FrmAddMateriel f = new FrmAddMateriel();
            f.ShowDialog();
        }

        private void Btn_setproperty_materiel_Click(object sender, EventArgs e)
        {
            FrmSetProperty f = new FrmSetProperty();
            f.MaterielCode = data_materiel.SelectedRows[0].Cells[0].Value.ToString();
            f.ShowDialog();
        }

        #endregion

        #region 库位管理
        private void Btn_selectwares_point_Click(object sender, EventArgs e)
        {
            cbwares_point.Items.Clear();
            var wares = WareManage.SelectWare();
            wares.ForEach(ware =>
            {
                cbwares_point.Items.Add(ware.warecode);
            });

            if (cbwares_point.Items.Count > 0)
            {
                cbwares_point.SelectedIndex = 0;
            }
            Btn_selectareas_point_Click(null, null);
        }

        private void Btn_selectareas_point_Click(object sender, EventArgs e)
        {
            cbareas_point.Items.Clear();
            cbareas_point.Items.Add("全部区域");
            var areas = AreaManage.SelectArea(cbwares_point.SelectedItem.ToString());
            areas.ForEach(area =>
            {
                cbareas_point.Items.Add(area.areacode);
            });
            if (cbareas_point.Items.Count > 0)
            {
                cbareas_point.SelectedIndex = 0;
            }
        }

        private void Btn_select_point_Click(object sender, EventArgs e)
        {
            data_point.Rows.Clear();
            var points = new List<Point>();
            if (cbareas_point.SelectedItem.ToString() == "全部区域")
            {
                points = PointManage.SelectPointByWare(cbwares_point.SelectedItem.ToString());
            }
            else
            {
                points = PointManage.SelectPointByArea(cbwares_point.SelectedItem.ToString(), cbareas_point.SelectedItem.ToString());
            }
            points.ForEach(point =>
            {
                data_point.Rows.Add(point.pointcode, point.areacode, point.warecode, point.pointstate);
            });
        }

        private void Btn_setcontainer_point_Click(object sender, EventArgs e)
        {
            FrmSetContainer f = new FrmSetContainer();
            f.WareCode = cbwares_point.SelectedItem.ToString();
            f.AreaCode = cbareas_point.SelectedItem.ToString();
            f.PointCode = data_point.SelectedRows[0].Cells[0].Value.ToString();
            f.ShowDialog();
        }
        #endregion

        #region 容器管理
        private void Btn_selectwares_container_Click(object sender, EventArgs e)
        {
            cbwares_container.Items.Clear();
            var wares = WareManage.SelectWare();
            wares.ForEach(ware =>
            {
                cbwares_container.Items.Add(ware.warecode);
            });
            if (cbwares_container.Items.Count > 0)
                cbwares_container.SelectedIndex = 0;
        }

        private void Btn_select_container_Click(object sender, EventArgs e)
        {
            data_container.Rows.Clear();
            var containers = ContainerManage.SelectContainerByWare(cbwares_container.SelectedItem.ToString());
            containers.ForEach(container =>
            {
                data_container.Rows.Add(container.containercode, container.materielcode, container.capacity);
            });
        }

        private void Btn_add_container_Click(object sender, EventArgs e)
        {
            FrmAddContainer f = new FrmAddContainer();
            f.WareCode = cbwares_container.SelectedItem.ToString();
            f.ShowDialog();
        }
        #endregion
    }
}
