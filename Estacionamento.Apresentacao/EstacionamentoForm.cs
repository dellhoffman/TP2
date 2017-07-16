using Estacionamento.Apresentacao.ServicoEstacionamento;
using System;
using System.Windows.Forms;

namespace Estacionamento.Apresentacao
{
    public partial class EstacionamentoForm : Form
    {
        public EstacionamentoForm()
        {
            InitializeComponent();
            AtualizarVagasRestantes();
        }

        private void AtualizarVagasRestantes()
        {
            try
            {
                int vagasRest = 0;

                using (EstacionamentoClient proxiEstacionamentoService = new EstacionamentoClient())
                {
                    vagasRest = proxiEstacionamentoService.VagasRestantes();
                }

                lblNumVagas.Text = vagasRest.ToString();

                lblNumVagas.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string placa = textBox1.Text;

            try
            {
                using (EstacionamentoClient proxiEstacionamentoService = new EstacionamentoClient())
                {
                    proxiEstacionamentoService.Checkin(placa);
                }

                MessageBox.Show(String.Format("Placa '{0}' adicionada.", placa));
                textBox1.Text = string.Empty;
                AtualizarVagasRestantes();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string placa = textBox1.Text;

            try
            {
                var valor = 0d;

                using (EstacionamentoClient proxiEstacionamentoService = new EstacionamentoClient())
                {
                    valor = proxiEstacionamentoService.Checkout(placa);
                }

                AtualizarVagasRestantes();

                MessageBox.Show(String.Format("Placa '{0}' valor de R${1}.", placa, valor));
                textBox1.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}