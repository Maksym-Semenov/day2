double productPrice1 = 101.5; // ціна 1го продукту
double productPrice2 = 50.25; // ціна 2го продукту
double productPrice3 = 10.11; // ціна 3го продукту
double result1 = (productPrice1 + productPrice2 + productPrice3) / 3;

int productQuantity1 = 5;  // кількість одиниць 1го продукту на складі
int productQuantity2 = 9;  // кількість одиниць 2го продукту на складі
int productQuantity3 = 15; // кількість одиниць 3го продукту на складі
double result2 = (productPrice1 * productQuantity1)
               + (productPrice2 * productQuantity2)
               + (productPrice2 * productQuantity2);

// Виведіть на екран:
// 1) Середню ціну на продукти 
// 2) Загальну ціну усіх продуктів які є на складі
Console.WriteLine("Average price of all goods is " + result1);
Console.WriteLine("The price of all goods is " + result2);
Console.ReadLine();
