namespace Delegate
{
    using System;

    class Program
    {
        // Define a delegate
        private delegate void OutStudentHandler(Student student, EventArgs eventArgs);
        private delegate void ShowMessageDelegate();

        static void Main(string[] args)
        {
            OutStudentHandler Handler;
            ShowMessageDelegate ShowMessageDelegate;

            Handler = ShowStudent;

            var age = 19;

            if (age >= 18)
            {
                ShowMessageDelegate = ShowMessage;
            }
            else
            {
                ShowMessageDelegate = ShowMessageAgain;
            }


            ShowMessageDelegate();


            //Action A =  
            //Func<int> = 

            var numbers = new Numbers {PrintNumber = PrintNumber};

            numbers.GetNumber(5);

            Console.ReadLine();

        }

        private static void PrintNumber(int i)
        {
            Console.WriteLine("Procesando " + i);
        }

        private static void ShowMessage() => Console.WriteLine("Hello World ");
        private static void ShowMessageAgain() => Console.WriteLine("Hello World :)");
        private static void ShowStudent(Student student, EventArgs eventArgs) => Console.WriteLine(student);    
    }
}
