using System;

//Frågor
//1) Stacken Är en lista som följer först-in sist-ut principen 
//   Heapen  är ett minnes område där olika objekt kan lagras och tas bort i vilken ordning som helst
//   Deras namn beskriver dom rätt bra, Stack är en ordnad hög där du bara kan ta bort det översta
//   objektet, medan heapen är en hög med grejer där du kan ta vilken som helst

//2) Value Types lagras på stacken medan Reference Types lagras på heapen men har en pointer som
//pekar till det på stacken.
//Value types är bland annat alla numeriska typer som int, double, etc och char, Date, bool
//Reference types är bland annat String, alla klasser och alla arrayer 

//3) För att den första använder sig av int som är en value type och den andra använder MyInt som
//är en referencetype. Int x och y är olika objekt på stacken medan MyInt för MyInt x och y så pekar
//de på samma objekt på heapen eftersom y=x


namespace SkalProj_Datastrukturer_Minne
{
    class Program
    {
        /// <summary>
        /// The main method, vill handle the menues for the program
        /// </summary>
        /// <param name="args"></param>
        static void Main()
        {

            while (true)
            {
                Console.WriteLine("Please navigate through the menu by inputting the number \n(1, 2, 3 ,4, 5, 6, 0) of your choice"
                    + "\n1. Examine a List"
                    + "\n2. Examine a Queue"
                    + "\n3. Examine a Stack"
                    + "\n4. CheckParanthesis"
                    + "\n5. CheckRecursion"
                    + "\n6. CheckIteration"
                    + "\n0. Exit the application");
                char input = ' '; //Creates the character input to be used with the switch-case below.
                try
                {
                    input = Console.ReadLine()![0]; //Tries to set input to the first char in an input line
                }
                catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.
                {
                    Console.Clear();
                    Console.WriteLine("Please enter some input!");
                }
                switch (input)
                {
                    case '1':
                        ExamineList();
                        break;
                    case '2':
                        ExamineQueue();
                        break;
                    case '3':
                        ExamineStack();
                        break;
                    case '4':
                        CheckParanthesis();
                        break;
                    case '5':
                        CheckRecursion();
                        break;
                    case '6':
                        CheckIteration();
                        break;
                    case '0':
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please enter some valid input (0, 1, 2, 3, 4, 5, 6)");
                        break;
                }
            }
        }

        /// <summary>
        /// Examines the datastructure List
        /// </summary>
        static void ExamineList()
        {
            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch statement with cases '+' and '-'
             * '+': Add the rest of the input to the list (The user could write +Adam and "Adam" would be added to the list)
             * '-': Remove the rest of the input from the list (The user could write -Adam and "Adam" would be removed from the list)
             * In both cases, look at the count and capacity of the list
             * As a default case, tell them to use only + or -
             * Below you can see some inspirational code to begin working.
            */

            /* Övnining 1
             * 2) Listans kapacitet ökar när du försöker lägga till ett objekt och listans kapacitet
             *    redan är fylld
             * 3) Kapaciteten startar som 4 och dubblas sedan varje gång den fylls
             * 4) För att minska antalet nya arrayer som skapas och tas bort
             * 5) Nej, inte automatiskt.
             * 6) Om du vet storleken från början är det bättre att använda en array. Det kan 
             * också vara bättre med array om du vet maximala tillåtna storleken.
             */

            bool loop = true;
            List<string> theList = new List<string>();
            Console.WriteLine("Add a input to the list by typing +input");
            Console.WriteLine("Remove a input from the list by typing -input");
            Console.WriteLine("Exit back to the main menu by typing 0");
            while (loop)
            {
                string input = Console.ReadLine();
                char nav = input[0];
                string value = input.Substring(1);

                switch (nav)
                {
                    case '+':
                        if (string.IsNullOrEmpty(value.Trim()))
                        {
                            Console.WriteLine("Ange en icke tom input");
                        }
                        else { 
                            theList.Add(value.Trim());
                            Console.WriteLine($"{value} added to the list. " +
                                $"\nThe lists capacity is now: {theList.Capacity} and it contains {theList.Count} elements");
                        }
                        break;

                    case '-':
                        //TODO Kolla att det finns
                        theList.Remove(value);
                        Console.WriteLine($"{value} removed from the list. " +
                            $"\nThe lists capacity is now: {theList.Capacity} and it contains {theList.Count} elements");

                        break;

                    case '0':
                        loop = false;
                        break;
                    default:
                        break;
                }
                foreach (var val in theList)
                {
                    Console.WriteLine(val);
                }
            }
        }

