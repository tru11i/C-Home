Console.WriteLine("Vvedite chislo");
int num = Convert.ToInt32(Console.ReadLine());

if (num < 6) 
{
Console.WriteLine("Eto budniy den");
}
else if ((num >5) || (num < 8))
{
  Console.WriteLine("Eto vixodnie");
}
else 
{
  Console.WriteLine("Takogo dnya net");
}

//Function( string Day, int num)
// {
//  if(num == 1) string Day = (ponedelnik);
//  if(num == 2) string Day = (vtornik);
 // if(num == 3) string Day = (sreda);
 // if(num == 4) string Day = (chetverg);
 // if(num == 5) string Day = (pyatnica);
 // if(num == 6) string Day = (subbota);
 // if(num == 7) string Day = (voskresenie);
 // return Day;
 //}