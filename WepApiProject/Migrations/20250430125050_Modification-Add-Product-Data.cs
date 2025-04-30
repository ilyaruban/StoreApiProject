using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WepApiProject.Migrations
{
    /// <inheritdoc />
    public partial class ModificationAddProductData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "SpecialTag",
                table: "Products",
                type: "text",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Category", "Description", "Image", "Name", "Price", "SpecialTag" },
                values: new object[,]
                {
                    { 1, "Категория 2", "Повседневная управление повседневной с мира систему целесообразности активизации форм.", "https://placehold.co/200", "Грубый Бетонный Кепка", 507.81999999999999, "Популярный" },
                    { 2, "Категория 1", "Принципов организационной оценить интересный шагов очевидна массового высокотехнологичная.", "https://placehold.co/200", "Практичный Натуральный Автомобиль", 201.65000000000001, "Новинка" },
                    { 3, "Категория 1", "Понимание новых выбранный дальнейших.", "https://placehold.co/200", "Потрясающий Неодимовый Ботинок", 195.28999999999999, "Новинка" },
                    { 4, "Категория 1", "Дальнейших активом повышению богатый создаёт.", "https://placehold.co/200", "Маленький Деревянный Сабо", 587.66999999999996, "Рекомендуемый" },
                    { 5, "Категория 2", "По социально-ориентированный образом шагов разнообразный постоянный активизации внедрения.", "https://placehold.co/200", "Свободный Меховой Стол", 348.66000000000003, "Рекомендуемый" },
                    { 6, "Категория 1", "С плановых сфера выбранный насущным однако в различных.", "https://placehold.co/200", "Потрясающий Кожанный Плащ", 248.15000000000001, "Популярный" },
                    { 7, "Категория 3", "Информационно-пропогандистское сознания вызывает высокотехнологичная представляет.", "https://placehold.co/200", "Свободный Бетонный Ножницы", 627.42999999999995, "Популярный" },
                    { 8, "Категория 1", "Важные проект рост обществом очевидна важные следует.", "https://placehold.co/200", "Свободный Стальной Кошелек", 66.939999999999998, "Популярный" },
                    { 9, "Категория 1", "Вызывает повседневной определения богатый задач воздействия забывать реализация таким.", "https://placehold.co/200", "Потрясающий Резиновый Куртка", 531.80999999999995, "Рекомендуемый" },
                    { 10, "Категория 2", "Качества влечёт структура сфера интересный стороны обучения рамки модернизации современного.", "https://placehold.co/200", "Маленький Пластиковый Шарф", 793.07000000000005, "Популярный" },
                    { 11, "Категория 2", "Развития формирования специалистов подготовке рамки качества прогресса формировании обеспечение.", "https://placehold.co/200", "Свободный Деревянный Майка", 176.00999999999999, "Новинка" },
                    { 12, "Категория 2", "Развития насущным новых равным предпосылки задача подготовке.", "https://placehold.co/200", "Маленький Кожанный Кошелек", 284.91000000000003, "Новинка" },
                    { 13, "Категория 3", "Создаёт управление создание.", "https://placehold.co/200", "Лоснящийся Хлопковый Майка", 685.71000000000004, "Рекомендуемый" },
                    { 14, "Категория 1", "Прежде обучения модели насущным.", "https://placehold.co/200", "Фантастический Натуральный Компьютер", 483.77999999999997, "Новинка" },
                    { 15, "Категория 2", "Сущности представляет реализация выбранный создание определения.", "https://placehold.co/200", "Фантастический Пластиковый Стол", 872.78999999999996, "Новинка" },
                    { 16, "Категория 3", "Повышение рост широким.", "https://placehold.co/200", "Большой Бетонный Стул", 82.430000000000007, "Новинка" },
                    { 17, "Категория 2", "Влечёт значительной порядка подготовке нашей позиции по играет.", "https://placehold.co/200", "Великолепный Деревянный Берет", 37.25, "Новинка" },
                    { 18, "Категория 2", "Важные и количественный организационной предпосылки обеспечение.", "https://placehold.co/200", "Фантастический Неодимовый Клатч", 765.30999999999995, "Новинка" },
                    { 19, "Категория 1", "Сложившаяся для систему нами.", "https://placehold.co/200", "Большой Бетонный Автомобиль", 578.46000000000004, "Рекомендуемый" },
                    { 20, "Категория 3", "Профессионального важные высшего прежде.", "https://placehold.co/200", "Невероятный Гранитный Стул", 256.60000000000002, "Популярный" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.AlterColumn<int>(
                name: "SpecialTag",
                table: "Products",
                type: "integer",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");
        }
    }
}
