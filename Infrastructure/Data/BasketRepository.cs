using Core.Entities;
using Core.Interfaces;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace Infrastructure.Data
{
    public class BasketRepository : IBasketRepository
    {
        private readonly IDatabase _dataBase;

        public BasketRepository(IConnectionMultiplexer redis)
        {
            _dataBase = redis.GetDatabase();

        }

        public async Task<bool> DeleteBasketAsync(string basketId)
        {
            return await _dataBase.KeyDeleteAsync(basketId);
        }

        public async Task<CustomerBasket> GetBasketAsync(string basketId)
        {
            try
            {
                var data = await _dataBase.StringGetAsync(basketId);
                return data.IsNullOrEmpty ? null : JsonSerializer.Deserialize<CustomerBasket>(data);
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<CustomerBasket> UpDateBasketAsync(CustomerBasket basket)
        {
            try
            {
                var created = await _dataBase.StringSetAsync(basket.Id, JsonSerializer.Serialize(basket), TimeSpan.FromDays(30));

                if (!created) return null;

                return await GetBasketAsync(basket.Id);
            }
            catch(Exception ex)
            {
                return null;
            }
            
        }
    }
}
