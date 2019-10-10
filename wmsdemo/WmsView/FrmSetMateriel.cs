using System;
using System.Windows.Forms;
using WmsDemo;

namespace WmsView
{
    public partial class FrmSetMateriel : Form
    {
        public FrmSetMateriel()
        {
            InitializeComponent();
        }

        public string WareCode = "";

        public string AreaCode = "";

        private void FrmSetMateriel_Load(object sender, EventArgs e)
        {
            var areas = AreaManage.SelectArea(WareCode);
            cbareacode.Items.Clear();
            areas.ForEach(area => cbareacode.Items.Add(area.areacode));
            cbareacode.SelectedItem = AreaCode;

            var materiels = MaterielManage.SelectMateriel();
            cbmaterielcode.Items.Clear();
            materiels.ForEach(materiel => cbmaterielcode.Items.Add(materiel.materielcode));
            if (cbmaterielcode.Items.Count > 0)
                cbmaterielcode.SelectedIndex = 0;
        }

        private void Btn_select_Click(object sender, EventArgs e)
        {
            var materiels = AreaManage.SelectMaterielByArea(cbareacode.SelectedItem.ToString());
            data_area.Rows.Clear();
            materiels.ForEach(materiel =>
            {
                data_area.Rows.Add(materiel.AreaCode, materiel.MaterielCode);
            });
        }

        private void Btn_add_Click(object sender, EventArgs e)
        {
            AreaManage.SetMateriel(cbareacode.SelectedItem.ToString(), cbmaterielcode.SelectedItem.ToString());
            MessageBox.Show("添加完成！");
        }

        private void Btn_delete_Click(object sender, EventArgs e)
        {
            var row = data_area.SelectedRows[0];
            AreaManage.RemoveMateriel(row.Cells[0].Value.ToString(), row.Cells[1].Value.ToString());
            MessageBox.Show("删除成功！");
        }
    }
}
