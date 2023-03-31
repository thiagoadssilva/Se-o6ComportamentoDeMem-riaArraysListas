using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioModificadorParametros
{
    class Calculator
    {
        public static int sum(params int[] number) {
            int sum = 0;
            for (int i = 0; i < number.Length; i++) {
                sum += number[i];
            }
            return sum;
        }

        public static void multRef(ref int number)
        {
             number = number * 2;
        }

        public static void multOut(out int result)
        {
            result = 10 * 10; 
        }
    }
}
