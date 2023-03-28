# Resumo dos estudos

A pilha é utilizada para armazenar variáveis locais e informações de controle de fluxo, enquanto o heap é uma área de memória dinâmica utilizada para armazenar objetos complexos alocados durante a execução do programa. A pilha é organizada em uma estrutura LIFO, enquanto o heap é organizado em uma árvore binária.
Em resumo, a principal diferença entre o heap e a pilha é que a pilha é usada para armazenar dados que são usados ​​pelo programa em um determinado momento, enquanto o heap é usado para armazenar objetos mais complexos que precisam de uma alocação mais dinâmica. Além disso, a alocação de memória na pilha é gerenciada automaticamente pelo sistema operacional, enquanto no heap, é responsabilidade do programador alocar e desalocar a memória necessária.
Em C#, o tipo struct é usado para definir estruturas que armazenam um conjunto de valores relacionados. As structs são semelhantes às classes, mas são tipos de valor em vez de tipos de referência. Isso significa que as structs são armazenadas na stack em vez do heap e são copiadas por valor, em vez de por referência.

    public struct Pessoa
    {
        public string nome;
        public int idade;
        public string cidade;
    }

    public class Program
    {
        public static void Main()
        {
            Pessoa p1 = new Pessoa();
            p1.nome = "João";
            p1.idade = 25;
            p1.cidade = "São Paulo";

            Console.WriteLine("Nome: " + p1.nome);
            Console.WriteLine("Idade: " + p1.idade);
            Console.WriteLine("Cidade: " + p1.cidade);
        }
    }
  
Nesse exemplo, a struct Pessoa é definida com três campos públicos: nome, idade e cidade. Em seguida, no método Main, é criada uma instância da struct (p1) e são atribuídos valores aos seus campos. Finalmente, as informações são impressas no console.
O texto discute as principais diferenças entre classes e structs em C#. As classes são tipos de referência, enquanto as structs são tipos de valor. As instâncias de classe são alocadas no heap, enquanto as instâncias de struct são alocadas na stack ou no heap, se estiverem incluídas em um objeto de classe. Copiar uma instância de classe significa copiar uma referência para o objeto original, enquanto copiar uma instância de struct significa criar uma cópia completa da instância, o que pode ser caro em termos de desempenho para structs maiores. As classes têm um comportamento padrão de igualdade por referência, enquanto as structs têm um comportamento padrão de igualdade por valor. As classes suportam herança, enquanto as structs não suportam herança, mas podem implementar interfaces. As classes têm construtores que permitem inicializar campos e executar outras operações, enquanto as 

structs também podem ter construtores, mas com algumas restrições em relação aos construtores de classes. As structs têm um tamanho fixo, determinado pelo tamanho de seus campos, enquanto as classes não têm um tamanho fixo, pois seus campos podem ser referências para outros objetos no heap. As structs podem ser marcadas como "nullable", enquanto as classes são sempre nulas por padrão. É importante considerar cuidadosamente as implicações dessas diferenças ao decidir entre usar uma classe ou uma struct em um projeto.

Tipo de structs

Em C#, existem vários tipos de structs pré-definidos na biblioteca padrão, bem como a capacidade de definir seus próprios tipos de structs personalizados. Aqui estão alguns exemplos de tipos de structs fornecidos pela biblioteca padrão:

Structs numéricas: Int16, Int32, Int64, UInt16, UInt32, UInt64, Single, Double, Decimal
Structs para caracteres: Char
Structs para datas e horas: DateTime, DateTimeOffset, TimeSpan
Structs para matrizes e coleções: Boolean, Byte, SByte, IntPtr, UIntPtr
Structs para cores: Color, Rectangle, Point, Size
Structs para programação paralela: Task, CancellationToken, CancellationTokenSource

Além disso, você pode criar seus próprios tipos de structs personalizados para armazenar dados em uma estrutura mais eficiente em termos de memória e sem os custos adicionais de gerenciamento de memória associados a classes. Isso pode ser particularmente útil para tipos de dados simples que são frequentemente usados e podem ser copiados rapidamente, como coordenadas geográficas, vetores matemáticos e outras estruturas de dados.
Para criar seu próprio tipo de struct personalizado, você pode usar a palavra-chave "struct" seguida pelo nome do seu tipo e as definições de campo. Por exemplo:

  public struct Coordenada {
      public double Latitude;
      public double Longitude;
  }

