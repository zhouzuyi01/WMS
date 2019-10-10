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
    public partial class FrmSetProperty : Form
    {
        public FrmSetProperty()
        {
            InitializeComponent();
        }

        public string MaterielCode = "";

        private void FrmSetProperty_Load(object sender, EventArgs e)
        {
            Btn_selectmateriel_Click(null, null);
        }

        private void Btn_selectmateriel_Click(object sender, EventArgs e)
        {
            cbmateriels.Items.Clear();
            var materiels = MaterielManage.SelectMateriel();
            materiels.ForEach(materiel =>
            {
                cbmateriels.Items.Add(materiel.materielcode);
            });
            cbmateriels.SelectedItem = MaterielCode;
        }

        private void Btn_selectproperty_Click(object sender, EventArgs e)
        {
            data_property.Rows.Clear();
            var propertys = MaterielManage.SelectProperty(cbmateriels.SelectedItem.ToString());
            propertys.ForEach(property =>
            {
                data_property.Rows.Add(property.propertyname, property.propertyvalue);
            });
        }

        private void Btn_addproperty_Click(object sender, EventArgs e)
        {
            FrmAddProperty f = new FrmAddProperty();
            f.MaterielCode = cbmateriels.SelectedItem.ToString();
            f.ShowDialog();
        }

        private void Btn_deleteproperty_Click(object sender, EventArgs e)
        {
            MaterielManage.RemoveProperty(cbmateriels.SelectedItem.ToString(), data_property.SelectedRows[0].Cells[0].Value.ToString());
            MessageBox.Show("删除完成！");
        }
    }
}
