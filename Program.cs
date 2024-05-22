namespace Prog120_S24_L11_Methods3
{
    internal class Program
    {

        string student1 = "Hoang";
        string student2 = "Vicky";

        static string[] firstNames = new string[4];
        static string[] lastNames = new string[4];
        static int[] csiGrades = new int[4];

        // firstNames - Memory Address: 2000
        // type size: 16 | ----- |
        // firstNames[0] : 2000 + (index * Type Size)
        // firstNames[1] : 2000 + (1 * 16)

        // If you define an array with no values, it has default values
        // string:  | "" | "" | "" | "" |
        // int:     | 0 | 0 | 0 | 0 |
        // double:  | 0.0 | 0.0 | 0.0 | 0.0 |
        // bool:    | false | false | false | false |
        // object:  | null | null | null | null |

        static void Main(string[] args)
        {
            // Call my preload method to populate my arrays
            Preload();

            Console.Write("Please enter a last name to search for: ");
            string studentToSearchFor = Console.ReadLine();
            int studentIndex = FindStudentIdByLastName(studentToSearchFor);


            if(studentIndex >= 0)
            {
                DisplayStudentInformation(studentIndex);
            }
            else
            {
                Console.WriteLine("That student is not enrolled in the class");
            }





            //if(EnrolledInClassByLastName(studentToSearchFor))
            //{
            //    Console.WriteLine("Yes, this student is in my class");
            //}
            //else
            //{
            //    Console.WriteLine("The student is not in my class");
            //}

            // .Length gives the size of the array
            //DisplayAllStudents();


        } // main

        // Linear Search

        // Create a method that returns if a student is in the class
        // Return a bool
        public static bool EnrolledInClassByLastName(string studentsLastName) // <--- Search Key
        {
            for (int i = 0; i < lastNames.Length; i++)
            {
                // If the current value == the searchKey
                if (lastNames[i].ToLower() == studentsLastName.ToLower())
                {
                    // 1.
                    return true;
                    // 2.
                }
                // Do i Need an else?
                // 3. Return False
                //return false;
            }
            return false;
            // 4.
        } // EnrolledInClassByLastName

        public static int FindStudentIdByLastName(string studentLastName)
        {
            for (int i = 0; i < lastNames.Length; i++)
            {
                // If the current value == the searchKey
                if (lastNames[i].ToLower() == studentLastName.ToLower())
                {
                    // 1.
                    return i;
                    // 2.
                }
                // Do i Need an else?
                // 3. Return False
                //return false;
            }
            return -1;
        }

        public static void DisplayStudentInformation(int studentIndex)
        {
            // Student ID
            Console.WriteLine($"Student Id: {studentIndex}");
            // Full Name 
            Console.WriteLine($"Full Name: {FullName(studentIndex)}");
            // First Name
            Console.WriteLine($"First Name: {firstNames[studentIndex]}");
            // Last Name
            Console.WriteLine($"Last Name: {lastNames[studentIndex]}");
            // Grades

            Console.WriteLine();
        }

        // Display All Students
        public static void DisplayAllStudents()
        {
            for (int i = 0; i < firstNames.Length; i++)
            {
                //string fullName = FullName(i);
                DisplayStudentInformation(i);
            }
        }

        // New Method : Return a full name
        // Triple Forward slash /// defines a method in intellisense

        /// <summary>
        /// It will return a string of a students full name
        /// </summary>
        /// <param name="studentIndex">Index of Student</param>
        public static string FullName(int studentIndex)
        {

            string firstName = firstNames[studentIndex];
            string lastName = lastNames[studentIndex];
            string fullName = $"{firstName} {lastName}";

            // I am returning the full name of the student out side of our method
            // So can work with it in other methods

            return fullName;

        }

        // Preload()
        public static void Preload()
        {
            firstNames[0] = "Hoang";
            firstNames[1] = "Vicky";
            firstNames[2] = "Brian";
            firstNames[3] = "Carla";

            lastNames[0] = "Nguyen";
            lastNames[1] = "Le";
            lastNames[2] = "Lee";
            lastNames[3] = "Baysinger";
        }


        // Display Full Name Method


        
        // Matrices
        public static void MatrixExample()
        {

            int[,] matrix = new int[2, 2];
            matrix[0, 0] = 1;
            matrix[0, 1] = 2;
            matrix[1, 0] = 3;
            matrix[1, 1] = 4;


            //      0  1
            //  --------------
            // 0 |  1  2
            // 1 |  3  4
        }

        // Switches




        public static void Menu()
        {
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    SwitchExample();
                    break;
                case "2":

                    break;
            }
        }

        public static void SwitchExample()
        {
            // Switch is decision structure that works on comparisons

            // Keywords
            // switch : define our code block
            // case : defines an individual set of instructions
            // break : defines the end of those instructions
            // default : runs if no case runs ( like an else )
            Console.Write("Please enter an animal: ");
            string userAnimal = Console.ReadLine();

            // switch ( case ) <----- Not a condition : "cat == dog" - Don't put this
            switch (userAnimal)
            {
                // create our cases
                // you write case to define a new case followed by value comparing to
                // No curly braces
                // Use a colon, :, instead
                // Followed by break
                // Cases do not have their own scope
                case "dog":
                case "owl":
                    Console.WriteLine("bark");
                    break;
                case "cat":
                    Console.WriteLine("Meow");
                    Console.WriteLine("Purr");
                    break;
                default:
                    Console.WriteLine("Please enter a valid animal");
                    break;
            }

        } // SwitchExample

        // Break Example

        public static void BreakExample()
        {
            // New Keyword
            // break
            // Break indicates that we want to jump OUT of the current code block
            for (int i = 0; i < 10000000; i++)
            {
                if (i % 57 == 0)
                {
                    Console.WriteLine(i);
                    // Once break is triggered
                    // It will jump out of our for loop
                    break;
                }
            }
        }


    } // class

} // namespace


// Switches

// Parallel Arrays

// Linear Search