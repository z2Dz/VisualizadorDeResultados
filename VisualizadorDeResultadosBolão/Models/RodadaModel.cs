using System.Text.Json.Serialization;

namespace VisualizadorDeResultadosBolão.Models
{
    public class RodadaModel
    {

        [JsonPropertyName("rodadaid")]
        public int rodadaID { get; set; }

        [JsonPropertyName("rodadanome")]
        public string rodadaNome { get; set; } = "";

        [JsonPropertyName("rodadadtini")]
        public DateTime rodadaDtIni { get; set; }

        [JsonPropertyName("rodadastatus")]
        public string rodadaStatus { get; set; } = "";
    }
}
