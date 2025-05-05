using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace WepApiProject.Migrations
{
    /// <inheritdoc />
    public partial class AddOrderDetailsandaddOrderHeaders : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OrderHeaders",
                columns: table => new
                {
                    OrderHeaderId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CustomerName = table.Column<string>(type: "text", nullable: false),
                    CustomerEmail = table.Column<string>(type: "text", nullable: false),
                    AppUserId = table.Column<string>(type: "text", nullable: false),
                    OrderTotalAmount = table.Column<double>(type: "double precision", nullable: false),
                    OrderDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Status = table.Column<string>(type: "text", nullable: false),
                    TotalCount = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderHeaders", x => x.OrderHeaderId);
                    table.ForeignKey(
                        name: "FK_OrderHeaders_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    OrderDetailId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    OrderHeaderId = table.Column<int>(type: "integer", nullable: false),
                    ProductId = table.Column<int>(type: "integer", nullable: false),
                    Quantity = table.Column<int>(type: "integer", nullable: false),
                    ItemName = table.Column<string>(type: "text", nullable: false),
                    Price = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.OrderDetailId);
                    table.ForeignKey(
                        name: "FK_OrderDetails_OrderHeaders_OrderHeaderId",
                        column: x => x.OrderHeaderId,
                        principalTable: "OrderHeaders",
                        principalColumn: "OrderHeaderId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 2", "Другой намеченных представляет.", "Эргономичный Бетонный Портмоне", 650.92999999999995, "Рекомендуемый" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Участниками концепция играет обеспечивает важные активизации однако степени инновационный.", "Фантастический Бетонный Берет", 198.13999999999999, "Рекомендуемый" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 2", "Активом высокотехнологичная организации предложений проект следует очевидна обеспечение влечёт.", "Невероятный Гранитный Куртка", 29.82, "Популярный" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 1", "Также общественной показывает по участия направлений отметить сомнений поэтапного.", "Потрясающий Бетонный Компьютер", 42.590000000000003, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 1", "Практика структуры нас информационно-пропогандистское национальный.", "Эргономичный Неодимовый Стул", 5.7999999999999998, "Популярный" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 1", "В позволяет управление дальнейших управление обучения высокотехнологичная.", "Грубый Хлопковый Шарф", 456.94, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Изменений другой по однако реализация таким.", "Грубый Бетонный Клатч", 909.03999999999996 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 2", "Консультация постоянное опыт шагов рамки роль формирования рост очевидна участниками.", "Свободный Гранитный Сабо", 41.630000000000003, "Популярный" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Профессионального постоянный постоянный задач качественно внедрения широкому предложений актуальность формировании.", "Большой Неодимовый Шарф", 155.09, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Category", "Description", "Name", "Price" },
                values: new object[] { "Категория 3", "Целесообразности степени определения новая социально-ориентированный позиции значительной на обучения.", "Большой Бетонный Кепка", 632.87 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 1", "Эксперимент образом от стороны создаёт.", "Невероятный Деревянный Ботинок", 920.09000000000003, "Рекомендуемый" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Category", "Description", "Name", "Price" },
                values: new object[] { "Категория 1", "Гражданского прогрессивного нас структуры задания.", "Фантастический Деревянный Ножницы", 221.69999999999999 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 1", "Базы социально-экономическое прежде разработке роль интересный опыт постоянное повседневная.", "Интеллектуальный Гранитный Портмоне", 550.74000000000001, "Рекомендуемый" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 1", "Требует вызывает направлений повышение предложений воздействия новых.", "Свободный Резиновый Берет", 20.030000000000001, "Рекомендуемый" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Category", "Description", "Name", "Price" },
                values: new object[] { "Категория 2", "Проблем базы реализация деятельности важные.", "Практичный Кожанный Ножницы", 555.83000000000004 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 1", "Очевидна изменений от общественной собой напрямую влечёт способствует занимаемых.", "Великолепный Бетонный Носки", 908.0, "Популярный" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 3", "Предпосылки новых роль сознания важные сомнений с деятельности.", "Маленький Бетонный Сабо", 886.45000000000005, "Рекомендуемый" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 3", "Предложений не технологий качественно модель кадровой играет.", "Эргономичный Деревянный Ботинок", 156.41999999999999, "Популярный" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Соображения сознания предпосылки демократической выбранный повышению рамки качества представляет важную.", "Практичный Натуральный Клатч", 192.69, "Рекомендуемый" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 1", "Инновационный соответствующей формированию важную прежде плановых место.", "Большой Пластиковый Майка", 479.08999999999997, "Популярный" });

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_OrderHeaderId",
                table: "OrderDetails",
                column: "OrderHeaderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_ProductId",
                table: "OrderDetails",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderHeaders_AppUserId",
                table: "OrderHeaders",
                column: "AppUserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "OrderHeaders");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 1", "Сфера напрямую соответствующей важные сознания повышение всего требует сомнений и.", "Фантастический Деревянный Шарф", 775.08000000000004, "Новинка" });

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
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 3", "Структура значительной отметить.", "Великолепный Хлопковый Свитер", 104.59999999999999, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 3", "Создание по настолько деятельности отметить.", "Практичный Резиновый Носки", 266.35000000000002, "Популярный" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 3", "Этих плановых работы для.", "Практичный Стальной Ботинок", 57.450000000000003, "Рекомендуемый" });

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
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Новых целесообразности модель.", "Великолепный Деревянный Свитер", 234.36000000000001 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 1", "Позволяет эксперимент создаёт следует принимаемых же демократической.", "Великолепный Неодимовый Носки", 230.97999999999999, "Рекомендуемый" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Всего систему важные способствует различных структуры.", "Лоснящийся Стальной Ремень", 756.38999999999999, "Рекомендуемый" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Category", "Description", "Name", "Price" },
                values: new object[] { "Категория 1", "Степени формировании специалистов и.", "Грубый Стальной Шарф", 730.49000000000001 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 2", "Показывает повышению важные форм шагов поставленных образом другой активом.", "Свободный Хлопковый Кошелек", 63.509999999999998, "Новинка" });

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
                columns: new[] { "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Гражданского богатый новых социально-экономическое позволяет требует участниками.", "Практичный Пластиковый Автомобиль", 515.83000000000004, "Популярный" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 3", "Кадровой создаёт важные организации общественной отношении модели.", "Практичный Меховой Ботинок", 724.77999999999997, "Новинка" });
        }
    }
}
