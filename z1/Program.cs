// Ввод 5 значное число , вывод полиндром или нет
//принимает координаты 2х точек и находит расстояние между ними в 3д пространстве
//принимает н и выдает все квадраты до н
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int i=0,j=0,q=0,c=0;
i = number / 10000;
Console.WriteLine(i);
j = number % 10; 
Console.WriteLine(j);
q = (number - i *10000) / 1000;
Console.WriteLine(q);
c = (number% 100 - j) / 10;
Console.WriteLine(c); 
if (i==j && q==c ) Console.WriteLine("Число полиндром");
else Console.WriteLine("Число не полиндром");

