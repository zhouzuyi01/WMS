using System;
using System.Windows.Forms;
using WmsDemo;

namespace WmsView
{
    public partial class FrmAddMateriel : Form
    {
        public FrmAddMateriel()
        {
            InitializeComponent();
        }

        private void Btn_add_materiel_Click(object sender, EventArgs e)
        {
            Materiel materiel = new Materiel();
            materiel.materielcode = txtmaterielcode.Text;
            materiel.materielname = txtmaterielname.Text;
            MaterielManage.AddMateriel(materiel);
            MessageBox.Show("添加完成！");
            Close();
        }
    }
}
