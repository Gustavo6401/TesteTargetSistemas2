using System;

namespace Fibonacci.Calculo
{
    public class Sequencia 
    {
        public int SequenciaFibonacci(int n) 
        {
            if(n < 2) 
            {
                return n;
            }
            return SequenciaFibonacci(n - 1) + SequenciaFibonacci(n - 2);
        }
    }
}