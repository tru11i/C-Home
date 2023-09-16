//Task1

// Console.WriteLine("Vvedite razmer");
// int rows = int.Parse(Console.ReadLine());

// Console.WriteLine("Vvedite razmer");
// int columns = int.Parse(Console.ReadLine());

// double[,] matrix = new double[rows,columns];

// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         matrix[i,j] = Math.Round((new Random().Next(0,10) + new Random().NextDouble()),2);
//         Console.Write(matrix[i,j]+ " ");
//     }
//     Console.WriteLine();

// }

//Task2

// Console.WriteLine("Vvedite razmer");
// int rows = int.Parse(Console.ReadLine());

// Console.WriteLine("Vvedite razmer");
// int columns = int.Parse(Console.ReadLine());

// int[,] matrix = new int [rows,columns];

// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         matrix[i,j] = new Random().Next(0,10);
//         Console.Write(matrix[i,j] + " ");
//     }
//     Console.WriteLine();
// }

// Console.WriteLine("Vvedite stroku");
// int x = int.Parse(Console.ReadLine());

// Console.WriteLine("Vvedite stolb");
// int y = int.Parse(Console.ReadLine());

// if (x < matrix.GetLength(0) && y < matrix.GetLength(1))
// {
//     Console.WriteLine(matrix[x,y]);
// }
// else
// {
//     Console.WriteLine("takogo net");
// }

//Task3

// Console.WriteLine("Vvedite razmer");
// int rows = int.Parse(Console.ReadLine());

// Console.WriteLine("Vvedite razmer");
// int columns = int.Parse(Console.ReadLine());

// int[,] matrix = new int [rows,columns];

// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         matrix[i,j] = new Random().Next(0,10);
//         Console.Write(matrix[i,j] + " ");
//     }
//     Console.WriteLine();
// }

// double Summ = 0;
// Console.WriteLine();
// for (int j = 0; j < matrix.GetLength(1); j++)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         Summ = Summ + matrix[i,j];
//     }
//     Console.WriteLine(Summ/rows + " ");
//     Summ = 0;
// }


