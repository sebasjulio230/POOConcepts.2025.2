namespace POO.Concepts.Core;

public class Date
{
    private int _day;
    private int _month;  
    private int _year;

    public Date()
    {
        Year = 1900;
        Month = 1;
        Day = 1;
    }

    public Date(int year, int month, int day)
    {
        Year = year;
        Month = month;
        Day = day;
    }

    public int Day 
    {
        get => _day;
        set
        {
            _day = ValidateDay(value);
        }
    }

    public int Month 
    {
        get => _month;
        set
        {
            _month = ValidateMonth(value);
        }
    }

    public int Year 
    {
        get => _year;
        set
        {
            _year = ValidateYear(value);
        }
    }


    public override string ToString()
    {
        return $"{Year:0000}/{Month:00}/{Day:00}";
    }
    private bool IsLeapYear(int year)
    {
        return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
    }

    private int ValidateYear(int year)
    {
        if (year < 0)
        {
            throw new Exception("Year cannot be negative.");
        }
        return year;
    }                   

    private int ValidateMonth(int month)
    {
        if (month < 1 || month > 12)
        {
            throw new Exception($"The month {month}, is not valid");
        }
        return month;
    }
    
    private int ValidateDay(int day)
    {
        if (Month < 1 || Month > 12)
            throw new Exception($"The month {Month} is not valid.");

        int[] daysInMonth = { 31, IsLeapYear(Year) ? 29 : 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        int maxDay = daysInMonth[Month - 1];

        if (day < 1 || day > maxDay)
            throw new Exception($"The day {day} is not valid for month {Month} in year {Year}.");

        return day;
    }
}