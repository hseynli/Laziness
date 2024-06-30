RunExample();

Console.WriteLine("\nDone!");

void RunExample()
{
    // Lazy<T> is a generic type that we have in C#
    // that allows us to defer the creation of a value.
    // It also acts like a singleton, without being
    // global. It's a thread-safe way to create a value
    // only when it's needed.

    Lazy<int> lazyValue = new Lazy<int>(() =>
    {
        Console.WriteLine("This will only run once.");
        Console.WriteLine("Finding the max...");
        int[] numbers = [35, 20, 30, 40, 50];

        int max = int.MinValue;
        foreach (var number in numbers)
        {
            if (number > max)
                max = number;

            // pretend this is an expensive operation
            Thread.Sleep(1000);
        }

        Console.WriteLine("The max value is: " + max);
        return max;
    }, LazyThreadSafetyMode.PublicationOnly);

    Console.WriteLine("The value of lazyValue is: " + lazyValue.Value);
    Console.WriteLine("The value of lazyValue is: " + lazyValue.Value);
    Console.WriteLine("The value of lazyValue is: " + lazyValue.Value);
    Console.WriteLine("The value of lazyValue is: " + lazyValue.Value);
    Console.WriteLine("The value of lazyValue is: " + lazyValue.Value);
}