using System;
using System.Collections.Generic;
using System.IO;

namespace MyTwoDimensionalArrayLibrary
{
    public class MyTwoDimensionalArray
    {
        private int[,] a;
        Random rnd = new Random();

        public MyTwoDimensionalArray(int n, int m)
        {
            a = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    a[i, j] = rnd.Next(1, 50);

                }
            }
        }

        public MyTwoDimensionalArray(string filePath)
        {
            StreamReader streamReader = new StreamReader(filePath);
            while (!streamReader.EndOfStream)
            {

            }

        }

        public int Summ()
        {
            int result = 0;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    result += a[i, j];
                }
            }
            return result;
        }

        public int SummMoreThan(int n)
        {
            int result = 0;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (a[i, j] > n)
                    {
                        result += a[i, j];
                    }
                }
            }
            return result;
        }

        public int Min
        {
            get
            {
                int min = a[0, 0];
                for (int i = 0; i < a.GetLength(0); i++)
                {
                    for (int j = 0; j < a.GetLength(1); j++)
                    {
                        if (a[i, j] < min) min = a[i, j];
                    }
                }
                return min;
            }

        }

        public int Max
        {
            get
            {
                int max = a[0, 0];
                for (int i = 0; i < a.GetLength(0); i++)
                {
                    for (int j = 0; j < a.GetLength(1); j++)
                    {
                        if (a[i, j] > max) max = a[i, j];
                    }
                }
                return max;
            }
        }

        public void MaxElementNumber(ref List<int> indexNumber)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (a[i, j] == Max)
                    {
                        indexNumber.Add((i * a.GetLength(1)) + j + 1);
                    }
                }
            }
        }
    }
}
