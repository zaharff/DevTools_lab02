using Wintellect.PowerCollections;

Wintellect.PowerCollections.Stack<int> stack = new();

Console.WriteLine("Размер стека:" + stack.Lenght);

stack.Push(10);
stack.Push(9);

Console.WriteLine($"Результат {stack.Peek()}");