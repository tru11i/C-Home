Console.WriteLine("Vvedite chisla");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 999)
{
int fun(int num)
{
 while (num > 999)
{
  num = num / 10;
}
  return num;
}
 
}
else if ((num < 999) && (num > 100))
{
  num = num % 10;
  Console.WriteLine(num);
}
else
{
  Console.WriteLine("3 cifri net");
}
