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
    public partial class frmProdutos : Form
    {
        public frmProdutos()
        {
            InitializeComponent();
        }

        private void frmProdutos_Load(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem();
            item.Text = "Muita Sarela";
            item.SubItems.Add("Muita muzzarella, tomate e azeitona preta.");
            item.SubItems.Add("40,00");
            item.SubItems.Add("Grande");
            listView1.Items.Add(item);

            ListViewItem item2 = new ListViewItem();
            item2.Text = "Gourmet Calabresa";
            item2.SubItems.Add("mozzarella, molho de tomate, linguiça, provolone, cebola, azeitona e orégano. ");
            item2.SubItems.Add("80,00");
            item2.SubItems.Add("Grande");
            listView1.Items.Add(item2);

            ListViewItem item3 = new ListViewItem();
            item3.Text = "Tomates verdes fritos";
            item3.SubItems.Add("Muzzarella, cebola, azeitonas pretas e tomates verdes, fritos.");
            item3.SubItems.Add("40,00");
            item3.SubItems.Add("Grande");
            listView1.Items.Add(item3);
        }
    }
}
