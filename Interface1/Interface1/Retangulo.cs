using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface1
{
    internal class Retangulo
    {
        double b;
        double h;
        double a;

        public Retangulo()
        {
            this.b = 0;
            this.h = 0;
        }

        public Retangulo(double b, double h)
        {
            this.b = b;
            this.h = h;
        }

        public void setBase(double b) => this.b = b;
        public void setAltura(double h) => this.h = h;
        public double getBase() => this.b;
        public double getAltura() => this.h;
        public double getArea() => this.a;

        public void calcularArea()
        {
            this.a = this.b * this.h;
        }
    }
}
