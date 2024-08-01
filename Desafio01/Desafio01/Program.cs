
using System.Globalization;

namespace Desafio01;

class Program
{
    static void Main()
    {
        // insertNameAndDisplay();
        // insertNameAndSecondNameAndDisplay();
        // mathOperationsWithTwoNumbers();
        //showCharactersCount();
        //checkIfPlateIsValid();
        getUserDate();
    }


    static void insertNameAndDisplay()
    {
        Console.WriteLine("Digite seu nome: ");
        string? name = Console.ReadLine();
        name = name == "" ? "VAZIO" : name;

        Console.WriteLine($"Olá, {name}! Seja muito bem-vindo!");
    }

    static void insertNameAndSecondNameAndDisplay()
    {
        Console.WriteLine("Digite seu primeiro nome: ");
        string? firstName = Console.ReadLine();
        firstName = firstName == "" ? "VAZIO" : firstName;

        Console.WriteLine("Digite seu sobrenome: ");
        string? secondName = Console.ReadLine();
        secondName = secondName == "" ? "VAZIO" : secondName;

        Console.WriteLine($"Olá, {firstName!.Trim()} {secondName!.Trim()}!");
    }

    static void mathOperationsWithTwoNumbers()
    {
        Console.WriteLine("Digite o primeiro número: ");
        string? firstNumberAsString = Console.ReadLine();
        Console.WriteLine("Digite o segundo número: ");
        string? secondNumberAsString = Console.ReadLine();

        double firstNumber = firstNumberAsString == "" ? 0 : Convert.ToDouble(firstNumberAsString);
        double secondNumber = secondNumberAsString == "" ? 0 : Convert.ToDouble(secondNumberAsString);

        Console.WriteLine($"Soma: {firstNumber + secondNumber}");
        Console.WriteLine($"Subtração: {firstNumber - secondNumber}");
        Console.WriteLine($"Multiplicação: {firstNumber * secondNumber}");
        if (secondNumber <= 0)
        {
            Console.WriteLine("Operação Inválida! Segundo número 0 ou negativo!");
        }
        else
        {
            Console.WriteLine($"Divisão: {firstNumber / secondNumber}");
        }
        Console.WriteLine($"Média: {(firstNumber + secondNumber) / 2}");

    }

    static void showCharactersCount()
    {
        Console.WriteLine("Digite uma ou mais palavras: ");
        string? sentence = Console.ReadLine();
        Console.WriteLine(sentence!.Replace(" ", "").Length);
    }

    static void checkIfPlateIsValid()
    {
        Console.WriteLine("Digite o número da placa: ");
        string? plateNumber = Console.ReadLine();
        bool isPlateValid = false;

        if (plateNumber!.Length == 7)
        {
            bool threeFirstDigitsValid = char.IsLetter(plateNumber[0]) && char.IsLetter(plateNumber[1]) && char.IsLetter(plateNumber[2]);
            bool fourLastDigitsValid = char.IsDigit(plateNumber[3]) && char.IsDigit(plateNumber[4]) && char.IsDigit(plateNumber[5]) && char.IsDigit(plateNumber[6]);
            if(threeFirstDigitsValid && fourLastDigitsValid) {
                isPlateValid = true;    
            }
        }

        if (isPlateValid)
        {
            Console.WriteLine("Placa Válida! VERDADEIRA");

        }
        else
        {
            Console.WriteLine("Placa Inválida! FALSA");
        }

    }

    static void getUserDate()
    {
        DateTime date = DateTime.Now;
        var culturePtBr = new CultureInfo("pt-BR");
        string fullDateAsString = date.ToString("F", culturePtBr);
        string shortDateAsString = date.ToString("dd/MM/yyyy", culturePtBr);
        string onlyTimeAsString = date.ToString("t", culturePtBr);
        string dateWithFullMonthNameAsString = date.ToString("dd MMMM yyyy");
        Console.WriteLine($"{fullDateAsString}");
        Console.WriteLine($"{shortDateAsString}");
        Console.WriteLine($"{onlyTimeAsString}");
        Console.WriteLine($"{dateWithFullMonthNameAsString}");

    }
}