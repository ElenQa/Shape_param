using Shape_param;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape_param
{
    public class Main_M
    {

        public static void Main(string[] args)
        {
            int tr_side1 = 0;
            int tr_side2 = 0;
            int tr_side3 = 0;
            double tr_angle = 0;

            foreach (string param in args)
            {
                //Console.WriteLine(param);
                tr_side1 = Convert.ToInt32(args[0]);
                tr_side2 = Convert.ToInt32(args[1]);
                tr_side3 = Convert.ToInt32(args[2]);
                tr_angle = Convert.ToInt32(args[3]);
            }

            Shape tr = new Triangle1(tr_side1, tr_side2, tr_side3, tr_angle, "Triangle");

            Console.WriteLine(tr);
            Console.ReadLine();
        }
    }
}


