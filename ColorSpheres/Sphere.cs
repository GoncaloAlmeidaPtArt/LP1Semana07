using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColorSpheres
{
    public class Sphere
    {
        int cor;
        int raio;
        int atirada;

        public Sphere(int cor, int raio, int atirada = 0)
        {
            this.cor = cor;
            this.raio = raio;
            this.atirada = atirada;
        }

        public void Pop()
        {
            raio = 0;
        }

        public void Throw()
        {
            if(raio > 0)
            {
                atirada = atirada + 1;
            }
        }

        public int GetTimesThrow()
        {
            return  atirada;
            
        }
    }
}