using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio1
{
    class Retangulo
    {
        public double Area;
        public double Perimetro;
        public double Diagonal;

        public void CalcularRetangulo(double largura, double altura)
        {
            Area = largura * altura;
            Perimetro = 2 * (largura + altura);
            Diagonal = Math.Sqrt((largura * largura) + (altura * altura));
        }

        public override string ToString()
        {
            return "Area = " 
                + Area
                + " \nPerímetro = " 
                + Perimetro 
                + " \nDiagonal = " 
                + Diagonal;
             
            
        }
    }

    
}
