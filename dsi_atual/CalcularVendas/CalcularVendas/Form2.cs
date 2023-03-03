using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcularVendas
{
    public partial class Form2 : Form
    {
       
        public Form2()
        {
            InitializeComponent();
            cboPag.SelectedIndex = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtQtde_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboPag_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string message = "Tem certeza que quer sair ?";
            string caption = "Sair ?";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            MessageBoxIcon icon = MessageBoxIcon.Error;
            DialogResult result;

        // Displays the MessageBox.
        result = MessageBox.Show(message, caption, buttons,icon);
        if (result == System.Windows.Forms.DialogResult.Yes)
        {
            // Closes the parent form.
            this.Close();
        }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtQtde.Text = "";
            txtPreco.Text = "";
            lblTotal.Text = "";
            cboPag.SelectedIndex = 0;
            picBoxPagamento.Image = null;
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double qtde, preco, total;
            qtde = double.Parse(txtQtde.Text);
            preco = double.Parse(txtPreco.Text);
            total = qtde * preco;

            if (cboPag.SelectedIndex == 1 || cboPag.SelectedIndex == 2)
            {
                lblTotal.Text = "Total" + total;
                lblTotal.BackColor = Color.FromArgb(0, 0, 255);
                picBoxPagamento.Image = Properties.Resources.cartao;

            }
            else if (cboPag.SelectedIndex == 3)
            {
                double juros = total * 0.1;
                lblTotal.Text = "Total" + (total - juros);
                lblTotal.BackColor = Color.FromArgb(0, 0, 255);
                picBoxPagamento.Image = Properties.Resources.dinheiro;
            }
            else if (cboPag.SelectedIndex == 4)
            {
                total = qtde * preco;
                double juros = total * 0.1;
                lblTotal.Text = "Total :" + (total + juros);
                lblTotal.BackColor = Color.FromArgb(0, 0, 255);
                picBoxPagamento.Image = Properties.Resources.crediario;
            }
            else
            {
                MessageBox.Show("Selecione uma opção !");
            }
        }
    }
   }

