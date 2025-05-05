using System.ComponentModel.DataAnnotations.Schema;

namespace WepApiProject.Model
{
    //модель карточки товара для создания таблицы в БД
    public class CartItem
    {
        public int Id {  get; set; }
        public int ProductId {  get; set; }
        public int Quantity {  get; set; }
        public int ShoppingCardId {  get; set; }
        [ForeignKey(nameof(ProductId))]
        public Product Product { get; set; }
    }
}
