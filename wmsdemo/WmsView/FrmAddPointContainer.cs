using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WmsDemo;
using Container = WmsDemo.Container;

namespace WmsView
{
    public partial class FrmAddPointContainer : Form
    {
        public FrmAddPointContainer()
        {
            InitializeComponent();
        }

        public string WareCode = "";

        public string PointCode = "";

        private void FrmAddPointContainer_Load(object sender, EventArgs e)
        {
            txtpointcode.Text = PointCode;

            List<Container> containers = ContainerManage.SelectContainerByWare(WareCode);
            cbcontainers.Items.Clear();
            containers.ForEach(container =>
            {
                cbcontainers.Items.Add(container.containercode);
            });
            if (cbcontainers.Items.Count > 0)
                cbcontainers.SelectedIndex = 0;
        }

        private void Btn_add_Click(object sender, EventArgs e)
        {
            PointManage.SetContainer(txtpointcode.Text, cbcontainers.SelectedItem.ToString());
            MessageBox.Show("添加完成！");
            Close();
        }
    }
}
