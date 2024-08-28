using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trjfiguras2
{
    public abstract class Figuras
    {
        public float area { get; private set; }
        public float perimetro { get; private set; }

        public Figuras (float area, float perimetro)
        {
            this.area = area;
            this.perimetro = perimetro;
        }

    }

    public class Retangulo : Figuras
    {
        public float ladoA { get; private set; }
        public float ladoB { get; private set; }
        public Retangulo(float ladoA, float ladoB) : base (ladoA*ladoB, 2*(ladoB+ladoA))
        {
            this.ladoA = ladoA;
            this.ladoB = ladoB;
        }

        public float diagonal()
        {
            return(float) Math.Sqrt(ladoA*ladoA + ladoB*ladoB); //= Math.Sqrt(Math.Pow(ladoA, 2) + Math.Pow(ladoB, 2)
        }

    }

    public class Circulo : Figuras
    {
        public float raio { get; private set; }

        public Circulo (float raio) : base((float)Math.PI * raio*raio, 2 * (float) Math.PI * raio)
        {
            this.raio = raio;
        }
    }

    public class Quadrado : Retangulo
    {
        public Quadrado (float lado) : base(lado, lado)
        {

        }
    }
}
