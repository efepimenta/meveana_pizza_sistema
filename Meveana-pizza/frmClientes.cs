﻿using System;
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
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "123")
            {
                grpClientes.Dock = DockStyle.Fill;
                grpClientes.Visible = true;
                grpNovo.Visible = false;
            } else
            {
                grpNovo.Dock = DockStyle.Fill;
                grpNovo.Visible = true;
                grpClientes.Visible = false;
            }
        }
    }
}
