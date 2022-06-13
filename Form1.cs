using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperMercado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        double resultado = 0;

        private void inserir_Click(object sender, EventArgs e)
        {
            lstproduto.View = View.Details;
            ListViewItem item = new ListViewItem(txtproduto.Text);

            double quantidade = double.Parse(txtquant.Text);
            double valor = double.Parse(txtvalor.Text);

            item.SubItems.Add(txtquant.Text);
            item.SubItems.Add(valor.ToString("C"));
            item.SubItems.Add($"{(quantidade * valor).ToString("C")}");

            lstproduto.Items.Add(item);


            //processamento
            resultado += quantidade * valor;

            //saída de dados
            total.Text = resultado.ToString("C");
        }

        private void novo_Click(object sender, EventArgs e)
        {
            txtproduto.Clear();
            txtquant.Clear();
            txtvalor.Clear();
        }
    }
}
