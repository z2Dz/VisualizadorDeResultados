using System.Text.Json.Serialization;

namespace VisualizadorDeResultadosBolão.Models
{
    public class RodadaJogoModel
    {
        [JsonPropertyName("rodadajogoid")]
        public int RodadaJogoId { get; set; }

        [JsonPropertyName("rodadaid")]
        public int RodadaId { get; set; }

        [JsonPropertyName("jogoid")]
        public int JogoId { get; set; }

        [JsonPropertyName("mandanteid")]
        public int MandanteId { get; set; }

        [JsonPropertyName("mandantenome")]
        public string MandanteNome { get; set; } = "";

        [JsonPropertyName("mandantesigla")]
        public string MandanteSigla { get; set; } = "";

        [JsonPropertyName("mandanteescudo")]
        public string MandanteEscudo { get; set; } = "";

        [JsonPropertyName("visitanteid")]
        public int VisitanteId { get; set; }

        [JsonPropertyName("visitantenome")]
        public string VisitanteNome { get; set; } = "";

        [JsonPropertyName("visitantesigla")]
        public string VisitanteSigla { get; set; } = "";

        [JsonPropertyName("visitanteescudo")]
        public string VisitanteEscudo { get; set; } = "";

        [JsonPropertyName("status")]
        public string Status { get; set; } = "";

        [JsonPropertyName("golsmandante")]
        public int? GolsMandante { get; set; }

        [JsonPropertyName("golsvisitante")]
        public int? GolsVisitante { get; set; }

        [JsonPropertyName("infojogo")]
        public string InfoJogo { get; set; } = "";
    }
}
