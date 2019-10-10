using System;
using System.Windows.Forms;
using WmsDemo;

namespace WmsView
{
    public partial class FrmAddProperty : Form
    {
        public FrmAddProperty()
        {
            InitializeComponent();
        }

        public string MaterielCode = "";

        private void Button1_Click(object sender, EventArgs e)
        {
            Materiel_Property property = new Materiel_Property();
            property.materielcode = txtmaterielcode.Text;
            property.propertyname = txtpropertyname.Text;
            property.propertyvalue = txtpropertyvalue.Text;
            MaterielManage.AddProperty(property);

            MessageBox.Show("添加完成！");
            Close();
        }

        private void FrmAddProperty_Load(object sender, EventArgs e)
        {
            txtmaterielcode.Text = MaterielCode;
        }
    }
}
