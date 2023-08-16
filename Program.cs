using System;

public class Class1
{
    public class Calculate
    {
        public int a, b;
        public int calculator(int a, int b)
        {
            return a + b;
        }
    }
    public class person
    {
        public string name;
        public int age;
        public string sex; 
    }
    public struct personofstudent
    {
        public string name;
        public string group;
        public string sex;
    }
    static void Main(string[] args)
    {
        //Example a simple types of varible
        int a = 18;
        double b = 5.5;
        bool c = true;
        char d = '?';
        //Example work with class
        person TypicalTaHkucT = new person();
        TypicalTaHkucT.name = "Vova";
        TypicalTaHkucT.age = a;
        TypicalTaHkucT.sex = "Man";
        Console.WriteLine(TypicalTaHkucT.name + " " + TypicalTaHkucT.age + " " + TypicalTaHkucT.sex);
        //Example work with structur
        personofstudent student = new personofstudent();
        student.name = "Angela";
        student.group = "PIN-221";
        student.sex = "Woman";
        Console.WriteLine(student.name + " " + student.group + " " + student.sex);
        string[] strings;
        //Example work with calculate class
        Calculate calculate = new Calculate();
        try
        {
            calculate.a = Convert.ToInt32(Console.ReadLine());
            calculate.b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(calculate.calculator(calculate.a, calculate.b));
        }
        catch
        {
            Console.WriteLine("you are wrong");
        }
        //Example work with arrays and lists
        int[] arr = new int[10];
        for (int i = 0; i < 10; i++) arr[i] = i;
        Console.WriteLine("\nwork with arrays\n");
        for (int i = 0; i < 10; i++) Console.WriteLine(arr[i]);
        List<string> spisok = new List<string>();
        spisok.Add("LoverOfBeer");
        foreach (var item in spisok) Console.WriteLine(item);
        string user = Console.ReadLine();
        spisok.Add(user);
        int length = Convert.ToInt32(user.Length);
        spisok.Add(Convert.ToString(length));
        Console.WriteLine("\nChanged list: \n");
        foreach (var item in spisok) Console.WriteLine(item);
    }
}