Console.WriteLine("Witaj w programie liczącym BMI");
double weight;
double height;

Console.WriteLine("Podaj swoją wagę w kg");
weight = double.Parse(Console.ReadLine());
Console.WriteLine("Podaj swój wzrost w m");


height = double.Parse(Console.ReadLine());
double bmi = weight / (height * height);
Console.WriteLine($"Twoja waga to {weight} a wzrost to {height}");

switch (bmi)
{
    case < 18.5:
        Console.WriteLine($"Twój BMI wynosi {bmi} masz niedowagę");
        break;

        case >=18.5 and <=24.9:
            Console.WriteLine($"Twój BMI wynosi {bmi} twoja waga jest w normie");
        break;

    case >= 25 and <= 29.9:
        Console.WriteLine($"Twój BMI wynosi {bmi} masz nadwagę");
        break;

    case >= 30 and <= 34.9:
        Console.WriteLine($"Twój BMI wynosi {bmi} masz otyłość");
        break;
    case > 35:
        Console.WriteLine($"Twój BMI wynosi {bmi} masz otyłość olbrzymią");
        break;
}

Console.WriteLine($"Dziękuję, papa");

