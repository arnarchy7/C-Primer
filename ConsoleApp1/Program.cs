using ConsoleApp1;

//Dæmi 1

/*
List<int> numbers = new List<int>();

string input = "x";

while (input != "")
{
    Console.Write("Input a number: ");

    input = Console.ReadLine();

    if(input == "") { 
    
        Console.WriteLine(numbers.Max());

        Console.WriteLine(numbers.Min());

    }

    numbers.Add(Convert.ToInt32(input));
}
*/


//Dæmi 2

WeatherData n1 = new WeatherData();

n1.Scale = "C";
n1.Temperature = 25;
n1.Humidity = 15;

WeatherData n2 = new WeatherData();

n2.Scale = "F";
n2.Temperature = 111;
n2.Humidity = 36;

Console.WriteLine(n1.Temperature);
Console.WriteLine(n1.Humidity);
Console.WriteLine(n1.Scale);
WeatherData.Convert(n1);
WeatherData.Convert(n1);
WeatherData.Convert(n2);
WeatherData.Convert(n2);
