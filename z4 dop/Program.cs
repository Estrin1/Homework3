//Дано трехзначное число определить кратна ли 3 сумма его чисел
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int i=0,j=0,q=0;
i = number / 100;
Console.WriteLine(i);
j = number % 10; 
Console.WriteLine(j);
q = (number - i*100) / 10;
Console.WriteLine(q);
if ((i+j+q) % 3 ==0 ) Console.WriteLine("Сумма чисел кратна 3");
else Console.WriteLine("Сумма чисел не кратна 3");