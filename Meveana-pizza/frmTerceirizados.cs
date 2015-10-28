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
    public partial class frmTerceirizados : Form
    {
        public frmTerceirizados()
        {
            InitializeComponent();
        }

        private void Terceirizados_Load(object sender, EventArgs e)
        {
            for (int i = 1; i < 10; i++)
            {
                ListViewItem item = new ListViewItem();
                item.Text = "Empresa terceirizada " + i + 1;
                item.SubItems.Add(String.Format("Endereço da empresa {0}", i));
                item.SubItems.Add(String.Format("00.000.000/000{0}", i));
                item.SubItems.Add(String.Format("1234-567{0}",i));
                item.SubItems.Add(String.Format("empresa{0}@provedor.com", i));
                listView1.Items.Add(item);
            }
        }
    }
}
