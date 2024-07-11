using NORKRESEARCH.Models.Financial;

namespace NORKRESEARCH.Financial
{
    public class MockFinancialService : IFinancialService
    {
        public Task<List<BoxOfficeRevenueType>> GetBoxOfficeRevenue()
        {
            return Task.FromResult<List<BoxOfficeRevenueType>>(new());
        }

        public Task<List<StocksType>> GetStocks()
        {
            return Task.FromResult<List<StocksType>>(new());
        }
    }
}
