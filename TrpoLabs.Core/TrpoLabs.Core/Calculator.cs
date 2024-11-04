namespace TrpoLabs.Core
{
    public class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public double CalcularAreaCono(double radio, double altura)
        {
            double area = Math.PI * radio * (radio + Math.Sqrt(altura * altura + radio * radio));
            return area;
        }
    }
}


