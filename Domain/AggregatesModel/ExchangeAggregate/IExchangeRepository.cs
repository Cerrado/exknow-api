using System.Threading.Tasks;
using ExchangeApi.Services.Exchange.Domain.Seedwork;

namespace ExchangeApi.Services.Exchange.Domain.AggregatesModel.ExchangeAggregate
{

    public interface IExchangeRepository : IRepository<Exchange>
    {
        Exchange Add(Exchange order);
        
        void Update(Exchange order);

        Task<Exchange> GetAsync(int exchangeId);
    }
}