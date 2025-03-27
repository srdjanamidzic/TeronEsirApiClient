using System;

namespace TeronEsirClient.Models.CashRegister.Read
{
    public sealed class TeronEsirCashRegisterSummary
    {
        public DateTime StartOfPeriod { get; private set; }
        public decimal Total { get; private set; }
        public decimal TotalCash { get; private set; }
        public TeronEsirCashRegisterSummaryTax[] TotalByTax { get; private set; } = Array.Empty<TeronEsirCashRegisterSummaryTax>();
        public TeronEsirCashRegisterSummaryCashier[] TotalByCashier { get; private set; } = Array.Empty<TeronEsirCashRegisterSummaryCashier>();
        public TeronEsirCashRegisterSummaryPaymentType[] TotalByPaymentType { get; private set; } = Array.Empty<TeronEsirCashRegisterSummaryPaymentType>();
        public TeronEsirCashRegisterSummaryArticle[] TotalByArticle { get; private set; } = Array.Empty<TeronEsirCashRegisterSummaryArticle>();
        public TeronEsirCashRegisterSummaryArticleAdvance[] TotalByArticleAdvance { get; private set; } = Array.Empty<TeronEsirCashRegisterSummaryArticleAdvance>();
    }
}
