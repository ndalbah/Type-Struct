using System;
namespace prjConCsTypeStruct
{
	public static class StructureExercices
	{
        // declare the structure as global for all functions in this class
        struct Student
        {
            public string Name;
            public Int32 YearBorn;
            public Single Grade;
        }

        public static void Exercice1()
		{
            // lets declare variables and arrays
            Int32 nbStud;
            Student[] tabStuds = new Student[25];
            Single maxGrade, minGrade;
            string search;
            

            // Display Title
            Console.WriteLine("\tLASALLE COLLEGE");
            Console.WriteLine("\t- - - - - - - -");

            // Read Number of students
            do
            {
                Console.Write("Enter the number of students: ");
                nbStud = Convert.ToInt16(Console.ReadLine());
            } while (!(nbStud >= 2 && nbStud <= 25));

            for(int i = 0; i < nbStud; i++)
            {
                Console.WriteLine("\nStudent " + (i + 1));

                do
                {
                    Console.Write("    Name: ");
                    tabStuds[i].Name = Console.ReadLine();
                } while (tabStuds[i].Name == "");

                do
                {
                    Console.Write("    Year of Birth: ");
                    tabStuds[i].YearBorn = Convert.ToInt32(Console.ReadLine());
                } while (tabStuds[i].YearBorn > 2007 || tabStuds[i].YearBorn < 1955);

                do
                {
                    Console.Write("    Grade: ");
                    tabStuds[i].Grade = Convert.ToSingle(Console.ReadLine());
                } while (!(tabStuds[i].Grade >= 0 && tabStuds[i].Grade <= 100));
                

            }

            // initialize the max and min with the value of the first grade
            maxGrade = minGrade = tabStuds[0].Grade;

            Console.WriteLine("\nThe class");
            Console.WriteLine("Students\tYears\tAges\tGrades\tResults");
            Console.WriteLine("--------\t-----\t----\t------\t-------");

            // Display all infos about students
            for (int i = 0; i < nbStud; i++)
            {
                int age = DateTime.Today.Year - tabStuds[i].YearBorn;

                string result = tabStuds[i].Grade >= 60 ? "Pass" : "Fail";

                //if (tabStuds[i].Grade >= 60)
                //{
                //    result = "Pass";
                //}
                //else
                //{
                //    result = "Fail";
                //}

                Console.WriteLine(tabStuds[i].Name + "\t" + tabStuds[i].YearBorn + "\t" + age + "\t" + tabStuds[i].Grade + "\t" + result);

                // find max and min grade
                if (tabStuds[i].Grade > maxGrade)
                {
                    maxGrade = tabStuds[i].Grade;
                }
                if (tabStuds[i].Grade < minGrade)
                {
                    minGrade = tabStuds[i].Grade;
                }
            }

            Console.WriteLine("\nThe Best Students");
            for(int i = 0; i < nbStud; i++)
            {
                if (tabStuds[i].Grade == maxGrade)
                {
                    Console.WriteLine(tabStuds[i].Name + "\t" + tabStuds[i].Grade);
                }
            }

            Console.WriteLine("\nThe Worst Students");
            for(int i = 0; i < nbStud; i++)
            {
                if (tabStuds[i].Grade == minGrade)
                {
                    Console.WriteLine(tabStuds[i].Name + "\t" + tabStuds[i].Grade);
                }
            }

            //// Display best students
            //for(int i = 0; i < nbStud; i++)
            //{
            //    if (tabStuds[i].Grade > best)
            //    {
            //        best = tabStuds[i].Grade;
            //    }
            //    if (tabStuds[i].Grade < worst)
            //    {
            //        worst = tabStuds[i].Grade;
            //    }
            //}

            //Console.WriteLine("\nThe best students: ");
            //for(int i = 0; i < nbStud; i++)
            //{
            //    if (tabStuds[i].Grade == best)
            //    {
            //        Console.WriteLine(tabStuds[i].Name + "\t" + tabStuds[i].Grade);
            //    }
            //}

            //// Display worst students
            //Console.WriteLine("\nThe worst students:");
            //for(int i = 0; i < nbStud; i++)
            //{
            //    if (tabStuds[i].Grade == worst)
            //    {
            //        Console.WriteLine(tabStuds[i].Name + "\t" + tabStuds[i].Grade);
            //    }
            //}

            // Find by result
            Console.Write("\nEnter the result to find: ");
            search = Console.ReadLine();

            for (int i = 0; i < nbStud; i++)
            {
                string result = tabStuds[i].Grade >= 60 ? "Pass" : "Fail";
                if (result == search)
                {
                    Console.WriteLine(tabStuds[i].Name + "\t" + tabStuds[i].Grade);
                }
            }
        }
	}
}