Neste exemplo, definimos um tipo de struct personalizado chamado "Coordenada" com dois campos, "Latitude" e "Longitude", que podem ser usados para armazenar coordenadas geográficas. Você pode então criar instâncias deste tipo de struct usando a sintaxe usual de inicialização de struct, como:

Coordenada minhaCoordenada = new Coordenada();
minhaCoordenada.Latitude = 40.7128;
minhaCoordenada.Longitude = -74.0060;

Esses são apenas alguns exemplos de tipos de structs em C#. Existem muitos outros tipos de structs disponíveis na biblioteca padrão e você também pode criar seus próprios tipos de structs personalizados para atender às suas necessidades específicas.

Garbage Collector (GC)

O Garbage Collector (GC) é um recurso essencial na plataforma .NET que gerencia a alocação e desalocação de memória para aplicativos em tempo de execução. Ele examina a heap periodicamente para identificar objetos não utilizados e liberar a memória alocada para que possa ser reutilizada por outros objetos. O GC segue um conjunto de regras para determinar quais objetos são elegíveis para coleta de lixo e pode compactar a heap para prevenir fragmentação. Embora a coleta de lixo possa ter um pequeno impacto no desempenho do aplicativo, é 


considerada uma troca valiosa para evitar problemas de gerenciamento manual de memória e garantir que os aplicativos sejam executados de forma eficiente e sem erros.
.
Nullable

O tipo "Nullable" em C# permite que valores nulos sejam atribuídos a tipos de valor, como inteiros, flutuantes e booleanos. Tipos de valor armazenam valores diretamente na memória, enquanto tipos de referência armazenam referências a objetos na memória. Variáveis de tipos de valor devem ter um valor atribuído a elas, mas há momentos em que é necessário uma variável que possa ter um valor nulo, como quando a variável está representando um valor opcional ou pode não ter um valor definido. O tipo "Nullable" adiciona uma camada de abstração ao tipo de valor, permitindo que a variável armazene um valor nulo. A sintaxe "?", após o tipo de valor, cria uma variável nullable. Isso é útil ao trabalhar com APIs que retornam valores opcionais ou nulos. Por exemplo, é possível definir a idade como "int?" ao trabalhar com uma API de terceiros que retorna uma idade como um valor inteiro opcional.

  // Declarando uma variável nullable de inteiro
  int? idade = null;
  // Atribuindo um valor inteiro à variável nullable
  idade = 30;
  // Atribuindo um valor nulo à variável nullable
  idade = null;
  // Verificando se a variável nullable tem um valor nulo
  if (idade == null){
      Console.WriteLine("A idade não foi informada.");
  }else{
      Console.WriteLine("A idade informada é: " + idade);
  }

Nesse exemplo, declaramos uma variável de idade como "int?" para indicar que ela pode ou não ter um valor. Então, atribuímos um valor inteiro à variável e depois a um valor nulo. Por fim, verificamos se a variável tem um valor nulo usando a declaração "if" e imprimimos a idade informada ou uma mensagem indicando que a idade não foi informada, dependendo do valor da variável.

Em C#, os tipos nullable permitem que variáveis de tipos de valor também possam ter valores nulos, além dos seus valores padrão. Para trabalhar com variáveis nullable, existem alguns métodos que podemos utilizar: 

1. HasValue: verifica se a variável nullable possui um valor definido. 
2. Value: retorna o valor da variável nullable. No entanto, se a variável não possuir um valor definido, este método lançará uma exceção. 
3. GetValueOrDefault: retorna o valor da variável nullable ou um valor padrão, caso a variável não possua um valor definido. É possível passar um valor padrão específico como parâmetro deste método. 
4. GetValueOrDefault(T): retorna o valor da variável nullable ou um valor padrão específico do tipo T, caso a variável não possua um valor definido. 
5. ToString: retorna uma representação em string do valor da variável nullable. Caso a variável não possua um valor definido, este método retornará uma string vazia. 



Operador de Coalescência

