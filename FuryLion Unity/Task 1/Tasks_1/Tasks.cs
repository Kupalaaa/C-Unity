namespace Tasks_1;

public  class Tasks
{ //Task3 Method
    public int Factorial(int a)
    {
        var result = 1;
        var i = 1;
        while (i <= a)
        {
            result *= i;
            i++;
        }

        return result;
    }
    public void Task_1()
    {
        var input = Console.ReadLine().Split(' ').Select(int.Parse).OrderByDescending(x => x);
        Console.WriteLine(string.Join(", ", input));
    }

    public void Task_2()
    {
        var input = Console.ReadLine();
        foreach (var ch in input.Where(x => char.IsNumber(x)).Reverse())
        {
            Console.Write(ch);
        }
    }
    public void Task_3()
    {
        var a = Int32.Parse(Console.ReadLine());
        Console.WriteLine(Factorial(a));
    }
    public void Task_4()
    {
        var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        var result = input[0];
        for (int i = 1; i < input[1]; i++)
        {
            input[0] += input[2];
            result += input[0];
        }
        Console.WriteLine(result);
    }
    public void Task_5()
    {
        var x = Int32.Parse(Console.ReadLine());
        for (int i = 0; i <= x; i++)
        {
            if ( i % 2 == 0)
            {
                Console.Write($"{i}, ");
            }
        }
    }
    public void Task_6()
    {
        
    }
    public void Task_7()
    {
        
    }
    public void Task_8()
    {
        
    }
    public void Task_9()
    {
        
    }
    public void Task_10()
    {
        
    }
    public void Task_11()
    {
        
    }
}