using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WepApiProject.DataContext;
using WepApiProject.Model;
using WepApiProject.ModelDto;

namespace WepApiProject.Controllers
{
    public class ProductController : StoreController
    {
        public ProductController(AppDbContext context):base(context)
        {
            
        }

        [HttpGet]
        public async Task<IActionResult> GetProducts()
        {
            ResponceServer responce = new ResponceServer()
            {
                StatusCode = System.Net.HttpStatusCode.OK,
                Result = await Context.Products.ToListAsync()
            };

            return Ok(responce);
        }

        [HttpGet("{id}", Name =nameof(GetProductById))]
        public async Task<IActionResult> GetProductById(int id)
        {
            if(id <= 0)
            {
                return BadRequest(new ResponceServer()
                {
                    StatusCode = System.Net.HttpStatusCode.BadRequest,
                    IsSuccess=false,
                    ErrorMessages = {"Неверный id"}
                });
            }

            var product = await Context.Products.Where(x => x.Id == id).FirstOrDefaultAsync();

            if(product == null)
            {
                return NotFound(new ResponceServer()
                {
                    StatusCode = System.Net.HttpStatusCode.NotFound,
                    IsSuccess = false,
                    ErrorMessages = { "Продукт по указанному id не найден" }
                });
            }
            else
            {
                return Ok(new ResponceServer()
                {
                    StatusCode = System.Net.HttpStatusCode.OK,
                    Result = await Context.Products.Where(x => x.Id == id).ToListAsync()
                });
            }
        }

        [HttpPost]
        public async Task<ActionResult<ResponceServer>> CreateProduct([FromBody] ProductCreateDto productCreateDto)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if(productCreateDto.Image == null || productCreateDto.Image.Length == 0)
                    {
                        return BadRequest(new ResponceServer()
                        {
                            StatusCode = System.Net.HttpStatusCode.BadRequest,
                            IsSuccess = false,
                            ErrorMessages = { "Image не может быть пустым" }
                        });
                    }
                    else
                    {
                        Product item = new()
                        {
                            Name = productCreateDto.Name,
                            Description = productCreateDto.Description,
                            SpecialTag = productCreateDto.SpecialTag,
                            Category = productCreateDto.Category,
                            Price = productCreateDto.Price,
                            Image = ""
                        };

                        await Context.Products.AddAsync(item);
                        await Context.SaveChangesAsync();

                        ResponceServer responce = new()
                        {
                            StatusCode = System.Net.HttpStatusCode.Created,
                            Result = item
                        };
                        return CreatedAtRoute(nameof(GetProductById), new { id = item.Id }, responce);
                    }
                }
                else
                {
                    return BadRequest(new ResponceServer()
                    {
                        IsSuccess = false,
                        StatusCode = System.Net.HttpStatusCode.BadRequest,
                        ErrorMessages = {"Модель данных не подходит"}
                    });
                }
            }
            catch (Exception ex)
            {
                return BadRequest(new ResponceServer
                {
                    IsSuccess = false,
                    StatusCode = System.Net.HttpStatusCode.BadRequest,
                    ErrorMessages = { ex.Message }
                });
            }
        }

        [HttpPut]
        public async Task<ActionResult<ResponceServer>> UpdateProduct(int id, [FromBody] ProductUpdateDto productUpdateDto)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if(productUpdateDto == null || productUpdateDto.Id != id)
                    {
                        return BadRequest(new ResponceServer
                        {
                            IsSuccess = false,
                            StatusCode = System.Net.HttpStatusCode.BadRequest,
                            ErrorMessages = { "Несоответствие модели данных" }
                        });
                    }
                    else
                    {
                        Product productFromDb = await Context.Products.FindAsync(id);

                        if(productFromDb == null)
                        {
                            return NotFound(new ResponceServer
                            {
                                IsSuccess = false,
                                StatusCode = System.Net.HttpStatusCode.NotFound,
                                ErrorMessages = { "Продукт с таким id не найден" }
                            });
                        }

                        productFromDb.Name = productUpdateDto.Name;
                        productFromDb.Description = productUpdateDto.Description;

                        if (!String.IsNullOrEmpty(productUpdateDto.SpecialTag))
                        {
                            productFromDb.SpecialTag = productUpdateDto.SpecialTag;
                        }

                        productFromDb.Category = productUpdateDto.Category;
                        productFromDb.Price = productUpdateDto.Price;

                        if(productUpdateDto.Image != null && productUpdateDto.Image.Length > 0)
                        {
                            productFromDb.Image = $"https://placehold.co/300";
                        }

                        Context.Products.Update(productFromDb);
                        await Context.SaveChangesAsync();

                        return Ok(new ResponceServer
                        {
                            IsSuccess = false,
                            StatusCode = System.Net.HttpStatusCode.OK,
                            Result = productFromDb
                        });
                    }
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        public async Task <ActionResult<ResponceServer>> DeleteProduct(int id)
        {
            if(id < 0)
            {
                return BadRequest(new ResponceServer
                {
                    IsSuccess = false,
                    StatusCode = System.Net.HttpStatusCode.BadRequest,
                    ErrorMessages = { "Неверные данные" }
                });
            }

            Product product = Context.Products.Where(p => p.Id == id).FirstOrDefault();

            if(product == null)
            {
                return NotFound(new ResponceServer
                {
                    IsSuccess = false,
                    StatusCode = System.Net.HttpStatusCode.NotFound,
                    ErrorMessages = { "Продукт по указанному id не найден" }
                });
            }
            else
            {
                Context.Products.Remove(product);
                await Context.SaveChangesAsync();

                return NoContent();
            }
        }
    }
}
