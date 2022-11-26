Console.WriteLine("Task 1:");
task1();

Console.WriteLine("\nTask 2:");
task2();

Console.WriteLine("\nTask 3:");
task3();

Console.WriteLine("\nTask 4:");
task4();

Console.WriteLine("\nTask 5:");
task5();

Console.ReadKey();

// MARK: - Tasks

void task1()
{
    int a = Int32.Parse(Console.ReadLine());
    int b = Int32.Parse(Console.ReadLine());

    var result = a > b ? a : b;
    Console.WriteLine($"max = {result.ToString()}");
}

void task2()
{
    int a = Int32.Parse(Console.ReadLine());
    int b = Int32.Parse(Console.ReadLine());
    int c = Int32.Parse(Console.ReadLine());

    var block1 = a > b ? a : b;
    var result = block1 > c ? block1 : c;

    Console.WriteLine($"max = {result.ToString()}");
}

void task3()
{
    int a = Int32.Parse(Console.ReadLine());
    var result = a % 2 == 0 ? "четное" : "нечетное";
    Console.WriteLine($"Число {a} {result}");
}

void task4()
{
    int n = Int32.Parse(Console.ReadLine());

    if (n < 1)
    {
        Console.WriteLine("n должно быть больше 1");
        return;
    }

    for (int i = 1; i < n; i++)
    {
        if (i % 2 == 0)
        {
            Console.Write($"{i.ToString()} ");
        }
    }
}

void task5()
{
    int value = Int32.Parse(Console.ReadLine());

    if ((value < 100) && (value < 0 && value > -100))
    {
        Console.WriteLine("Такой цифры нет");
        return;
    }

    int result;
    var temp = System.Math.Abs(value);

    do
    {
        result = temp % 10;
        temp = temp / 10;
    } while (temp > 99);

    Console.WriteLine($"Третья цифра слева числа {value} = {result}");
}