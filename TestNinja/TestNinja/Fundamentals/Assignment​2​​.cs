using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNinja.Fundamentals
{
    public class Assignment​2​​
    {
        int[] apartaments1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        int[] apartaments2 = { 10, 11, 12, 13, 14, 15, 16, 17, 18 };
        int[] apartaments3 = { } ;

        public IEnumerable<int> Home(int FrontDoor)
        {
            if (FrontDoor == 1)
                return apartaments1;
            if (FrontDoor == 2)
                return apartaments2;
            else
                return apartaments3 ;

            //функцию ​​которая будет принимать аргумент и возвращать ​Массив​​.
            //если выбрать первый подъезд, то возвращается массив квартир 1го подъезда
            //если выбрать второй подъезд, то возвращается массив квартир 2го подъезда
            //больше в доме подъездов нет и массив будет возвращаться пустой
        }
    }
}

