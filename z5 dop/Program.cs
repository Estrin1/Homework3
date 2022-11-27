// Определить есть ли в 3х значном числе цифры 4 или 7
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int i=0,j=0,q=0;
i = number / 100;
Console.WriteLine(i);
j = number % 10; 
Console.WriteLine(j);
q = (number - i*100) / 10;
Console.WriteLine(q);
if ( i  == 4 | i == 7) Console.WriteLine("Искомые цифры присутствуют в числе");
else if ( j  == 4 | j == 7) Console.WriteLine("Искомые цифры присутствуют в числе");
else if ( q  == 4 | q == 7) Console.WriteLine("Искомые цифры присутствуют в числе");
else Console.WriteLine("Искомые цифры отсутствуют в числе");
