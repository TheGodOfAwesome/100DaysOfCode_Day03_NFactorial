namespace NFactorialConsoleApp.Services
{
    public interface ICalculate
    {
        string Factorial(int n);
    }

    public class Calculate
    {
        public string nFactorial = " ";

        public string Factorial(int n = 1, string delimiter = " x ")
        {
            if (n <= 1) return nFactorial + "1";
            nFactorial = nFactorial + n + delimiter;
            Factorial(--n, delimiter);
            return nFactorial + "1";
        }
    }
}