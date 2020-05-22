/*
 * You are given the following information, but you may prefer to do some research for yourself.
 * 
 * - 1 Jan 1900 was a Monday.
 * 
 * - Thirty days has September,
 *   April, June and November.
 *   All the rest have thirty-one,
 *   Saving February alone,
 *   Which has twenty-eight, rain or shine.
 *   And on leap years, twenty-nine.
 *   
 * - A leap year occurs on any year evenly divisible by 4, but not on a century unless it is divisible by 400.
 * 
 * How many Sundays fell on the first of the month during the twentieth century (1 Jan 1901 to 31 Dec 2000)?
 */
var sundayCount = 0;
for(var date = new DateTime(1901, 1, 1); date <= new DateTime(2000, 12, 31); date = date.AddDays(1))
{
    if (date.DayOfWeek == DayOfWeek.Sunday && date.Day == 1)
        sundayCount++;
}

Console.WriteLine(sundayCount);
