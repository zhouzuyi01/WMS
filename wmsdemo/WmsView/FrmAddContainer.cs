using System;
using System.Windows.Forms;
using WmsDemo;
using Container = WmsDemo.Container;

namespace WmsView
{
    public partial class FrmAddContainer : Form
    {
        public FrmAddContainer()
        {
            InitializeComponent();
        }

        public string WareCode = "";

        private void FrmContainer_Load(object sender, EventArgs e)
        {
            txtwarecode.Text = WareCode;
            txtcontainercode.Text = txtwarecode.Text + "_001";
            txtcapacity.Text = "1";
            Btn_select_materiel_Click(null, null);
        }

        private void Btn_add_Click(object sender, EventArgs e)
        {
            Container container = new Container();
            container.containercode = txtcontainercode.Text;
            container.materielcode = cbmateriels.SelectedItem.ToString();
            container.capacity = Convert.ToDouble(txtcapacity.Text);
            ContainerManage.AddContainer(container);
            MessageBox.Show("添加完成！");
            Close();
        }

        private void Btn_select_materiel_Click(object sender, EventArgs e)
        {
            cbmateriels.Items.Clear();
            var materiels = MaterielManage.SelectMateriel();
            materiels.ForEach(materiel =>
            {
                cbmateriels.Items.Add(materiel.materielcode);
            });
            if (cbmateriels.Items.Count > 0)
                cbmateriels.SelectedIndex = 0;
        }
    }
}
