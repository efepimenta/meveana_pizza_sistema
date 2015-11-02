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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            frmClientes clientes = new frmClientes();
            pictureBox1.Visible = false;
            clientes.MdiParent = this;
            clientes.Show();
            btnClientes.Enabled = false;
        }

        private void btnEntregadores_Click(object sender, EventArgs e)
        {
            frmEntregadores entregadores = new frmEntregadores();
            pictureBox1.Visible = false;
            entregadores.MdiParent = this;
            entregadores.Show();
            btnEntregadores.Enabled = false;
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            frmProdutos produtos = new frmProdutos();
            pictureBox1.Visible = false;
            produtos.MdiParent = this;
            produtos.Show();
            btnProdutos.Enabled = false;
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            frmPedidos pedidos = new frmPedidos();
            pictureBox1.Visible = false;
            pedidos.MdiParent = this;
            pedidos.Show();
            btnPedidos.Enabled = false;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmRelatorio relatorio = new frmRelatorio();
            pictureBox1.Visible = false;
            relatorio.MdiParent = this;
            relatorio.Show();
            btnRelatorio.Enabled = false;
        }
    }
}
