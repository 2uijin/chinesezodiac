using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chinesezodiac
{
    class Program
    {
        static void Main(string[] args)
        {
            int year = int.Parse(Console.ReadLine());
            string[] ani = new string[12];
            ani[0] = "원숭이";
            ani[1] = "닭";
            ani[2] = "개";
            ani[3] = "돼지";
            ani[4] = "쥐";
            ani[5] = "소";
            ani[6] = "호랑이";
            ani[7] = "토끼";
            ani[8] = "용";
            ani[9] = "뱀";
            ani[10] = "말";
            ani[11] = "양";

            int num = year % 12;

            Console.WriteLine(ani[num]);
        }
    }
}
