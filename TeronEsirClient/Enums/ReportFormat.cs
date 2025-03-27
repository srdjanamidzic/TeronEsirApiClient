using TeronEsirClient.Enums.Utils;

namespace TeronEsirClient.Enums
{
    public enum ReportFormat
    {
        [StringValue("pdf")]
        Pdf,

        [StringValue("xlsx")]
        Xlsx,

        [StringValue("csv")]
        Csv,

        [StringValue("html")]
        Html,

        [StringValue("png")]
        Png,
    }
}
