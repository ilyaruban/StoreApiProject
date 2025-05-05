using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WepApiProject.Migrations
{
    /// <inheritdoc />
    public partial class AddCardInfoandaddShoppingCard : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Сущности способствует позволяет высшего нас существующий анализа участия работы.", "Свободный Неодимовый Шарф", 33.060000000000002, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Category", "Description", "Name", "Price" },
                values: new object[] { "Категория 3", "Количественный сущности повседневная отношении формированию значимость кругу обеспечивает сущности активизации.", "Фантастический Кожанный Стол", 81.980000000000004 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Материально-технической социально-ориентированный образом повышение повседневная социально-ориентированный ресурсосберегающих формировании нами модели.", "Свободный Пластиковый Плащ", 338.91000000000003 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 2", "Позиции кадровой активизации прогрессивного таким.", "Лоснящийся Неодимовый Стол", 293.82999999999998, "Популярный" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 3", "Предложений формированию участниками другой повседневной.", "Маленький Кожанный Носки", 372.69999999999999, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Образом же высшего.", "Великолепный Хлопковый Шарф", 986.78999999999996, "Рекомендуемый" });

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
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 3", "Технологий социально-ориентированный в процесс с организации актуальность.", "Эргономичный Кожанный Кошелек", 930.74000000000001, "Рекомендуемый" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Category", "Description", "Name", "Price" },
                values: new object[] { "Категория 2", "Активизации широким важные начало повседневная предпосылки участия специалистов дальнейших укрепления.", "Маленький Меховой Автомобиль", 782.41999999999996 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Значимость консультация способствует.", "Большой Стальной Сабо", 200.53 });

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
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 1", "Собой формированию сознания широкому.", "Великолепный Меховой Кошелек", 788.79999999999995, "Популярный" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Category", "Description", "Name", "Price" },
                values: new object[] { "Категория 2", "Анализа напрямую способствует профессионального не целесообразности разнообразный создаёт.", "Лоснящийся Стальной Кулон", 985.02999999999997 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "На определения разнообразный с.", "Практичный Натуральный Кепка", 644.55999999999995, "Рекомендуемый" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Позиции важные очевидна широким важные финансовых.", "Эргономичный Бетонный Кошелек", 271.19999999999999 });

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
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 3", "Прогресса значительной начало.", "Потрясающий Натуральный Клатч", 550.37, "Популярный" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Обеспечение шагов участниками.", "Великолепный Гранитный Куртка", 472.85000000000002, "Рекомендуемый" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Повседневная управление повседневной с мира систему целесообразности активизации форм.", "Грубый Бетонный Кепка", 507.81999999999999, "Популярный" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Category", "Description", "Name", "Price" },
                values: new object[] { "Категория 1", "Принципов организационной оценить интересный шагов очевидна массового высокотехнологичная.", "Практичный Натуральный Автомобиль", 201.65000000000001 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Понимание новых выбранный дальнейших.", "Потрясающий Неодимовый Ботинок", 195.28999999999999 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 1", "Дальнейших активом повышению богатый создаёт.", "Маленький Деревянный Сабо", 587.66999999999996, "Рекомендуемый" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 2", "По социально-ориентированный образом шагов разнообразный постоянный активизации внедрения.", "Свободный Меховой Стол", 348.66000000000003, "Рекомендуемый" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "С плановых сфера выбранный насущным однако в различных.", "Потрясающий Кожанный Плащ", 248.15000000000001, "Популярный" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 3", "Информационно-пропогандистское сознания вызывает высокотехнологичная представляет.", "Свободный Бетонный Ножницы", 627.42999999999995, "Популярный" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 1", "Важные проект рост обществом очевидна важные следует.", "Свободный Стальной Кошелек", 66.939999999999998, "Популярный" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Category", "Description", "Name", "Price" },
                values: new object[] { "Категория 1", "Вызывает повседневной определения богатый задач воздействия забывать реализация таким.", "Потрясающий Резиновый Куртка", 531.80999999999995 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Качества влечёт структура сфера интересный стороны обучения рамки модернизации современного.", "Маленький Пластиковый Шарф", 793.07000000000005 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Развития формирования специалистов подготовке рамки качества прогресса формировании обеспечение.", "Свободный Деревянный Майка", 176.00999999999999, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 2", "Развития насущным новых равным предпосылки задача подготовке.", "Маленький Кожанный Кошелек", 284.91000000000003, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Category", "Description", "Name", "Price" },
                values: new object[] { "Категория 3", "Создаёт управление создание.", "Лоснящийся Хлопковый Майка", 685.71000000000004 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Прежде обучения модели насущным.", "Фантастический Натуральный Компьютер", 483.77999999999997, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Сущности представляет реализация выбранный создание определения.", "Фантастический Пластиковый Стол", 872.78999999999996 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 3", "Повышение рост широким.", "Большой Бетонный Стул", 82.430000000000007, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 2", "Влечёт значительной порядка подготовке нашей позиции по играет.", "Великолепный Деревянный Берет", 37.25, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 2", "Важные и количественный организационной предпосылки обеспечение.", "Фантастический Неодимовый Клатч", 765.30999999999995, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 1", "Сложившаяся для систему нами.", "Большой Бетонный Автомобиль", 578.46000000000004, "Рекомендуемый" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Профессионального важные высшего прежде.", "Невероятный Гранитный Стул", 256.60000000000002, "Популярный" });
        }
    }
}
