using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csh_lab05
{
    class Program
    {
        public class MyMatrix
        {
            public double[,] matrix;
            public int lines;
            public int columns;

            public MyMatrix(int lineCount, int columnCount)
            {
                matrix = new double[lineCount, columnCount];
                lines = lineCount;
                columns = columnCount;
                for (int i = 0; i < lineCount; i++)
                {
                    for (int j = 0; j < columnCount; j++)
                    {
                        matrix[i, j] = 0;
                    }
                }
            }
            public MyMatrix(int lineCount, int columnCount, int randBegin, int randEnd)
            {
                matrix = new double[lineCount, columnCount];
                lines = lineCount;
                columns = columnCount;
                Random rand = new Random();
                for (int i = 0; i < lineCount; i++)
                {
                    for (int j = 0; j < columnCount; j++)
                    {
                        int rnd = rand.Next(randBegin, randEnd);
                        matrix[i, j] = rnd;
                    }
                }
            }

            public double this[int elem1, int elem2]
            {
                get
                {
                    return matrix[elem1, elem2];
                }
                set
                {
                    matrix[elem1, elem2] = value;
                }
            }

            public void Fill()
            {
                Random rand = new Random();
                for (int i = 0; i < lines; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        int rnd = rand.Next(0, 100);
                        matrix[i, j] = rnd;
                    }
                }
            }

            public void ChangeSize(int linesCount, int columnCounts)
            {
                double[,] tempMat = new double[linesCount, columnCounts];
                Random rand = new Random();
                for (int i = 0; i < linesCount; i++)
                {
                    if (i < lines)
                    {
                        for (int j = 0; j < columnCounts; j++)
                        {
                            if (j < columns)
                            {
                                tempMat[i, j] = matrix[i, j];
                            }
                            else
                            {
                                int rnd = rand.Next(0, 100);
                                tempMat[i, j] = rnd;
                            }

                        }
                    }
                    else
                    {
                        for (int j = 0; j < columnCounts; j++)
                        {
                            int rnd = rand.Next(0, 100);
                            tempMat[i, j] = rnd;
                        }
                    }
                }
                matrix = new double[linesCount, columnCounts];
                matrix = tempMat;
                lines = linesCount;
                columns = columnCounts;
            }

            public void Show()
            {
                for(int i = 0; i < lines; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        Console.Write($"{matrix[i, j]} ");
                    }
                    Console.WriteLine("\r");
                }
                Console.WriteLine("\r");
            }
        }
        static void Main(string[] args)
        {
            MyMatrix xi = new MyMatrix(3, 3, 10, 20); 

            xi.Show();
            xi[0, 0] = 5;
            xi.Show();

            xi.Fill();
            xi.Show();

            xi.ChangeSize(10, 10);
            xi.Show();

            xi.Fill();
            xi.Show();

        }
    }
}
