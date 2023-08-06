// Task1

// Console.WriteLine("Vvedite chislo");
// int num = Convert.ToInt32(Console.ReadLine());

// int [] array = new int[num];
// int count = 0;

// for(int i = 0; i < array.Length; i++)
// {
//   array[i] = new Random().Next(100,1000);
//   Console.WriteLine(array[i] + " ");
  
//   if(array[i]%2 == 0)
//   {
//     count++;
//   }
// }  
// Console.WriteLine(count);

// Task2

// Console.WriteLine("Vvedite chislo");
// int num = Convert.ToInt32(Console.ReadLine());

// int [] array = new int[num];
// int count = 1;
// int sum = 0;

// for(int i = 0; i < array.Length; i++)
// {
//   array[i] = new Random().Next(0,10);
//   Console.Write(array[i] + " ");
// }

// while(count < array.Length)
// {
//   sum = sum + array[count]; // Kak ponimaet chto eto nujniy masif?
//   count += 2;
// }  
//   Console.WriteLine(sum);

// Task3

// double [] array = new double[4];

// for(int i = 0; i < array.Length; i++)
// {
//   array[i] = Math.Round(new Random().Next(0,100) + new Random().NextDouble());
//   Console.Write(array[i] + " ");
// }

// double max = array[0];
// double min = array[0];

// int k = 1;

// while(k < array.Length)
// {
//   if(array[k] > max) max = array[k];
//   if(array[k] < min) min = array[k];
//   k++;
// }
// Console.WriteLine("Raznica " + (max-min));

