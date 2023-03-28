using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioStructsMemoriaStackHeap
{
    struct Point //Criando um tipo valor
    {
        public double x; 
        public double y;

        public override string ToString()
        {
            return "(" + x + ", " + y + ")";
        }
    }
}
