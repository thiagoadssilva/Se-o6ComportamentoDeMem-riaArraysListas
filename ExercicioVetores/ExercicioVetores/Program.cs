using System.Globalization;

int quantidade = int.Parse(Console.ReadLine());

double[] vector = new double[quantidade];

for (int i = 0; i < quantidade; i++)
{
    vector[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
}

double sum = 0.0;

for (int i = 0;i < vector.Length; i++)
{
    sum += vector[i];
}

double avg = sum / quantidade;

Console.WriteLine(avg.ToString("F2"), CultureInfo.InvariantCulture);
