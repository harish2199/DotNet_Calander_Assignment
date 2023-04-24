﻿Console.Write("Enter a year: ");
int year = int.Parse(Console.ReadLine());

Console.Write("Enter any month (1-12): ");
int month = int.Parse(Console.ReadLine());

Console.Write("Enter Day of week(1-M,2-T,3-W,....,7-S): ");
int day = int.Parse(Console.ReadLine());

int DaysInMonth = DateTime.DaysInMonth(year, month);

//Console.WriteLine(DaysInMonth);

Console.WriteLine("S\tM\tT\tW\tT\tF\tS");
//For leaving spaces
for(int i = 0; i < day ; i++)
{
    if(day == 7)
    {
        continue;
    }
    else
    {
        Console.Write("\t");
    }
    
}

//For printing dates
for(int i = 1;i <= DaysInMonth; i++)
{
    Console.Write(i+"\t");
    if ((day + i) % 7 == 0)
    {
        Console.WriteLine();
    }
}

