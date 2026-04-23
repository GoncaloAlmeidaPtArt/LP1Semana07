using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PowerCell
{
    public class Cell
    {
        private float charge;
        public readonly string Name;
        public float Charge;
        public readonly int Level;

        public Cell(string nome)
        {
            Name = nome;
        }

            public void Consume(float amount)
        {
            amount = amount - Charge;
        }

        public void Restore()
        {
            Charge = 200;
        }

    }

}