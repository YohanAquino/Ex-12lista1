using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_12_LISTA_1_Yohan_Aquino
{
    class Triangulo
    {
        private int n1;
        private int n2;
        private int n3;
        private double r1;
        private double r2;
        private double r3;
        public void setNum1(int x)
        {
            n1 = x;
        }
        public void setNum2(int x)
        {
            n2 = x;
        }
        public void setNum3(int x)
        {
            n3 = x;
        }
        public Boolean verificarTriangulo()
        {
            r1 = Math.Sqrt(Math.Pow(n2, 2) + Math.Pow(n3, 2));
            r2 = Math.Sqrt(Math.Pow(n1, 2) + Math.Pow(n3, 2));
            r3 = Math.Sqrt(Math.Pow(n1, 2) + Math.Pow(n2, 2));
            if (n1 == r1  || n2 == r2 || n3 == r3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
