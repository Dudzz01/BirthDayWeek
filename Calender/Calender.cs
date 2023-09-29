using System;
using System.Globalization;

namespace BirthdayDate.CalenderDates
{
    public class Calender
    {
        public DayOfWeek DayOfWeekBirhtday { get; set; }

        public DateTime Birthday { get; set; }

        public void SearchDayOfWeekBirthday(int day, int month, int year)
        {
            Birthday = new DateTime(year, month, day);

            DayOfWeekBirhtday = Birthday.DayOfWeek;
            Console.WriteLine("Dia da semana encontrado com sucesso, acesse o menu para mostrar o resultado!");
        }
        
        public void ShowDayOfWeekOfBirthday()
        {
            
            Console.WriteLine($"{System.Environment.NewLine}O seu aniversário esta na data: {Birthday.ToString("D",CultureInfo.CreateSpecificCulture("pt-BR"))}");
        }
    }
}
