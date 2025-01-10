namespace Assignment_OOP_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //Person[] person = new Person[3];
            //person[0] = new Person("Ali", 16);
            //person[1] = new Person("Mohamed", 21);
            //person[2] = new Person("Omar", 19);

            //for (int i = 0; i < person.Length; i++)
            //{
            //    Console.Write($"Person Id: {i+1}, ");
            //    Console.WriteLine(person[i]);
            //}
            #endregion

            #region Q2
            //double a, b;
            //Point p1, p2;
            //Console.WriteLine("Please enter 1st point coordinates");

            //do { Console.Write("X:"); }
            //while (!double.TryParse(Console.ReadLine(), out a));
            //do { Console.Write("Y:"); }
            //while (!double.TryParse(Console.ReadLine(), out b)) ;
            //p1 = new Point(a,b);

            //Console.WriteLine("Please enter 2nd point coordinates");
            //do { Console.Write("X:"); }
            //while (!double.TryParse(Console.ReadLine(), out a));
            //do { Console.Write("Y:"); }
            //while (!double.TryParse(Console.ReadLine(), out b));
            //p2 = new Point(a,b);

            //double d = double.Sqrt(double.Pow(p1.Y - p2.Y, 2) + double.Pow(p1.X - p2.X, 2));
            //Console.WriteLine($"The Distance between the 2 points = {d:f}");
            #endregion

            #region Q3
            //Person[] person = new Person[3];
            //string? name = null;
            //int age, maxAgeIndex=0;
            //for(int i = 0; i < person.Length; i++)
            //{
            //    Console.WriteLine($"Please enter User ({i + 1}) Data:");

            //    while(name == null)
            //    {
            //        Console.Write("Name:");
            //        name = Console.ReadLine();
            //    }
            //    do
            //    {
            //        Console.Write("Age:");
            //    }
            //    while (!int.TryParse(Console.ReadLine(),out age));

            //    person[i] = new Person(name, age);
            //    if (person[i].Age > person[maxAgeIndex].Age) maxAgeIndex = i; 
            //}
            //Console.WriteLine("Data of Olderst Perseon:");
            //Console.WriteLine(person[maxAgeIndex]);
            #endregion

            #region Q4
            //Rectangle rec = new(3, 4);
            //rec.DisplayInfo();
            #endregion
        }
    }
}
