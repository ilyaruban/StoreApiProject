using WepApiProject.Common;
using WepApiProject.DataContext;
using WepApiProject.Model;
using WepApiProject.ModelDto;

namespace WepApiProject.Service
{
    public class OrdersService
    {
        private readonly AppDbContext context;
        public OrdersService(AppDbContext context)
        {
            this.context = context;
        }

        public async Task<OrderHeader> CreateOrderAsync(OrderHeaderCreateDto createDto)
        {
            var order = new OrderHeader
            {
                AppUserId = createDto.AppUserId,
                CustomerName = createDto.CustomerName,
                CustomerEmail = createDto.CustomerEmail,
                OrderTotalAmount = createDto.OrderTotalAmount,
                TotalCount = createDto.TotalCount,
                Status = string.IsNullOrEmpty(createDto.Status) ? SharedData.OrderStatus.Pending : createDto.Status
            };

            await context.OrderHeaders.AddAsync(order);
            await context.SaveChangesAsync();

            foreach(var item in createDto.OrderDetailsDto)
            {
                var orderDetails = new OrderDetails
                {
                    OrderHeaderId = order.OrderHeaderId,
                    ItemName = item.ItemName,
                    ProductId = item.ProductId,
                    Quantity = item.Quantity,
                    Price = item.Price
                };

                await context.OrderDetails.AddAsync(orderDetails);
            }

            await context.SaveChangesAsync();

            return order;            
        }
    }
}