        /// <summary>
        /// Examines the datastructure Queue
        /// </summary>
        static void ExamineQueue()
        {
            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch with cases to enqueue items or dequeue items
             * Make sure to look at the queue after Enqueueing and Dequeueing to see how it behaves
            */
            bool loop = true;
            Queue<string> theQueue = new Queue<string>();
            Console.WriteLine("Add a input to the queue by typing +input");
            Console.WriteLine("Remove the first person from the queue by typing -");
            Console.WriteLine("Exit back to the main menu by typing 0");
            while (loop)
            {
                string input = Console.ReadLine();
                char nav = input[0];
                string value = input.Substring(1);

                switch (nav)
                {
                    case '+':
                        if (string.IsNullOrEmpty(value.Trim()))
                        {
                            Console.WriteLine("Ange en icke tom input");
                        }
                        else
                        {
                            theQueue.Enqueue(value);
                            Console.WriteLine($"{value} added to the list. " +
                                $"\nand it contains {theQueue.Count} elements");
                        }
                        break;

                    case '-':
                        Console.WriteLine($"{theQueue.Dequeue()} removed from the list. " +
                            $"\nThe queue contains {theQueue.Count} elements");

                        break;

                    case '0':
                        loop = false;
                        break;
                    default:
                        break;
                }
                foreach (var val in theQueue)
                {
                    Console.WriteLine(val);
                }
            }
        }

        /// <summary>
        /// Examines the datastructure Stack
        /// </summary>
        static void ExamineStack()
        {
            /*
             * Loop this method until the user inputs something to exit to main menue.
             * Create a switch with cases to push or pop items
             * Make sure to look at the stack after pushing and and poping to see how it behaves
            */

            //Stack kommer inte fungera så bra eftersom den person som lades till först kommer
            //bli den sista att tas bort
            bool loop = true;
            Stack<string> theStack = new Stack<string>();
            Console.WriteLine("Add a input to the stack by typing +input");
            Console.WriteLine("Remove an item from the stack by typing -");
            Console.WriteLine("Exit back to the main menu by typing 0");
            while (loop)
            {
                string input = Console.ReadLine();
                char nav = input[0];
                string value = input.Substring(1);

                switch (nav)
                {
                    case '+':
                        if (string.IsNullOrEmpty(value.Trim()))
                        {
                            Console.WriteLine("Ange en icke tom input");
                        }
                        else
                        {
                            theStack.Push(value);
                            Console.WriteLine($"{value} added to the list. " +
                                $"\nand it contains {theStack.Count} elements");
                        }
                        break;

                    case '-':
                        Console.WriteLine($"{theStack.Pop()} removed from the list. " +
                            $"\nThe queue contains {theStack.Count} elements");

                        break;

                    case '0':
                        loop = false;
                        break;
                    default:
                        break;
                }
                foreach (var val in theStack)
                {
                    Console.WriteLine(val);
                }
            }
        }

        //Jag väljer att använda en stack för den här uppgiften eftersom det är den senaste
        //inmatade parantesen som vi bryr oss om
        static void CheckParanthesis()
        {
            /*
             * Use this method to check if the paranthesis in a string is Correct or incorrect.
             * Example of correct: (()), {}, [({})],  List<int> list = new List<int>() { 1, 2, 3, 4 };
             * Example of incorrect: (()]), [), {[()}],  List<int> list = new List<int>() { 1, 2, 3, 4 );
             */

            Console.WriteLine("Skriv en sträng med paranteser så kommer funktionen visa om den är välformad.");
            string input = Console.ReadLine();
            Stack<char> paranthesis = new Stack<char>();
            bool exitLoop = false;
            foreach(char sign in input)
            {
                switch (sign)
                {
                    case '(':
                    case '{':
                    case '[':
                        paranthesis.Push(sign);
                        break;
                    case ')':
                        if(paranthesis.Count == 0 ||  paranthesis.Peek() != '(')
                        {
                            exitLoop = true;
                        }
                        else
                        {
                            paranthesis.Pop();
                        }
                        break;
                    case '}':
                        if (paranthesis.Count == 0 || paranthesis.Peek() != '{')
                        {
                            exitLoop = true;
                        }
                        else
                        {
                            paranthesis.Pop();
                        }
                        break;
                    case ']':
                        if (paranthesis.Count == 0 || paranthesis.Peek() != '[')
                        {
                            exitLoop = true;
                        }
                        else
                        {
                            paranthesis.Pop();
                        }
                        break;
                    default:
                        break;
                }
                if (exitLoop)
                {
                    break;
                }

            }
            if (exitLoop || paranthesis.Count != 0)
            {
                Console.WriteLine($"\"{input}\" är inte välformad");
            }
            else
            {
                Console.WriteLine($"\"{input}\" är välformad");
            }
        }

