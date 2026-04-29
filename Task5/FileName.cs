StudentList list = new StudentList();
bool isRunning = true;

while (isRunning)
{
    Console.WriteLine("\n1. Add student");
    Console.WriteLine("2. Find by ID");
    Console.WriteLine("3. Find by name");
    Console.WriteLine("4. Top N students");
    Console.WriteLine("5. Show all");
    Console.WriteLine("6. Exit");
    Console.Write("Choice: ");

    string input = Console.ReadLine();

    if (input == "1")
    {
        Console.Write("Full name: ");
        string fullName = Console.ReadLine();

        Console.Write("Group: ");
        string group = Console.ReadLine();

        Console.Write("GPA (0.0 - 4.0): ");
        double gpa = double.Parse(Console.ReadLine());

        if (gpa < 0.0 || gpa > 4.0)
        {
            Console.WriteLine("Invalid GPA.");
        }
        else
        {
            list.AddStudent(new Student(fullName, group, gpa));
            Console.WriteLine("Student added.");
        }
    }
    else if (input == "2")
    {
        Console.Write("Enter ID: ");
        int id = int.Parse(Console.ReadLine());

        Student s = list.FindById(id);
        if (s == null)
            Console.WriteLine("Not found.");
        else
            Console.WriteLine(s.GetInfo());
    }
    else if (input == "3")
    {
        Console.Write("Enter name: ");
        string name = Console.ReadLine();

        Student[] found = list.FindByName(name);
        if (found.Length == 0)
            Console.WriteLine("Not found.");
        else
            foreach (Student s in found)
                Console.WriteLine(s.GetInfo());
    }
    else if (input == "4")
    {
        Console.Write("Enter N: ");
        int n = int.Parse(Console.ReadLine());

        Student[] top = list.GetTop(n);
        for (int i = 0; i < top.Length; i++)
            Console.WriteLine($"#{i + 1} {top[i].GetInfo()}");
    }
    else if (input == "5")
    {
        list.ShowAll();
    }
    else if (input == "6")
    {
        isRunning = false;
    }
    else
    {
        Console.WriteLine("Invalid input.");
    }
}

class Student
{
    private static int _counter = 1;
    private double _gpa;

    public int Id { get; }
    public string FullName { get; set; }
    public string Faculty { get; set; }

    public double GPA
    {
        get => _gpa;
        set
        {
            if (value < 0.0 || value > 4.0)
                throw new ArgumentException("GPA must be between 0.0 and 4.0");
            _gpa = value;
        }
    }

    public Student(string fullName, string faculty, double gpa)
    {
        Id = _counter++;
        FullName = fullName;
        Faculty = faculty;
        GPA = gpa;
    }

    public string GetInfo()
    {
        return $"ID: {Id} | {FullName} | {Faculty} | GPA: {GPA:F2}";
    }
}

class StudentList
{
    private Student[] _data = new Student[100];
    private int _size = 0;

    public void AddStudent(Student student)
    {
        if (_size >= 100)
        {
            Console.WriteLine("List is full.");
            return;
        }
        _data[_size++] = student;
    }

    public Student FindById(int id)
    {
        for (int i = 0; i < _size; i++)
            if (_data[i].Id == id)
                return _data[i];
        return null;
    }

    public Student[] FindByName(string name)
    {
        int count = 0;
        for (int i = 0; i < _size; i++)
            if (_data[i].FullName.ToLower().Contains(name.ToLower()))
                count++;

        Student[] result = new Student[count];
        int idx = 0;
        for (int i = 0; i < _size; i++)
            if (_data[i].FullName.ToLower().Contains(name.ToLower()))
                result[idx++] = _data[i];

        return result;
    }

    public Student[] GetTop(int n)
    {
        Student[] sorted = new Student[_size];
        for (int i = 0; i < _size; i++)
            sorted[i] = _data[i];

        for (int i = 0; i < sorted.Length - 1; i++)
            for (int j = 0; j < sorted.Length - 1 - i; j++)
                if (sorted[j].GPA < sorted[j + 1].GPA)
                    (sorted[j], sorted[j + 1]) = (sorted[j + 1], sorted[j]);

        int take = Math.Min(n, _size);
        Student[] top = new Student[take];
        for (int i = 0; i < take; i++)
            top[i] = sorted[i];

        return top;
    }

    public void ShowAll()
    {
        if (_size == 0)
        {
            Console.WriteLine("List is empty.");
            return;
        }
        for (int i = 0; i < _size; i++)
            Console.WriteLine(_data[i].GetInfo());
    }
}