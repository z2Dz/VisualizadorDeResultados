using System.Net.Http.Headers;
using System.Net.Http.Json;
using VisualizadorDeResultadosBolão.Models;

namespace VisualizadorDeResultadosBolão.Services
{
    public class SupaBaseService
    {

        private readonly HttpClient _http;


        public SupaBaseService(HttpClient http, IConfiguration config)
        {
            _http = http;

            var supabaseUrl = config["Supabase:Url"];
            var supabaseKey = config["Supabase:AnonKey"];

            if (string.IsNullOrWhiteSpace(supabaseUrl))
                throw new Exception("Supabase URL não configurada.");

            if(string.IsNullOrWhiteSpace(supabaseKey))
                throw new Exception("Supabase Anon Key não configurada.");

            _http.BaseAddress = new Uri(supabaseUrl);

            if(!_http.DefaultRequestHeaders.Contains("apikey"))
                _http.DefaultRequestHeaders.Add("apikey", supabaseKey);

            if(!_http.DefaultRequestHeaders.Contains("Authorization"))
                _http.DefaultRequestHeaders.Add("Authorization", $"Bearer {supabaseKey}");
        }
        
        public async Task<RodadaModel?> GetRodadaAbertaAsync()
        {

            var result = await _http.GetFromJsonAsync<List<RodadaModel>>(
                "/rest/v1/tbrodada?select=rodadaid,rodadanome,rodadastatus&rodadastatus=eq.Aberta&limit=1" 
            );

            return result?.FirstOrDefault();
        }

        public async Task<List<RodadaJogoModel>> GetJogosDaRodadaAsync(int rodadaId)
        {

            return await _http.GetFromJsonAsync<List<RodadaJogoModel>>(
                $"/rest/v1/vw_rodada_jogos_visualizador?select=*&rodadaid=eq.{rodadaId}&order=rodadajogoid.asc") ?? new();
        }

        public async Task<List<PalpiteModel>> GetPalpitesDaRodadaAsync(int rodadaId)
        {
            return await _http.GetFromJsonAsync<List<PalpiteModel>>(
                $"/rest/v1/vw_palpite_rodada_visualizador?select=*&rodadaid=eq.{rodadaId}&order=jogadoresnome.asc,rodadajogoid.asc") ?? new();
        }
    }
}
