using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Meveana_pizza
{
    public partial class frmRelatorio : Form
    {
        public frmRelatorio()
        {
            InitializeComponent();
        }

        private void frmRelatorio_Load(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem();
            item.Text = "38";
            item.SubItems.Add("100,00");
            listView1.Items.Add(item);

            ListViewItem item2 = new ListViewItem();
            item2.Text = "41";
            item2.SubItems.Add("50,00");
            listView1.Items.Add(item2);
        }
    }
}
