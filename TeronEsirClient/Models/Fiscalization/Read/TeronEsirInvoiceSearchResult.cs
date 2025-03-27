using System;
using System.Globalization;
using TeronEsirClient.Enums;
using TeronEsirClient.Enums.Utils;

namespace TeronEsirClient.Models.Fiscalization.Read
{
    public sealed class TeronEsirInvoiceSearchResult
    {
        private TeronEsirInvoiceSearchResult()
        {

        }

        public string InvoiceNumber { get; private set; }
        public InvoiceType InvoiceType { get; private set; }
        public TransactionType TransactionType { get; private set; }
        public DateTime SdcDateTime { get; private set; }
        public decimal TotalAmount { get; private set; }

        public static TeronEsirInvoiceSearchResult FromCsvString(string csv)
        {
            var parts = csv.Split(',');
            return new TeronEsirInvoiceSearchResult
            {
                InvoiceNumber = parts[0],
                InvoiceType = EnumConverter.ParseStringValue<InvoiceType>(parts[1]),
                TransactionType = EnumConverter.ParseStringValue<TransactionType>(parts[2]),
                SdcDateTime = DateTime.Parse(parts[3]),
                TotalAmount = decimal.Parse(parts[4], CultureInfo.InvariantCulture),
            };
        }
    }
}
