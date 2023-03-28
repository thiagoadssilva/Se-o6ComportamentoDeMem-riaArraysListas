using ExercicioFixacaoVetor01;

Student[] students = new Student[10]; // Array com a quantidade de reservas

Console.Write("Informe a quantidade de reserva para os quartos: ");
int reserve = int.Parse(Console.ReadLine());

for (int i = 0; i <= reserve; i++)
{
    Console.WriteLine("");
    Console.WriteLine("Reserva #" + i);
    Console.WriteLine("--------------");

    Console.Write("Informe seu nome:");
    string name = Console.ReadLine();
    
    Console.Write("Informe seu email:");
    string email = Console.ReadLine();
    
    Console.Write("Informe o numero do quarto:");
    int roomNumber = int.Parse(Console.ReadLine());

    students[roomNumber] = new Student(name, email);

}

Console.WriteLine();
Console.WriteLine("Quartos Alugados:");

for (int i = 0; i < students.Length; i++)
{
    if (students[i] != null)
    {
        Console.WriteLine(i + ":" + students[i]);   
    }
}
