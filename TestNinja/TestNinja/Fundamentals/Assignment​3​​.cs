using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNinja.Fundamentals
{
    public class Assignment​3​​
    {
        public ActionResult IsLetter(char sumbol, string line)
        {
           
            for (int i = 0; i < line.Length; i++)
                if (line[i] == sumbol)
                    return new matches();
            return new doesntMatch();
        }
    }
    //функция ​​которая  принимает аргументы и возвращает ​Функцию
    //функция проверяет есть ли символ(sumbol) в строке(line),если есть то возвращает matches,
    //если нет то возвращает doesntMatch.
    public class ActionResult
    {
    }


    public class matches : ActionResult
    {

    }
    public class doesntMatch : ActionResult
    {
    }
}
