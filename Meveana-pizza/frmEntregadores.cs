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
    public partial class frmEntregadores : Form
    {
        public frmEntregadores()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmTerceirizados terceiros = new frmTerceirizados();
            terceiros.Show();
        }

        private void frmEntregadores_Load(object sender, EventArgs e)
        {
            for (int i = 1; i < 10; i++)
            {
                ListViewItem item = new ListViewItem();
                item.Text = String.Format("Entregador {0}" , i);
                item.SubItems.Add(String.Format("123.456.789-1{0}", i));
                item.SubItems.Add(String.Format("1.258.65{0}", i));
                item.SubItems.Add(String.Format("5555-567{0}", i));
                item.SubItems.Add(String.Format("Empresa Terceirizada {0}", i));
                listView1.Items.Add(item);
            }
        }
    }
}
