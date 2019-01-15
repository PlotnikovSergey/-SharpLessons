using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp7Lesson
{
    class GameUgadayChislo
    {
        int r;
        public int guess;
        int triesCount;
        public string info;
     
        public int TriesCount => triesCount;
        public int R => r;

        public GameUgadayChislo()
        {
            guess = 0;
            triesCount = 5;
            r = GenerateNumber();
        }

        public int GenerateNumber()
        {
            var R = new Random();
            return R.Next(0, 100);
        }

        public void CheckCount()
        {
            triesCount--;
            if (guess == r && triesCount > 0)
            {
                info = "Молодец, угадал! Это было число " + r;               
            }
            else if (guess < r && triesCount > 0)
            {
                info = "Число компьютера больше!";               
            }
            else if (guess > r && triesCount > 0)
            {
                info = "Число компьютера меньше!";               
            }
            else
            {          
                info = "Попыток не осталось! Ты проиграл! Это было число " + r;
            }
        }
    }
}
