using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WepApiProject.DataContext;
using WepApiProject.Model;
using WepApiProject.ModelDto;
using WepApiProject.Service;

namespace WepApiProject.Controllers
{
    public class OrderController : StoreController
    {
        private readonly OrdersService ordersService;
        public OrderController(AppDbContext context, OrdersService ordersService) : base(context)
        {
            this.ordersService = ordersService;
        }

        [HttpPost]
        public async Task<ActionResult<ResponceServer>> CreateOrder(
            [FromBody] OrderHeaderCreateDto createDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new ResponceServer
                {
                    IsSuccess = false,
                    StatusCode = System.Net.HttpStatusCode.BadRequest,
                    ErrorMessages = { "Неверное состояние модели заказа" }
                });
            }

            try
            {
                var order = await ordersService.CreateOrderAsync(createDto);
                order.OrderDetailItems = null;

                return Ok(new ResponceServer
                {
                    StatusCode = System.Net.HttpStatusCode.Created,
                    Result = order
                });
            }
            catch (Exception ex)
            {
                return BadRequest(new ResponceServer
                {
                    IsSuccess = false,
                    StatusCode = System.Net.HttpStatusCode.BadRequest,
                    ErrorMessages = { "Непредвиденная ошибка", ex.Message }
                });
             }
        }
    }
}
