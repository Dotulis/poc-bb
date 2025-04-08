using Poc_Banco_do_brasil;
using System.Text;
using System.Text.Json;

namespace PocBancoDoBrasil
{
    public class BoletoAsync
    {
        public async static Task<string> EmitirBoletoAsync()
        {
            try
            {
                var boleto = new BoletoRequest
                {
                    numeroConvenio = 3128557,
                    numeroCarteira = 17,
                    numeroVariacaoCarteira = 35,
                    codigoModalidade = 1,
                    dataEmissao = "25.03.2025",
                    dataVencimento = "25.04.2025",
                    valorOriginal = 150.00m,
                    valorAbatimento = 0.00m,
                    quantidadeDiasProtesto = 0,
                    indicadorAceiteTituloVencido = "S",
                    numeroDiasLimiteRecebimento = 10,
                    codigoAceite = "A",
                    codigoTipoTitulo = 2,
                    descricaoTipoTitulo = "DM",
                    indicadorPermissaoRecebimentoParcial = "N",
                    numeroTituloBeneficiario = "654321",
                    numeroTituloCliente = "00031285570000078021",
                    indicadorPix = "S",
                    pagador = new Pagador
                    {
                        tipoInscricao = 1,
                        numeroInscricao = "97965940132",
                        nome = "João da Silva",
                        endereco = "Rua Exemplo, 123",
                        cep = "01001000",
                        cidade = "São Paulo",
                        bairro = "Centro",
                        uf = "SP",
                        telefone = "11987654321"
                    }
                };

                string json = JsonSerializer.Serialize(boleto);

                var token = await ObterToken.Executar();
             

                using var client = new HttpClient();
                var request = new HttpRequestMessage(HttpMethod.Post, "https://api.hm.bb.com.br/cobrancas/v2/boletos?gw-dev-app-key=8a95779423b74953e90ceffefe69923e");

                request.Headers.Add("Authorization", $"Bearer {token}");
                request.Content = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await client.SendAsync(request);
                //response.EnsureSuccessStatusCode();
                if (!response.IsSuccessStatusCode)
                {
                    var erro = await response.Content.ReadAsStringAsync();
                    Console.WriteLine($"Erro: {response.StatusCode} - {erro}");
                    return $"Erro: {response.StatusCode} - {erro}";
                }

                var responseString = await response.Content.ReadAsStringAsync();
                return responseString;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public class BoletoRequest
        {
            public int numeroConvenio { get; set; }
            public int numeroCarteira { get; set; }
            public int numeroVariacaoCarteira { get; set; }
            public int codigoModalidade { get; set; }
            public string dataEmissao { get; set; }
            public string dataVencimento { get; set; }
            public decimal valorOriginal { get; set; }
            public decimal valorAbatimento { get; set; }
            public int quantidadeDiasProtesto { get; set; }
            public int quantidadeDiasNegativacao { get; set; }
            public int orgaoNegativador { get; set; }
            public string indicadorAceiteTituloVencido { get; set; }
            public int numeroDiasLimiteRecebimento { get; set; }
            public string codigoAceite { get; set; }
            public int codigoTipoTitulo { get; set; }
            public string descricaoTipoTitulo { get; set; }
            public string indicadorPermissaoRecebimentoParcial { get; set; }
            public string numeroTituloBeneficiario { get; set; }
            public string campoUtilizacaoBeneficiario { get; set; }
            public string numeroTituloCliente { get; set; }
            public string mensagemBloquetoOcorrencia { get; set; }
            public Desconto desconto { get; set; }
            public Segundodesconto segundoDesconto { get; set; }
            public Terceirodesconto terceiroDesconto { get; set; }
            public Jurosmora jurosMora { get; set; }
            public Multa multa { get; set; }
            public Pagador pagador { get; set; }
            public Beneficiariofinal beneficiarioFinal { get; set; }
            public string indicadorPix { get; set; }
        }

        public class Desconto
        {
            public int tipo { get; set; }
            public string dataExpiracao { get; set; }
            public int porcentagem { get; set; }
            public int valor { get; set; }
        }

        public class Segundodesconto
        {
            public string dataExpiracao { get; set; }
            public int porcentagem { get; set; }
            public int valor { get; set; }
        }

        public class Terceirodesconto
        {
            public string dataExpiracao { get; set; }
            public int porcentagem { get; set; }
            public int valor { get; set; }
        }

        public class Jurosmora
        {
            public int tipo { get; set; }
            public int porcentagem { get; set; }
            public int valor { get; set; }
        }

        public class Multa
        {
            public int tipo { get; set; }
            public string data { get; set; }
            public int porcentagem { get; set; }
            public int valor { get; set; }
        }

        public class Pagador
        {
            public int tipoInscricao { get; set; }
            public string numeroInscricao { get; set; }
            public string nome { get; set; }
            public string endereco { get; set; }
            public string cep { get; set; }
            public string cidade { get; set; }
            public string bairro { get; set; }
            public string uf { get; set; }
            public string telefone { get; set; }
            public string email { get; set; }
        }

        public class Beneficiariofinal
        {
            public int tipoInscricao { get; set; }
            public int numeroInscricao { get; set; }
            public string nome { get; set; }
        }
    }
}