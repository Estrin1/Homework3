Console.WriteLine("Введите число");
int x = Convert.ToInt32(Console.ReadLine());
int i = 1;
int write =0;
while(i <= x)
{
write = i * i* i;
Console.WriteLine("" + write);
i++;
}
