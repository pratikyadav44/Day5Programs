namespace Day5Programs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select a program to run");
            Console.WriteLine("1.Flip a coin\n2.Check Leap Year\n3.Power of 2\n4.Prime factors of a number\n" +
                "5.Quotient and Remainder\n6.Swapping the numbers\n7.Check even or odd\n8.Largest among 3 numebers");
            int programNum = Convert.ToInt32(Console.ReadLine());
            switch (programNum)
            {
                case 1:
                    FlipCoin.Flips();
                    break;
                case 2:
                    LeapYear.Check1();
                    break;
                case 3:
                    PowerOf2.TwoPower();
                    break;
                case 4:
                    Factors.PrimeFactors();
                    break;
                case 5:
                    QuotientRemainder.QR();
                    break;
                case 6:
                    Swap2Numbers.swap();
                    break;
                case 7:
                    EvenOrOdd.check2();
                    break;
                case 8:
                    LargestOfThree.Largest();
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }
        }
    }
}