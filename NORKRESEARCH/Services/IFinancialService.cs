using NORKRESEARCH.Models.Financial;

namespace NORKRESEARCH.Financial
{
    public interface IFinancialService
    {
        Task<List<BoxOfficeRevenueType>> GetBoxOfficeRevenue();
        Task<List<StocksType>> GetStocks();
    }
}
