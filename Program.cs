Console.WriteLine("Enter a number: ");

string number = Console.ReadLine();

string rep = "";

switch (number) {
    case "0":
        rep = "Zero";
        break;
    case "1":
        rep = "One";
        break;
    case "2":
        rep = "Two";
        break;
    case "3":
        rep = "Three";
        break;
    case "4":
        rep = "Four";
        break;
    case "5":
        rep = "Five";
        break;
    case "6":
        rep = "Six";
        break;
    case "7":
        rep = "Seven";
        break;
    case "8":
        rep = "Eight";
        break;
    case "9":
        rep = "Nine";
        break;
    case "10":
        rep = "Ten";
        break;
    default:
        Console.WriteLine("That number is not in range.");
        break;
}

Console.WriteLine($"Your number is {rep}");