O operador de coalescência nula (??) em C# é um operador que permite que você defina um valor padrão para ser usado quando uma expressão é nula. Ele é usado para simplificar a lógica de tratamento de valores nulos e para tornar o código mais conciso e legível.
A sintaxe do operador de coalescência nula é "expressão1 ?? expressão2". Se a expressão1 for nula, o valor de expressão2 será retornado; caso contrário, o valor de expressão1 será retornado.
O operador de coalescência nula é útil em situações em que você deseja definir um valor padrão para uma variável ou expressão que pode ser nula. Isso ajuda a simplificar o código e torná-lo mais legível



    int? valorNulo = null;
    int valorPadrao = 10;

    // O operador ?? retorna o valorPadrao, pois valorNulo é nulo
    int resultado1 = valorNulo ?? valorPadrao;

    Console.WriteLine(resultado1); // Saída: 10

    int? valorNaoNulo = 5;

    // O operador ?? retorna o valorNaoNulo, pois ele não é nulo
    int resultado2 = valorNaoNulo ?? valorPadrao;

    Console.WriteLine(resultado2); // Saída: 5

Neste exemplo, definimos uma variável nullable valorNulo que é inicializada como nula, e uma variável valorPadrao que tem um valor padrão de 10. Em seguida, usamos o operador de coalescência nula para definir a variável resultado1 como o valor de valorNulo se ele não for nulo, ou o valor padrão de valorPadrao se valorNulo for nulo.
Em seguida, definimos outra variável nullable valorNaoNulo que tem um valor de 5. Usamos novamente o operador de coalescência nula para definir a variável resultado2 como o valor de valorNaoNulo se ele não for nulo, ou o valor padrão de valorPadrao se valorNaoNulo for nulo.
Por fim, imprimimos os valores das variáveis resultado1 e resultado2.

Vetores - PARTE 1

Em C#, um vetor é uma coleção de elementos do mesmo tipo armazenados contiguamente na memória. Ele é uma estrutura de dados muito útil que permite armazenar e manipular grandes quantidades de dados de forma eficiente.

    tipo[] nomeDoVetor = new tipo[tamanhoDoVetor]; (Aqui, tipo é o tipo de dados dos elementos do vetor, nomeDoVetor é o nome do vetor e tamanhoDoVetor é o número de elementos que o vetor deve conter.)

    int[] numeros = new int[5]; (Neste exemplo, criamos um vetor de inteiros chamado numeros que pode armazenar 5 elementos inteiros.)

Quando digo que os elementos de um vetor em C# são armazenados contiguamente, estou me referindo ao fato de que cada elemento do vetor é armazenado em uma posição de memória única e consecutiva.
Por exemplo, se você criar um vetor de 5 elementos, os valores desses elementos serão armazenados em posições de memória consecutivas. Suponha que você crie um vetor de inteiros chamado numeros com os valores {1, 2, 3, 4, 5}. Isso significa que o primeiro elemento (1) será armazenado na posição de memória x, o segundo elemento (2) será armazenado na posição de memória x + 1, o terceiro elemento (3) será armazenado na posição de memória x + 2 e assim por diante.


O fato de os elementos de um vetor serem armazenados contiguamente é importante porque isso permite que o processador acesse rapidamente qualquer elemento do vetor. Quando você acessa o elemento i do vetor, o processador sabe exatamente em que posição de memória esse elemento está armazenado e pode acessá-lo 

diretamente. Isso é muito mais eficiente do que ter que procurar cada elemento individualmente em uma área de memória maior e desordenada.

Aqui está um exemplo de como criar um vetor de objetos em C# com 3 posições, cada uma contendo o nome e o valor do objeto:

        class Program {
            static void Main(string[] args) {
                // Cria um vetor de objetos com 3 posições
                object[] objetos = new object[3];

                // Define os objetos e seus valores
                objetos[0] = new { Nome = "Objeto1", Valor = 10 };
                objetos[1] = new { Nome = "Objeto2", Valor = 20 };
                objetos[2] = new { Nome = "Objeto3", Valor = 30 };

                // Imprime o nome e valor de cada objeto
                for (int i = 0; i < objetos.Length; i++) {
                    Console.WriteLine("Nome: {0}, Valor: {1}", objetos[i].Nome, objetos[i].Valor);
                }
            }
        }




