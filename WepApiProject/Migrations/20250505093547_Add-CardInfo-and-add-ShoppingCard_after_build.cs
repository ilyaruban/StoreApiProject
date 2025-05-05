using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace WepApiProject.Migrations
{
    /// <inheritdoc />
    public partial class AddCardInfoandaddShoppingCard_after_build : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ShoppingCarts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCarts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CartItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ProductId = table.Column<int>(type: "integer", nullable: false),
                    Quantity = table.Column<int>(type: "integer", nullable: false),
                    ShoppingCardId = table.Column<int>(type: "integer", nullable: false),
                    ShoppingCartId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CartItems_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CartItems_ShoppingCarts_ShoppingCartId",
                        column: x => x.ShoppingCartId,
                        principalTable: "ShoppingCarts",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Category", "Description", "Name", "Price" },
                values: new object[] { "Категория 1", "Сфера напрямую соответствующей важные сознания повышение всего требует сомнений и.", "Фантастический Деревянный Шарф", 775.08000000000004 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Для по сущности представляет внедрения общественной богатый выбранный прежде.", "Невероятный Гранитный Шарф", 758.49000000000001, "Популярный" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Category", "Description", "Name", "Price" },
                values: new object[] { "Категория 3", "Структура значительной отметить.", "Великолепный Хлопковый Свитер", 104.59999999999999 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Category", "Description", "Name", "Price" },
                values: new object[] { "Категория 3", "Создание по настолько деятельности отметить.", "Практичный Резиновый Носки", 266.35000000000002 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Этих плановых работы для.", "Практичный Стальной Ботинок", 57.450000000000003, "Рекомендуемый" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 2", "Потребностям отношении кругу настолько с специалистов широким.", "Лоснящийся Гранитный Носки", 891.13999999999999, "Популярный" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 2", "Новых целесообразности модель.", "Великолепный Деревянный Свитер", 234.36000000000001, "Рекомендуемый" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Category", "Description", "Name", "Price" },
                values: new object[] { "Категория 1", "Позволяет эксперимент создаёт следует принимаемых же демократической.", "Великолепный Неодимовый Носки", 230.97999999999999 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Всего систему важные способствует различных структуры.", "Лоснящийся Стальной Ремень", 756.38999999999999 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 1", "Степени формировании специалистов и.", "Грубый Стальной Шарф", 730.49000000000001, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Показывает повышению важные форм шагов поставленных образом другой активом.", "Свободный Хлопковый Кошелек", 63.509999999999998, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Category", "Description", "Name", "Price" },
                values: new object[] { "Категория 3", "Определения создание всего интересный за обеспечивает различных значительной.", "Грубый Гранитный Компьютер", 138.5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 3", "Качественно существующий специалистов значительной вызывает выполнять анализа.", "Практичный Резиновый Носки", 50.869999999999997, "Популярный" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 3", "Подготовке место финансовых позиции модели информационно-пропогандистское форм уточнения предложений.", "Большой Пластиковый Стул", 811.13, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Category", "Description", "Name", "Price" },
                values: new object[] { "Категория 3", "Значение следует сложившаяся.", "Грубый Хлопковый Майка", 76.060000000000002 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 3", "Анализа структуры активом консультация новых интересный.", "Большой Меховой Сабо", 603.03999999999996, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 1", "Соответствующих прогрессивного материально-технической богатый целесообразности интересный различных.", "Невероятный Бетонный Носки", 25.09, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 2", "Поэтапного обществом профессионального важные рост организации.", "Эргономичный Пластиковый Сабо", 763.86000000000001, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Гражданского богатый новых социально-экономическое позволяет требует участниками.", "Практичный Пластиковый Автомобиль", 515.83000000000004 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Кадровой создаёт важные организации общественной отношении модели.", "Практичный Меховой Ботинок", 724.77999999999997, "Новинка" });

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_ProductId",
                table: "CartItems",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_ShoppingCartId",
                table: "CartItems",
                column: "ShoppingCartId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CartItems");

            migrationBuilder.DropTable(
                name: "ShoppingCarts");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Category", "Description", "Name", "Price" },
                values: new object[] { "Категория 2", "Сущности способствует позволяет высшего нас существующий анализа участия работы.", "Свободный Неодимовый Шарф", 33.060000000000002 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Количественный сущности повседневная отношении формированию значимость кругу обеспечивает сущности активизации.", "Фантастический Кожанный Стол", 81.980000000000004, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Category", "Description", "Name", "Price" },
                values: new object[] { "Категория 1", "Материально-технической социально-ориентированный образом повышение повседневная социально-ориентированный ресурсосберегающих формировании нами модели.", "Свободный Пластиковый Плащ", 338.91000000000003 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Category", "Description", "Name", "Price" },
                values: new object[] { "Категория 2", "Позиции кадровой активизации прогрессивного таким.", "Лоснящийся Неодимовый Стол", 293.82999999999998 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Предложений формированию участниками другой повседневной.", "Маленький Кожанный Носки", 372.69999999999999, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 1", "Образом же высшего.", "Великолепный Хлопковый Шарф", 986.78999999999996, "Рекомендуемый" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 1", "Постоянный модели подготовке позволяет управление нас обеспечивает высокотехнологичная.", "Практичный Пластиковый Стул", 392.16000000000003, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Category", "Description", "Name", "Price" },
                values: new object[] { "Категория 3", "Технологий социально-ориентированный в процесс с организации актуальность.", "Эргономичный Кожанный Кошелек", 930.74000000000001 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Активизации широким важные начало повседневная предпосылки участия специалистов дальнейших укрепления.", "Маленький Меховой Автомобиль", 782.41999999999996 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 2", "Значимость консультация способствует.", "Большой Стальной Сабо", 200.53, "Популярный" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Технологий потребностям значительной нами высокотехнологичная подготовке.", "Свободный Кожанный Куртка", 643.82000000000005, "Популярный" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Category", "Description", "Name", "Price" },
                values: new object[] { "Категория 1", "Собой формированию сознания широкому.", "Великолепный Меховой Кошелек", 788.79999999999995 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 2", "Анализа напрямую способствует профессионального не целесообразности разнообразный создаёт.", "Лоснящийся Стальной Кулон", 985.02999999999997, "Рекомендуемый" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 1", "На определения разнообразный с.", "Практичный Натуральный Кепка", 644.55999999999995, "Рекомендуемый" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Category", "Description", "Name", "Price" },
                values: new object[] { "Категория 2", "Позиции важные очевидна широким важные финансовых.", "Эргономичный Бетонный Кошелек", 271.19999999999999 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 2", "Проект обуславливает сознания высшего.", "Потрясающий Деревянный Ботинок", 962.64999999999998, "Популярный" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 3", "Равным управление административных информационно-пропогандистское представляет.", "Лоснящийся Бетонный Кепка", 177.62, "Рекомендуемый" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 3", "Кадровой стороны широкому системы создание сложившаяся массового материально-технической работы специалистов.", "Эргономичный Гранитный Компьютер", 436.75, "Популярный" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Прогресса значительной начало.", "Потрясающий Натуральный Клатч", 550.37 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Обеспечение шагов участниками.", "Великолепный Гранитный Куртка", 472.85000000000002, "Рекомендуемый" });
        }
    }
}
