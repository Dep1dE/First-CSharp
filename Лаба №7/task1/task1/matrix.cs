using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace task1
{
    public class matrix
    {
        int[,] numbers;


        public matrix()
        {
            numbers = new int[2, 2] { { 0, 0 }, { 0, 0 } };
        }
        public matrix(int a, int b, int c, int d)
        {
            numbers = new int[2, 2] { { a, b }, { c, d } };
        }

        public int this[int i, int j]
        {
            get => numbers[i, j];
            set => numbers[i, j] = value;
        }

        public override string ToString()
        {
            string boof = "";
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    boof += numbers[i, j] + " ";
                }
                boof += "\n";
            }
            return boof;
        }
        public static matrix operator +(matrix m1, matrix m2)
        {
            matrix result = new matrix();
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    result[i, j] = m1[i, j] + m2[i, j];
                }
            }
            return result;
        }

        public static matrix operator -(matrix m1, matrix m2)
        {
            matrix result = new matrix();
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    result[i, j] = m1[i, j] - m2[i, j];
                }
            }
            return result;
        }

        public static matrix operator ++(matrix m)
        {
            matrix result = new matrix();
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    result[i, j] = m[i, j] + 1;
                }
            }
            return result;
        }

        public static matrix operator --(matrix m)
        {
            matrix result = new matrix();
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    result[i, j] = m[i, j] - 1;
                }
            }
            return result;
        }

        public static matrix operator *(matrix m, int x)
        {
            matrix result = new matrix();
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    result[i, j] = m[i, j] * x;
                }
            }
            return result;
        }

        public static matrix operator *(int x, matrix m)
        {
            return m * x;
        }

        public static matrix operator /(matrix m, int x)
        {
            matrix result = new matrix();
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    result[i, j] = m[i, j] / x;
                }
            }
            return result;
        }

        public static bool operator ==(matrix m, matrix n)
        {
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    if (m[i, j] != n[i, j])
                        return false;
                }
            }
            return true;
        }

        public static bool operator !=(matrix m, matrix n)
        {
            return !(m == n);
        }

        public static explicit operator int(matrix m)
        {
            return m[0, 0] * m[1, 1] - m[0, 1] * m[1, 0];
        }

        public static explicit operator matrix(int x)
        {
            return new matrix(x, 0, 0, x);
        }
    }
}
