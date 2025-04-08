using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Poc_Banco_do_brasil
{
    public class ObterToken
    {
        public async static Task<string> Executar()
        {
            using var client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Post, "https://oauth.hm.bb.com.br/oauth/token");

            request.Headers.Add("Authorization", "Basic ZXlKcFpDSTZJams1WmpaaVptUXROMlV6TlMwMFkySmxMU0lzSW1OdlpHbG5iMUIxWW14cFkyRmtiM0lpT2pBc0ltTnZaR2xuYjFOdlpuUjNZWEpsSWpveE16QXdPREVzSW5ObGNYVmxibU5wWVd4SmJuTjBZV3hoWTJGdklqb3hmUTpleUpwWkNJNkltWXlNak5qTURrdE5tTXlOUzAwWlRRMUxXRWlMQ0pqYjJScFoyOVFkV0pzYVdOaFpHOXlJam93TENKamIyUnBaMjlUYjJaMGQyRnlaU0k2TVRNd01EZ3hMQ0p6WlhGMVpXNWphV0ZzU1c1emRHRnNZV05oYnlJNk1Td2ljMlZ4ZFdWdVkybGhiRU55WldSbGJtTnBZV3dpT2pFc0ltRnRZbWxsYm5SbElqb2lhRzl0YjJ4dloyRmpZVzhpTENKcFlYUWlPakUzTkRJNU9EVXpPVEEwTURGOQ==");


            var content = new FormUrlEncodedContent(new[]
            {
        new KeyValuePair<string, string>("grant_type", "client_credentials"),
        new KeyValuePair<string, string>("scope", "cobrancas.boletos-info cobrancas.boletos-requisicao")
    });

            request.Content = content;
            var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();
            var json = await response.Content.ReadAsStringAsync();
            var token = JsonSerializer.Deserialize<TokenResponse>(json);
            return token?.AccessToken;
        }

        public class TokenResponse
        {
            [JsonPropertyName("access_token")]
            public string AccessToken { get; set; }
        }
    }
}
