using System;

//Frågor
//1) 
//2)
//3) För att den första använder sig av int som är en value type och den andra använder MyInt som är en referencetype
//och ...

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
                Console.WriteLine("Please navigate through the menu by inputting the number \n(1, 2, 3 ,4, 0) of your choice"
                    + "\n1. Examine a List"
                    + "\n2. Examine a Queue"
                    + "\n3. Examine a Stack"
                    + "\n4. CheckParanthesis"
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
                    /*
                     * Extend the menu to include the recursive 
                     * and iterative exercises.
                     */
                    case '0':
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please enter some valid input (0, 1, 2, 3, 4)");
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
             * 4) 
             * 5) Nej, det gör den inte
             * 6) 
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
                        //theQueue.Dequeue();
                        //theList.Remove(value);
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

    }
}

