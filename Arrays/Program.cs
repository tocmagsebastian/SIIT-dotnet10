namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declare new array
            int[] myArray = new int[3]; //size of the array 
            myArray[0] = 35;
            myArray[1] = -10;
            myArray[2] = 500;
            //myArray[3] = 625; this will throw exception

            string[] daysOfTheWeek = { "Luni", "Marti", "Miercuri", "Joi", "Vineri" }; //repezentare inline

            // accessing elements from an array
            string[] reversedDays = new string[6];

            for (int i = 0; i < daysOfTheWeek.Length; i++)
            {
                reversedDays[daysOfTheWeek.Length - 1 - i] = daysOfTheWeek[i];
            }
            Console.WriteLine(reversedDays[0]);

            // printing an array
            Console.WriteLine(daysOfTheWeek); // doesn't print the elements: System.String[]

            // for loop
            for (int i = 1; i < daysOfTheWeek.Length; ++i)
            {
                Console.WriteLine(daysOfTheWeek[i]);
                
            }

            // foreach
            foreach (string item in daysOfTheWeek)
            {
                Console.WriteLine(item);
            }

            // while
            int index = 0;
            while (index < daysOfTheWeek.Length )
            {
                //Console.WriteLine(daysOfTheWeek[index]);
                index++;
            }

            index = 0;
            do
            {
                //Console.WriteLine(daysOfTheWeek[index]);
                index++;
            } while (index < daysOfTheWeek.Length);

            // Reading array from Console

            //Console.WriteLine("Please give an array size:");
            //int arraySize = int.Parse(Console.ReadLine());

            //int[] myArrayFromConsole = new int[arraySize];

            //Console.WriteLine("Please input the values of the array:");
            //for (int i = 0;i < arraySize;i++)
            //{
            //    myArrayFromConsole[i] = int.Parse(Console.ReadLine());
            //}

            // Coping an array
            string[] myArrayCopy = daysOfTheWeek; // but this change the value of the copied array if we give a new value to
                                                  // the myArrayCopy index
            myArrayCopy[0] = "alabala";
            Console.WriteLine(myArrayCopy[0]);
            Console.WriteLine(daysOfTheWeek[0]);

            // this method dosen't change the values
            string[] myArrayClone = (string[]) daysOfTheWeek.Clone();
            myArrayClone[0] = "Duminica";
            Console.WriteLine(myArrayClone[0]);
            Console.WriteLine(daysOfTheWeek[0]);

            // resize the array

            int[] intArray = new int[5];
            int[] copyArray = intArray; // create backup

            intArray = new int[6];

            for (int i = 0; i < 5; i++) 
            {
                intArray[i] = copyArray[i];
            }

            intArray[5] = 10;

            // declare and create matrix

            int[] array = { 1, 2 };
            array[0] = 1;

            int[,] myMatrix = {
                { 1, 2 },
                { 2, 3 },
            };

            int[,] myMatrix2 = new int[2, 2];
            myMatrix2[0, 0] = 1;
            myMatrix2[0, 1] = 5;

            // Printing a matrix
            // Console.WriteLine(myMatrix); // this print System.Int32[,]

            for (int row = 0; row < myMatrix.GetLength(0); row++)
            {
                for (int col = 0; col < myMatrix.GetLength(1); col++)
                {
                    Console.Write(myMatrix[row, col]);
                    Console.Write(", ");
                }

                Console.WriteLine();
            }

            //Jagged arrays
             int[][] jagged = new int[3][];

            // { [1, 3, 5], [87, 4324, 33234], [32, 42, 42123]}

            // Properties of Class Array
            string[] capitals = { "Sofia", "Washington", "Londra", "Paris" };

            Console.WriteLine($"Lungimea arrayului este: {capitals.Length}");
            Console.WriteLine($"Lungimea de dimensiuni al arrayului este: {capitals.Rank}");
            Console.WriteLine($"Lungimea de dimensiuni al arrayului este: {myMatrix2.Rank}");

            Console.WriteLine($"Pozitia orasului Londra este {Array.IndexOf(capitals, "Londra")}");
            Console.WriteLine($"La pozitia 2 se afla orasul {capitals[2]}.");

            //array.Reverse()
            var reversed = capitals.Reverse();
            foreach(var city in capitals)
            {
                Console.WriteLine(city);
            }

        }
    }
}
