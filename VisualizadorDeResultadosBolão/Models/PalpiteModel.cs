using System.Text.Json.Serialization;

namespace VisualizadorDeResultadosBolão.Models
{
    public class PalpiteModel
    {

        [JsonPropertyName("palpiteid")]
        public int PalpiteId { get; set; }

        [JsonPropertyName("rodadajogoid")]
        public int RodadaJogoId { get; set; }

        [JsonPropertyName("rodadaid")]
        public int RodadaId { get; set; }

        [JsonPropertyName("jogoid")]
        public int JogoId { get; set; }

        [JsonPropertyName("jogadorpalpiteid")]
        public int JogadorPalpiteId { get; set; }

        [JsonPropertyName("jogadoresid")]
        public int JogadoresId { get; set; }

        [JsonPropertyName("jogadoresnome")]
        public string JogadoresNome { get; set; } = "";

        [JsonPropertyName("palpitemandante")]
        public int? PalpiteMandante { get; set; }

        [JsonPropertyName("palpitevisitante")]
        public int? PalpiteVisitante { get; set; }

        [JsonPropertyName("palpitetotalpontos")]
        public int? PalpiteTotalPontos { get; set; }

        [JsonPropertyName("mandantesigla")]
        public string MandanteSigla { get; set; } = "";

        [JsonPropertyName("visitantesigla")]
        public string VisitanteSigla { get; set; } = "";

        public string JogoLabel => $"{MandanteSigla} x {VisitanteSigla}";

        public string PalpiteLabel =>
            $"{PalpiteMandante?.ToString() ?? "-"}x{PalpiteVisitante?.ToString() ?? "-"}";
    }
}
