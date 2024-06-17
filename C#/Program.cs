namespace C_
{   internal class program 
    {
        static void Main(string[] args) 
        { 
        }
    }

    public class Calulator 
    { 
        public Calulator() 
        { 
        
        }
        public void menu()
        {
            string option;
            int num1;
            int num2;
            string[] Valid = { "A", "M", "D", "S" };
            while (true)
            {
                Console.WriteLine("Choose a option(A,M,D,S)");
                option = Console.ReadLine();
                if (Valid.Contains(option) )
                {
                    break;
                }
            }
            Console.WriteLine("Enter your first number");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your Second number");
            num2 = int.Parse(Console.ReadLine());
            if (option == "A")
            { 
                Console.WriteLine(add(num1, num2));
            }
            if (option == "M")
            {
                Console.WriteLine(multi(num1, num2));
            }
            if (option == "D")
            {
                Console.WriteLine(div(num1, num2));
            }
            if (option == "S")
            {
                Console.WriteLine(sub(num1, num2));
            }

        }

        public int add(int num1 , int num2) 
        { 
            int ans =num1 + num2;  
            return ans;
        }
        public int multi(int num1, int num2)
        {
            int ans = num1 * num2;
            return ans;
        }
        public int div(int num1, int num2)
        {
            int ans = num1 / num2;
            return ans;
        }
        public int sub(int num1, int num2)
        {
            int ans = num1 - num2;
            return ans;
        }
    }
}   