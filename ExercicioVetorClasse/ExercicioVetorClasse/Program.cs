using ExercicioVetorClasse;
using System.Globalization;

Console.WriteLine("Informa a quantidade que o array de produtos vai ter");
int amount = int.Parse(Console.ReadLine());
Product[] products = new Product[amount];

for (int i = 0; i < products.Length; i++)
{
    Console.WriteLine("Informe o nome do produto");
    string name = Console.ReadLine();
    Console.WriteLine("Informe o preço do produto");
    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    
    products[i] = new Product(name, price);
}

double sum = 0.0;
for (int i = 0;i < products.Length; i++)
{
    sum += products[i].Price;
}

double avgProduct = sum / products.Length;

Console.WriteLine("Média: " +  avgProduct.ToString("F2"), CultureInfo.InvariantCulture);

