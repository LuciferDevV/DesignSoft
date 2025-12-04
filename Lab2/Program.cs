Console.WriteLine("Hello, Jerry!");

for (int i = 0; i < 3; i++)
{
    Console.WriteLine("A");
    Console.WriteLine("B");
    Console.WriteLine("C");
    Thread.Sleep(500);
}

A();
A();
A();
A();
A();

void functionA()
{
    Console.WriteLine("Функция A выполняется");
    B();
    C();
}

void functionB()
{
    Console.WriteLine("Функция B выполняется");
}

void functionC()
{
    Console.WriteLine("Функция C выполняется");
}
