using System.Security.Cryptography.X509Certificates;

namespace leastsquare
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //输入年份
            int n = 18;
            double[] x = new double[n];
            x[0] = 2003;
            for (int i = 1; i < n; i++)
            {
                x[i] = x[i - 1] + 1;
            }


                //输入GDP
                double[] gdp =
            {
                14687673892882,
                14279937500608,
                13894817549380,
                12310409370894,
                11233276536744,
                11061553079871,
                10475682920597,
                9570406235659,
                8532229986993,
                7551500124197,
                6087164874510,
                5101703073088,
                4594307032667,
                3550342737009,
                2752131773358,
                2285965892364,
                1955347004965,
                1660287965663
            };



            double sumx = 0.0, sumy = 0.0, sumx2 = 0.0, sumxy = 0.0;
            for (int i = 0; i < n; i++)
            {
                sumx += x[i];
                sumy += gdp[i];
                sumx2 += x[i] * x[i];
                sumxy += x[i] * gdp[i];
            }

            double averageyear = sumx / n;
            double averagegdp = sumy / n;
            double b = (sumxy - n * averageyear * averagegdp) / (sumx2 - n * averageyear * averagegdp);
            double a = averagegdp - b * averageyear;

            Console.WriteLine("请输入年份：");
            double year = Convert.ToDouble(Console.ReadLine());
            Console.Write($"{year}年的GDP预测值为：{b*year+a}");
        }
    }
}