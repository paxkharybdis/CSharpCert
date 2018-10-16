using System;
using Week1.W1_Homework.csharpcertw1hmwk;
using Week1.Week2;
using Week1.Week2.week2homework;
using Week1.Fundamentals;
using Fundamentals;
using Advanced;
using System.Threading;
using System.Threading.Tasks;
using System.Linq;
using System.Collections.Generic;

namespace Week1
{
    class Program
    {
        public delegate void TryOn(string type);

        static void Main(string[] args)
        {

            // DelegateSample();
            // MultiDelegateSample();
            // EventSample();
            // ExceptionSample();
            // CollectionExamples();
            // ThreadingSample();
            MyAsyncExample();

            #region

            /*
             * do
            {
                string menuInput;

                // Present menu.
                Console.WriteLine("================================================");
                Console.WriteLine("Which C# code example would you like to execute?");
                Console.WriteLine("Week 1: Basic Class Functions.  (1)");
                Console.WriteLine("Week 2: Counting To Ten.        (2)");
                Console.WriteLine("Week 2: Display Grades.         (3)");
                Console.WriteLine("Week 3: Virtual Bicycle Shop    (4)");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("================================================");

                menuInput = Console.ReadLine();

                // 
                switch (menuInput)
                {
                    case "1":
                        Console.WriteLine("Basic Class Functions.");
                        Bicycle bicycle = new Bicycle();
                        bicycle.showAll();
                        break;
                    case "2":
                        Console.WriteLine("Count To Ten");
                        CountToTen counting = new CountToTen();
                        counting.Counting();
                        break;
                    case "3":
                        Console.WriteLine("The Great Grade Displayer!!");
                        gradeswitch gradeswitch = new gradeswitch();
                        gradeswitch.gradeMenu();
                        break;
                    case "4":
                        Console.WriteLine("Loading Virtual Bicycle Shop");
                        bicycle2 bicycle2 = new bicycle2();
                        bicycle2.bikeMenu();
                        break;
                    case "5":

                        break;
                }





            } while (true);

            dinosaur dino1 = new dinosaur(); // Class instantiation
            dino1.Size = 10;
            dino1.Eat(); // Dinosaur Eat

            TRex TRex = new TRex(); // Class instantiation
            TRex.Size = 20;
            TRex.Eat();  // TRex Eat

            dinosaur dino2 = new TRex();  // Upcasting (implicitly)
            dino2.Eat(); //TRrex Eat

            dinosaur dino3 = new Pterodactyl();  // Upcasting (implicitly)
            dino3.Eat(); // Pteradactyl Eat

            dinosaur dino4 = new dinosaur(); // Downcasting (explicitly)
            dino4 = (TRex)TRex;
            dino4.Eat(); // TRex Eat
            dino4 = (Pterodactyl)dino3;
            dino4.Eat();  // Pterodactyl Eat

            dinosaur dino6 = dino3 as Pterodactyl;
            dino6.Sleep();
            

            dinosaur[] dinoArray = {dino1, dino2, TRex, dino3};

            foreach (dinosaur item in dinoArray)
            {
                if(item is TRex) {
                    item.Eat();
                }
                if(item is Pterodactyl) {
                    item.Sleep();
                }
            }

            Console.WriteLine (Utility.AddTwoNumbersSortOf(5,10));  //Calling static method utility directly, does not create an instance.
            

            Square mySquare = new Square(3, 3);

            //int length, height;
            var (length, height) = mySquare;

            // The below statement does the same thing as the VAR statement above.
            // mySquare.Deconstruct(out length, out height);

            Console.WriteLine(mySquare.Length);
            Console.WriteLine(length);

            Square yourSquare = new Square{Length = 5, Height = 5, Color = "Blue"};

            Square happySquare = new Square{ Color = "Brown"};
            
            Square square = new Square(5,5);
            square.Sides = 4;

            GenericsList<dinosaur> dinoList = new GenericsList<dinosaur>();
            dinoList.Add(dino1);
            dinoList.Add(TRex);
            dinoList.Add(dino2);
            dinoList.Add(dino3);

            

            */
            #endregion
        }

        private static void MyLinqExample()
        {
            string[] names = { "Tom", "Don", "Harry", "Mary", "Jay" };

            IEnumerable<string> query = names
                .Where(n => n.Contains("a"))
                .OrderBy(n => n.Length)
                .Select(n => n.ToUpper());

            foreach (string name in query) Console.WriteLine(name);
        }

        private async static void MyAsyncExample()
        {
            AsyncUtility myUtility = new AsyncUtility();
            string myWord = await myUtility.BottlesOfBeerSongAsync();
            Console.WriteLine(myWord);
        }

        private static void SimpleTaskExample()
        {
            Thread.CurrentThread.Name = "Main";

            // Create a task and supply a user delegate by using a lambda expression
            Task task = new Task(() => Console.WriteLine("Hello from task."));
            // Define a run with a Task
            // Task task = Task.run(() => Console.WriteLine("Hello from task."));

            // Start the task
            task.Start();
            // Output a message from the calling thread.
            Console.WriteLine("Hello from thread '{0}'.", Thread.CurrentThread.Name);
            task.Wait();
        }

        private static void ThreadingSample2()
        {
            ThreadingExample myExample = new ThreadingExample();
            Thread thread = new Thread(() => myExample.SimpleMethod(100));
            thread.Start();
        }

        private static void ThreadingSample()
        {
            Thread thread = new Thread(OldFundamentals);
            thread.Start();

            MultiDelegateSample();
        }

        private static void CollectionExamples()
        {
            CollectionExamples mySample = new CollectionExamples();

            mySample.MyArrayListExample();
        }

        private static void ExceptionSample()
        {
            ExceptionExamples examples = new ExceptionExamples();
            //examples.MyException();
            // examples.MySecondExample();
            examples.MyThirdExample();
        }

        private static void LambdaSample()
        {
            LambdaExamples myLamb = new LambdaExamples();
            myLamb.MyLambdaOne(myLamb.MyLambdaOne(5));

            LambdaExamples mySecond = new LambdaExamples(23);
            Console.WriteLine(mySecond.MyLambdaOne(mySecond.MyValue));
        }

        private static void EventSample()
        {
            Coats myCoat = new Coats(); // instantiate the class
            string result = myCoat.MyResult; // Get result from property
            Console.WriteLine(result);
        }

        private static void DelegateSample()
        {
            Hats myHat = new Hats("Cowboy", 7);
            TryOn theHat = myHat.TryOnHat;
            theHat("I tried on a " + myHat.HatType + "hat that was size " + myHat.HatSize);

            Hats mySecond = new Hats();
        }

        private static void MultiDelegateSample()
        {
            Hats moreHats = new Hats(7);
            TryOn someHats, niceHat, sadHat;

            niceHat = moreHats.FindLuckHat;
            niceHat("Top");

            sadHat = moreHats.FindUglyHat;
            sadHat("Dunce");

            someHats = niceHat + sadHat;
            someHats("Cowboy");
        }
    }
}
