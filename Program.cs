using System;

//namespace ArrayProject
//{
//    interface ICalc
//    {
//        int Less(int valueToCompare);
//        int Greater(int valueToCompare);
//    }

//    class Array : ICalc
//    {
//        private int[] numbers;

//        public Array(int[] numbers)
//        {
//            this.numbers = numbers;
//        }
        
//        public int Less(int valueToCompare)
//        {
//            int count = 0;

//            foreach (int number in numbers)
//            {
//                if (number < valueToCompare)
//                {
//                    count++;
//                }
//            }

//            return count;
//        }
//        public int Greater(int valueToCompare)
//        {
//            int count = 0;

//            foreach (int number in numbers)
//            {
//                if (number > valueToCompare)
//                {
//                    count++;
//                }
//            }

//            return count;
//        }

//        public void Show()
//        {
//            Console.WriteLine("Array elements:");

//            foreach (int number in numbers)
//            {
//                Console.Write(number + " ");
//            }

//            Console.WriteLine();
//        }
//    }

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int[] data = { 5, 10, 15, 20, 25, 30 };

//            Array array = new Array(data);

//            array.Show();

//            Console.WriteLine();

//            int value = 20;

//            Console.WriteLine($"Number of elements less than {value}: {array.Less(value)}");

//            Console.WriteLine($"Number of elements greater than {value}: {array.Greater(value)}");
//        }
//    }
//}


namespace ValidatorProject
{
    interface IValidator
    {
        bool Validate();
    }

    class PasswordValidator : IValidator
    {
        private string password;

        public PasswordValidator(string password)
        {
            this.password = password;
        }

        public bool Validate()
        {
            return password.Length >= 8;
        }
    }

    class EmailValidator : IValidator
    {
        private string email;

        public EmailValidator(string email)
        {
            this.email = email;
        }

        public bool Validate()
        {
            return email.Contains("@") && email.Contains(".");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            PasswordValidator password =
                new PasswordValidator("mypassword123");

            Console.WriteLine("Password validation:");

            if (password.Validate())
            {
                Console.WriteLine("Password is valid");
            }
            else
            {
                Console.WriteLine("Password is invalid");
            }

            Console.WriteLine();

            EmailValidator email =
                new EmailValidator("test@gmail.com");

            Console.WriteLine("Email validation:");

            if (email.Validate())
            {
                Console.WriteLine("Email is valid");
            }
            else
            {
                Console.WriteLine("Email is invalid");
            }
        }
    }
}