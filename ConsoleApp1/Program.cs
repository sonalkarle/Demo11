namespace LogicalProblem
{
    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Choose a number to go to the respective problem, \n");
            Console.WriteLine("1 for Perfect Number");
            Console.WriteLine("2 for Prime Numer");
            Console.WriteLine("3 for Reverse a Number");

            int Option = Convert.ToInt32(Console.ReadLine());

            switch (Option)
            {

                case 1:
                    Perfect perfect = new Perfect();
                    perfect.Perfectnum();
                    break;
                case 2:
                    Prime prime = new Prime();
                    prime.PrimeNum();
                    break;
                case 3:
                    Reverse reverse = new Reverse();
                    reverse.ReverseNum();
                    break;
            }
        }
    }
}
