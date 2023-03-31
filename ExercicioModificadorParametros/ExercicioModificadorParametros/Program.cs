using ExercicioModificadorParametros;


int a = Calculator.sum(1,2,3);
int b = Calculator.sum(1, 2, 3, 4, 5);

int c = 2; // 4
Calculator.multRef(ref c);

int d;
Calculator.multOut(out d);

Console.WriteLine(a);
Console.WriteLine(b);
Console.WriteLine(c);
Console.WriteLine(d);