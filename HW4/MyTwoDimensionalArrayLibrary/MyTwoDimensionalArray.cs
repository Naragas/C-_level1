using System;
using System.Collections.Generic;
using System.IO;

namespace MyTwoDimensionalArrayLibrary
{
    public class MyTwoDimensionalArray
    {
        /*       private int[,] Data { get; }

               Random rnd = new Random();

               public MyTwoDimensionalArray(int n, int m)
               {
                   Data = new int[n, m];
                   for (int i = 0; i < n; i++)
                   {
                       for (int j = 0; j < m; j++)
                       {
                           Data[i, j] = rnd.Next(1, 50);

                       }
                   }
               }

               public MyTwoDimensionalArray(String fileName)
               {
                   (uint rowsTotal, uint columnsTotal) = ParseDimentions(fileName);
                   CheckDimentions(rowsTotal, columnsTotal);

                   Data = new int[rowsTotal, columnsTotal];
                   foreach (var (row,column,value) in ReadFileSafe(fileName))
                   {
                       Data[row, column] = value;
                   }


               }

               private void CheckDimentions(uint numberOfRows, uint numberOfColumns)
               {
                   if (numberOfRows == 0 || numberOfColumns == 0)
                   {
                       throw new ArgumentException("Cant create zero length two-dim array");
                   }
               }

               private static IEnumerable<(int row, int column, int value)> ReadFileSafe(string fileName)
               {
                   if (!File.Exists(fileName))
                   {
                       throw new FileNotFoundException();
                   }
                   int CurrentRow = 0;
                   bool ColumnsLimitIsSet = false;
                   int ColumnsLimit = 0;

                   using (StreamReader streamReader = new StreamReader(fileName))
                   {
                       if (streamReader.Peek() == -1)
                       {
                           throw new ArgumentException($"Файл {fileName} пустой.");
                       }

                       while (streamReader.Peek() >= 0)
                       {
                           string LineToParse = streamReader.ReadLine();
                           string[] Elements = LineToParse.Split(',');

                           if (!ColumnsLimitIsSet)
                           {
                               ColumnsLimit = Elements.Length;
                               if (ColumnsLimit == 0)
                               {
                                   throw new ArgumentException($"Неверное количество колонок в {fileName} в ряду {CurrentRow + 1}, должна быть хотя бы 1 колонка.");
                               }
                           }

                           if (Elements.Length != ColumnsLimit)
                           {
                               throw new ArgumentException($"Неверное количество колонок в {fileName} в ряду {CurrentRow + 1}, должно быть {ColumnsLimit} колонок");
                           }
                           int[] ParseIntegers;

                           try
                           {
                               ParseIntegers = Array.ConvertAll(Elements, int.Parse);
                           }
                           catch
                           {
                               throw new ArgumentException($"Файл {fileName} содержет неверные данные в ряду {CurrentRow + 1}");
                           }

                           for (int i = 0; i < ParseIntegers.Length; i++)
                           {
                               yield return (row: CurrentRow, column: i, value: ParseIntegers[i]);
                           }
                           CurrentRow++;
                       }
                   }
               }



               private static (uint rowsTotal, uint columnsTotal) ParseDimentions(string fileName)
               {
                   if (!File.Exists(fileName))
                   {
                       throw new FileNotFoundException();
                   }

                   uint RowsTotal = 0;
                   uint ColumnsTotal = 0;

                   bool ColumnsLimitIsSet = false;

                   using (StreamReader streamReader = new StreamReader(fileName))
                   {
                       if (streamReader.Peek() == -1)
                       {
                           throw new ArgumentException($"Файл {fileName} пустой.");
                       }

                       while (streamReader.Peek() >= 0)
                       {
                           RowsTotal++;

                           String s = streamReader.ReadLine();
                           if (!ColumnsLimitIsSet)
                           {
                               string[] elements = s.Split(',');

                               ColumnsTotal = (uint)elements.Length;

                               if (ColumnsTotal == 0)
                               {
                                   throw new ArgumentException($"Неверное число колонок в {fileName} в строке {RowsTotal} должна быть хотя бы 1 колонка.");
                               }
                           }
                       }
                   }

                   return (rowsTotal: RowsTotal, columnsTotal: ColumnsTotal);

               }

               public string OutputdataToDirectory(string folderName)
               {
                   if (!Directory.Exists(folderName))
                   {
                       Directory.CreateDirectory(folderName);
                   }

                   string fileName = Path.GetRandomFileName();
                   string pathString = Path.Combine(folderName, fileName);

                   using (StreamWriter file = new StreamWriter(@pathString))
                   {
                       for (int i = 0; i < Data.GetLength(0); i++)
                       {
                           string line = "";

                           for (int j = 0; j < Data.GetLength(1); j++)
                           {
                               line += Data[i, j] + ",";
                           }

                           line = line.TrimEnd(',');
                           file.WriteLine(line);

                       }
                   }

                   return pathString;
               }

               public int Summ()
               {
                   int result = 0;
                   for (int i = 0; i < Data.GetLength(0); i++)
                   {
                       for (int j = 0; j < Data.GetLength(1); j++)
                       {
                           result += Data[i, j];
                       }
                   }
                   return result;
               }

               public int SummMoreThan(int n)
               {
                   int result = 0;
                   for (int i = 0; i < Data.GetLength(0); i++)
                   {
                       for (int j = 0; j < Data.GetLength(1); j++)
                       {
                           if (Data[i, j] > n)
                           {
                               result += Data[i, j];
                           }
                       }
                   }
                   return result;
               }

               public int Min
               {
                   get
                   {
                       int min = Data[0, 0];
                       for (int i = 0; i < Data.GetLength(0); i++)
                       {
                           for (int j = 0; j < Data.GetLength(1); j++)
                           {
                               if (Data[i, j] < min) min = Data[i, j];
                           }
                       }
                       return min;
                   }

               }

               public int Max
               {
                   get
                   {
                       int max = Data[0, 0];
                       for (int i = 0; i < Data.GetLength(0); i++)
                       {
                           for (int j = 0; j < Data.GetLength(1); j++)
                           {
                               if (Data[i, j] > max) max = Data[i, j];
                           }
                       }
                       return max;
                   }
               }

               public void MaxElementNumber(ref List<int> indexNumber)
               {
                   for (int i = 0; i < Data.GetLength(0); i++)
                   {
                       for (int j = 0; j < Data.GetLength(1); j++)
                       {
                           if (Data[i, j] == Max)
                           {
                               indexNumber.Add((i * Data.GetLength(1)) + j + 1);
                           }
                       }
                   }
               }*/
    }
}
