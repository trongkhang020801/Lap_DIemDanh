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
        private Double a_131;
        private Double b_131;
        private Double c_131;
        public PhuongTrinhB2(Double a, Double b,Double c)
        {
            this.a_131 = a_131;
            this.b_131 = b_131;
            this.c_131 = c_131;
        }    
        public double A { get => a_131; set => a_131 = value; }
        public double B { get => b_131; set => b_131 = value; }
        public double C { get => c_131; set => c_131 = value; }

        public Double Delta(Double a_131, Double b_131, Double c_131)
        {
            return b_131 * b_131 - 4 * a_131 * c_131;
        }
        
        public Double Nghiem(Double a_131, Double b_131, Double c_131)
        {
            Double x1_131, x2_131;
            if (Delta(a_131, b_131, c_131) < 0)
                return -1;
            else
                if (Delta(a_131, b_131, c_131) == 0)
                return 0;
            else
                return 1;
        }    
    }
}
