using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Meveana_pizza
{
    public partial class frmPedidos : Form
    {
        public frmPedidos()
        {
            InitializeComponent();
        }

        private void frmPedidos_Load(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem();
            item.Text = "55";
            item.SubItems.Add("180,00");
            item.SubItems.Add("Entregue");
            item.SubItems.Add("Entregador 2");
            listView1.Items.Add(item);

            ListViewItem item2 = new ListViewItem();
            item2.Text = "56";
            item2.SubItems.Add("120,00");
            item2.SubItems.Add("Aguardando");
            item2.SubItems.Add("Entregador 1");
            listView1.Items.Add(item2);

            ListViewItem item3 = new ListViewItem();
            item3.Text = "57";
            item3.SubItems.Add("200,00");
            item3.SubItems.Add("Em trânsito");
            item3.SubItems.Add("Entregador 2");
            listView1.Items.Add(item3);
        }
    }
}
