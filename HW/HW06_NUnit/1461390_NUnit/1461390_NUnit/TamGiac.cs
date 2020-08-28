using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTNunit
{
    public class TamGiac
    {
        public double a;
        public double b;
        public double c;

        public TamGiac()
        {
            a = 0;
            b = 0;
            c = 0;
        }

        public TamGiac(int x)
        {
            a = x;
            b = x;
            c = x;
        }

        public TamGiac(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public double tinhChuVi()
        {
            return a + b + c;
        }

        public double tinhDienTich()
        {
            double p = tinhChuVi();
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        public String toString()
        {
            return String.Format("a = {0}, b = {1}, c = {2}", a, b, c);
        }
    }
}
