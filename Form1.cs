using PocBancoDoBrasil;
using System.Text;

namespace Poc_Banco_do_brasil
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private async void btnObterToken_Click(object sender, EventArgs e)
        {

            string token = await ObterToken.Executar();
            txtToken.Text = token;
        }

        private async void btnEmitirBoleto_Click(object sender, EventArgs e)
        {
            txtJsonResponse.Text = await BoletoAsync.EmitirBoletoAsync();
        
        
        
        
        }

        private void lblInscricao_Click(object sender, EventArgs e)
        {

        }

        private void lblConvenio_Click(object sender, EventArgs e)
        {

        }

        private void lblCarteira_Click(object sender, EventArgs e)
        {

        }

        private void lblVariacaoCarteira_Click(object sender, EventArgs e)
        {

        }

        private void lblCodigoModalidade_Click(object sender, EventArgs e)
        {

        }

        private void lblDataEmissao_Click(object sender, EventArgs e)
        {

        }

        private void lblDataVencimento_Click(object sender, EventArgs e)
        {

        }

        private void lblValorOriginal_Click(object sender, EventArgs e)
        {

        }

        private void lblCodigoAceite_Click(object sender, EventArgs e)
        {

        }

        private void lblTipoTitulo_Click(object sender, EventArgs e)
        {

        }

        private void lblDescricaoTipoTitulo_Click(object sender, EventArgs e)
        {

        }

        private void lblIndicadorRecebimentoParcial_Click(object sender, EventArgs e)
        {

        }

        private void lblNumeroBeneficiario_Click(object sender, EventArgs e)
        {

        }

        private void lblNumeroBoleto_Click(object sender, EventArgs e)
        {

        }

        private void lblPagador_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCobranca_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtVariacaoCarteira_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCodigoModalidade_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDataEmissao_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDataVencimento_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtValorOriginal_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCodigoAceite_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtToken_TextChanged(object sender, EventArgs e)
        {


        }

        private void txtJsonResponse_TextChanged(object sender, EventArgs e)
        {

            txtJsonResponse.BackColor = Color.Black;
            txtJsonResponse.ForeColor = Color.Lime;
        }
    }
}
