using BirthdayDate.CalenderDates;
using System;


namespace BirthdayDate
{
    public class Menu
    {
        public void ChooseOptionMenu()
        {
            short? option = null;
            Calender calender = new Calender();

            do
            {
                Console.WriteLine($"{Environment.NewLine}Digite 0 para encerrar o programa, 1 para buscar o dia da semana que o seu aniversário se localiza, 2 para mostrar o dia da semana que o seu aniversário se localiza{Environment.NewLine}");
                option = short.Parse(Console.ReadLine());
                switch (option)
                {
                    case 0:
                        System.Environment.Exit(0);
                        break;
                    case 1:
                        Console.WriteLine($"{System.Environment.NewLine}Para descobrir o dia na semana que o seu aniversário está, Digite o dia, mes e ano do seu aniversário, respectivamente (Dando enter para cada informacao da data inserida)!{System.Environment.NewLine}");
                        var day = int.Parse(Console.ReadLine());
                        var month = int.Parse(Console.ReadLine());
                        var year = int.Parse(Console.ReadLine());
                        calender.SearchDayOfWeekBirthday(day, month, year);
                        break;

                    case 2:
                        calender.ShowDayOfWeekOfBirthday();
                        break;

                    default:
                        Console.WriteLine($"{System.Environment.NewLine}Opcao inválida, tente novamente!{System.Environment.NewLine}");
                        break;
                }


            }while(option != 0);
        }
    }
}
