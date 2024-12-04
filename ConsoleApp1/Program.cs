using ConsoleApp1;

Person bill = new Person(new DateTime(1999, 11, 11), "Bill", "Wick");
bill.SayHi();
bill.ContactNumber = "111222333";

Person john = new Person(new DateTime(2000, 1, 1), "John", "Wick");

Console.WriteLine($"Number of persons: {Person.Count}");