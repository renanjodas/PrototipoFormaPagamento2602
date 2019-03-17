using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forma_Pagamento
{
	public partial class FormPagamento : Form
	{
		public FormPagamento()
		{
			InitializeComponent();
		}

		private void btnCalcular_Click(object sender, EventArgs e)
		{
			double totalPagar;
			RadioButton rbnFormaPagamento = gbxPagamento.Controls.OfType<RadioButton>().SingleOrDefault(r => r.Checked);
			totalPagar = Calculo(rbnFormaPagamento, Convert.ToDouble(txtValorCompra.Text));
			txtValorPagar.Text = totalPagar.ToString();
		}

		private double Calculo(RadioButton rbnFormaPagamento, double valor)
		{
			double resultado = 0;
			switch (rbnFormaPagamento.Text)
			{
				case "à Vista":
					resultado = valor - (valor * 0.1);
					break;
				case "à Prazo":
					resultado = valor;
					break;
			}
			return resultado;
		}

		private void btnGerarTxt_Click(object sender, EventArgs e)
		{
			StreamWriter arquivo;
			string caminho = "C:\\Users\\Usuario\\Documents\\FormaPagamento.txt";
			arquivo = File.AppendText(caminho);
			System.Diagnostics.Process.Start("notepad", caminho);

			if (txtCliente.Text != string.Empty && txtValorCompra.Text != string.Empty)
			{
				arquivo.WriteLine("------------ Dados Pagamento ------------");
				arquivo.WriteLine(" ");
				arquivo.Write("Cliente: ");
				arquivo.WriteLine(txtCliente.Text);
				arquivo.WriteLine(" ");
				arquivo.Write("Valor da compra: ");
				arquivo.WriteLine(txtValorCompra.Text);
				arquivo.WriteLine(" ");
				arquivo.Write("Valor total à pagar: ");
				arquivo.WriteLine(txtValorPagar.Text);
				arquivo.WriteLine(" ");
				arquivo.WriteLine("------------------------------------------");
			}
			else
			{
				MessageBox.Show("Preencha todas as informações!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			arquivo.Close();
		}
		
	}
}
