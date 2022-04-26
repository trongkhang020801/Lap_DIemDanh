using System;

namespace BaiTapDiemDanh
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    class PhuongTrinhB2
    {
        private Double a;
        private Double b;
        private Double c;
        public PhuongTrinhB2(Double a, Double b,Double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }    
        public double A { get => a; set => a = value; }
        public double B { get => b; set => b = value; }
        public double C { get => c; set => c = value; }

        public Double Delta(Double a, Double b, Double c)
        {
            return b * b - 4 * a * c;
        }
        
        public Double Nghiem(Double a, Double b, Double c)
        {
            Double x1, x2;
            if (Delta(a, b, c) < 0)
                return -1;
            else
                if (Delta(a, b, c) == 0)
                return 0;
            else
                return 1;
        }    
    }
}
