namespace Predicate_Delegate_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Predicate<string> isUpper = IsUpperCase;
            Console.WriteLine($"IsUpperCase() named method: {isUpper("AIJAZ")}");


            // Predicate delegate with anonymous method.
            Predicate<int> isEqual = delegate (int x) { return x == 1; };
            Console.WriteLine($"Anonymous method: {isEqual(10)}");

            //Predicate delegate with lambda expression

            Predicate<string> isStrEqual = str => str.Equals("aijaz");
            Console.WriteLine($"Lambda expression: {isStrEqual("aijaz")}");
        }

        static bool IsUpperCase(string param)
        {
            return param.Equals(param.ToUpper());
        }
    }
}
