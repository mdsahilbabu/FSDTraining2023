namespace FirstApp
{
    internal class Program
    {
        //static void CheckNumberStatus()// Method header
        //{
        //    int num1;
        //    //Console.WriteLine("Enter a number: ");
        //    //num1 = Convert.ToInt32(Console.ReadLine());
        //    num1 = GetARandomNumber();
        //    if (num1 > 100)
        //        Console.WriteLine("Number is too Big..!!"+num1);
        //    else
        //        Console.WriteLine($"The number {num1} is okay..!!!");
        //}

        //static int GetARandomNumber()
        //{
        //    //int num1 = new Random().Next();
        //    int num1 = new Random().Next(1,200);
        //    return num1;
        //}

        //static void AddTwoNumbers()
        //{
        //    int number1, number2;
        //    number1 = GetARandomNumber();
        //    number2 = GetARandomNumber();
        //    int sum = number1 + number2;
        //    Console.WriteLine($"The sum of {number1} and {number2} is {sum}");
        //}

        //Day-1,Question-01
        //static void addingnumbers()
        //{
        //    int n1, n2, sum;
        //    console.writeline("enter 1st number: ");
        //    n1 = convert.toint32(console.readline());
        //    console.writeline("enter 2nd number: ");
        //    n2 = convert.toint32(console.readline());
        //    sum = n1 + n2;
        //    console.writeline($"the sum of {n1} and {n2} is {sum}");
        //}

        //Day-01,Ques-04:
        //static bool PrimeNumber(int n)
        //{
        //    for (int i = 2; i < Math.Sqrt(n); i++)
        //    {
        //        if (n % i == 0)
        //        {
        //            return false;
        //        }
        //    }
        //    return true;
        //}

        static void Main(string[] args)
        {
            //string name;
            //Console.WriteLine("Enter your name");
            //name = Console.ReadLine();
            //Console.WriteLine("Welcome "+name);
            //Console.WriteLine($"Welcome {name}!!!");
            //int num1;
            //Console.WriteLine("Enter a number: ");
            //num1 = Convert.ToInt32(Console.ReadLine());
            //if(num1 > 100)
            //    Console.WriteLine("Number is too Big..!!");
            //else
            //    Console.WriteLine($"The number {num1} is okay..!!!");
            //CheckNumberStatus(); //Method invocation
            //AddTwoNumbers();
            //AddingNumbers();

            //Day-1,Question-02:
            //int n1, n2;
            //Console.WriteLine("Enter two number: ");
            //n1 = Convert.ToInt32(Console.ReadLine());
            //n2 = Convert.ToInt32(Console.ReadLine());
            //if (n1 > n2)
            //{
            //    Console.WriteLine("The Biggest Number is {0}", n1);
            //}
            //else
            //    Console.WriteLine("The biggest Number is {0}", n2);

            //Day-01,Question-03:
            //int n1;
            //Console.WriteLine("Enter two number: ");
            //n1 = Convert.ToInt32(Console.ReadLine());
            //if (n1 % 2 == 0)
            //{
            //    Console.WriteLine("The number {0} is even:", n1);
            //}
            //else
            //{
            //    Console.WriteLine("The Number {0} is odd", n1);
            //}

            //D1,Q4;
            //int n;
            //Console.WriteLine("Enter a number: ");
            //n = Convert.ToInt32(Console.ReadLine());
            //bool prime = PrimeNumber(n);
            //if (prime)
            //{
            //    Console.WriteLine("{0} is a prime number", n);
            //}
            //else
            //{
            //    Console.WriteLine("{0} is not a prime number", n);
            //}

            //D1,Q5;
            //int n;
            //Console.WriteLine("Enter a number");
            //n = Convert.ToInt32(Console.ReadLine());
            //int square = n * n;
            //Console.WriteLine("The square of {0} is {1}", n, square);

            //D1,Q6;
            int sum, i, n;
            sum = 0;
            double avg;

            Console.Write("Input the 10 numbers : ");
            for (i = 1; i <= 10; i++)
            {
                Console.Write("Number-{0} :", i);

                n = Convert.ToInt32(Console.ReadLine());
                sum += n;
            }
            avg = sum / 10.0;
            Console.Write("The sum of 10 numbers is : {0}\nThe Average is : {1}\n", sum, avg);
        }
    }
}