        static void CheckRecursion()
        {
            Console.WriteLine("Skriv:" +
                "\n1) för att testa RecursiveOdd" +
                "\n2) för att testa RecursiveEven" +
                "\n3) för att testa Fibonacci");
            char input = ' '; //Creates the character input to be used with the switch-case below.
            try
            {
                input = Console.ReadLine()![0]; //Tries to set input to the first char in an input line
            }
            catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.
            {
                Console.Clear();
                Console.WriteLine("Please enter some input!");
            }
            uint siffra = 0;

            switch (input)
            {
                case '1':
                    Console.WriteLine("Skriv ett nummer:");
                    siffra = checkInt();

                    Console.WriteLine($"RecursiveOdd av {siffra} är {RecursiveOdd(siffra)} ");
                    break;
                case '2':
                    Console.WriteLine("Skriv ett nummer:");
                    siffra = checkInt();

                    Console.WriteLine($"RecursiveEven av {siffra} är {RecursiveEven(siffra)} ");
                    break;
                case '3':
                    Console.WriteLine("Skriv ett nummer:");
                    siffra = checkInt();

                    Console.WriteLine($"Fibonacci av {siffra} är {FibonacciRec(siffra)} ");
                    break;
                default:
                    Console.WriteLine("Please enter some valid input (0, 1, 2, 3)");
                    break;
            }
        }

        static int RecursiveOdd(uint n)
        {
            if (n == 0)
            {
                return 1;
            }

            return (RecursiveOdd(n - 1) + 2);
        }

        static int RecursiveEven(uint n)
        {
            if(n == 0)
            {
                return 2;
            }

            return (RecursiveEven(n-1) + 2);
        }

        static int FibonacciRec(uint n)
        {
            if(n == 1)
            {
                return 1;
            }else if (n == 0)
            {
                return 0;
            }

            return (FibonacciRec(n-1) + FibonacciRec(n-2));
        }

        static void CheckIteration()
        {
            Console.WriteLine("Skriv:" +
                "\n1) för att testa IterativeOdd" +
                "\n2) för att testa IterativeEven" +
                "\n3) för att testa Fibonacci");
            string input = Console.ReadLine(); //Tries to set input to the first char in an input line

            uint siffra;
            switch (input[0])
            {
                case '1':
                    Console.WriteLine("Skriv ett nummer:");
                    siffra = checkInt();

                    Console.WriteLine($"IterativeOdd av {siffra} är {IterativeOdd(siffra)} ");
                    break;
                case '2':
                    Console.WriteLine("Skriv ett nummer:");
                    siffra = checkInt();

                    Console.WriteLine($"IterativeEven av {siffra} är {IterativeEven(siffra)} ");
                    break;
                case '3':
                    Console.WriteLine("Skriv ett nummer:");
                    siffra = checkInt();

                    Console.WriteLine($"Fibonacci av {siffra} är {FibonacciIt(siffra)} ");
                    break;
                default:
                    Console.WriteLine("Please enter some valid input (0, 1, 2, 3)");
                    break;
            }

        }

        static int IterativeOdd(uint n)
        {
            if (n == 0)
            {
                return 1;
            }
            int result = 1;

            for (int i = 1; i <= n; i++)
            {
                result += 2;
            }
            return result;
        }

        static int IterativeEven(uint n)
        {
            if (n == 0)
            {
                return 2;
            }
            int result = 2;

            for (int i = 1; i <= n; i++)
            {
                result += 2;
            }
            return result;
        }

        static int FibonacciIt(uint n)
        {
            if (n == 1)
            {
                return 1;
            }
            int result = 0;

            int minus1 = 1;
            int minus2 = 0;
            for (int i = 2; i <= n; i++)
            {
                result = minus1 + minus2;
                minus2 = minus1;
                minus1 = result;
            }
            return result;
        }


        //Övning 6 Fråga
        //Rekursion använder upp call stacken varje gång den kallar på sig själv så den kommer
        //vara mindre minnesvänlig speciellt om den går många gånger 

        //Hjälpmetod för att kolla att input är en positiv int
        public static uint checkInt()
        {
            do
            {
                var input = Console.ReadLine();
                if (uint.TryParse(input, out uint answer))
                {
                    return answer;
                }
                else
                {
                    Console.WriteLine("Skriv ett positivt nummer");
                }
            } while (true);
        }
    }
}

