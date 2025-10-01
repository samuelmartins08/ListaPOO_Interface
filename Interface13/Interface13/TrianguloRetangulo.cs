﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface13
{
    internal class TrianguloRetangulo
    {
        private double a, b, c;

        public TrianguloRetangulo(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public bool FormaTriangulo()
        {
            return (a + b > c) && (a + c > b) && (b + c > a);
        }

        public bool EhRetangulo()
        {
            // Para verificar se é retângulo, considera os lados, organiza para hipotenusa
            double[] lados = { a, b, c };
            Array.Sort(lados);
            double cateto1 = lados[0];
            double cateto2 = lados[1];
            double hipotenusa = lados[2];

            // Usa uma tolerância para evitar erros de ponto flutuante
            return Math.Abs(Math.Pow(hipotenusa, 2) - (Math.Pow(cateto1, 2) + Math.Pow(cateto2, 2))) < 0.0001;
        }
    }
}
