Console.WriteLine("Vvedite chisla");
int A = Convert.ToInt32(Console.ReadLine());
int B = Convert.ToInt32(Console.ReadLine());
if(A > B)

{
    Console.Write("Max = ");
    Console.WriteLine(A);
    Console.Write("Min = ");
    Console.WriteLine(B);
}
else
{
    Console.Write("Max = ");
    Console.WriteLine(B);
    Console.Write("Min = ");
    Console.WriteLine(A);
}
