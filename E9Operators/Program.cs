// See https://aka.ms/new-console-template for more information

Console.WriteLine("SECONDS CALCULATOR \nGive me a number of seconds : \n");
int totalSec = Convert.ToInt32(Console.ReadLine());

int daySec = 86400;
int hourSec = 3600;
int minSec = 60;

int days = totalSec / daySec;
float daysInPieces = (float)totalSec / daySec;
int modulol =  totalSec % daySec;

int hours = modulol / hourSec;
modulol = modulol % hourSec;

int minutes = modulol / minSec;

int seconds = modulol % minSec;

Console.WriteLine("Seconds: " + seconds);
Console.WriteLine("Minutes: " + minutes);
Console.WriteLine("Hours: " + hours);
Console.WriteLine("Days: " + days);

Console.WriteLine($"{days}.{hours}:{minutes}:{seconds}");
Console.WriteLine("In total, that's " + daysInPieces + " Days.");


