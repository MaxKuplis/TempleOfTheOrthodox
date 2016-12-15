using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        //Основной метод
        static void Main(string[] args)
        {
            // Варианты имени Влада
            string[] names1 = new string[6]
            {
               "Влад", "Владик", "Владос", "Dkfl", "Dkflbr", "Dkfljc"
                };
            // Варианты имени Миши
            string[] names2 = new string[10]
            {
             "Миша", "Мишадь", "Михоил", "Мишган", "Михаил", "Vbif", "Vbiflm", "Vb[jbk", "Vbiufy", "Vb[fbk"
            };
            //Варианты имени Кольта
            string[] names3 = new string[2]
            {
             "Кольт", "Rjkmn"
            };
            //Все варианты имен 
            string[] names4 = new string[18]
            {
             "Влад", "Владик", "Владос", "Dkfl", "Dkflbr", "Dkfljc", "Миша", "Мишадь", "Михоил", "Мишган", "Михаил", "Vbif", "Vbiflm", "Vb[jbk", "Vbiufy", "Vb[fbk", "Кольт", "Rjkmn"
            };
            // Приветсвие и ввод имени
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Дратути, вас приветствует программа Dkflbr Gbljh.\nДля продолжения нажмите любую клавишу");
            Console.ReadKey();
            Console.WriteLine("\nВведите имя");
            string word1 = (Console.ReadLine());
            //Распределение по массивам
            //Влад
            switch (names1.Contains(word1))
            {
                case (true): Vlad(); break;
            }
            //Миша
            switch (names2.Contains(word1))
            {
                case (true): Misha(); break;
            }
            //Кольт
            switch (names3.Contains(word1))
            {
                case (true): Colt(); break;
            }
            //Если нет в массиве
            switch (names4.Contains(word1))
            {
                case (false): Unknow(); break;
            }
        }
        //Метод Влада
        static void Vlad()
        {
            // Вариатны ответа "Нет"
            string[] answer = new string[4] {
                "Нет", "нет", "No", "no"
                };
            //Диалог
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Ты пидор. Что на это скажешь?");
            string word5 = (Console.ReadLine());

            if (answer.Contains(word5) == false)
            {
                Console.WriteLine("От пидора слышу");
                Console.ReadLine();
                Console.WriteLine("Ой, ладно, заебал, Владик.");
                Console.ReadLine();
            }
            else if (answer.Contains(word5))
            {
                Console.WriteLine("Пидора ответ");
                Console.ReadLine();
                Console.WriteLine("От пидора слышу");
                Console.ReadLine();
                Console.WriteLine("Ой, ладно, заебал, Владик.");
                Console.ReadLine();
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nВведи любое слово");
            string name = "Vlad";
            Question(name);
        }
        //Метод Кольта
        static void Colt()
        {
            //варианты ответа "Да"
            string[] answer1 = new string[4]
            {
            "Да, иду", "Да", "Иду", "Да иду"
            };
            //Варианты ответа "Нет"
            string[] answer2 = new string[5]
            {
                "Не иду", "Нет, не иду", "Нет", "Нет, мне ко второй", "Нет мне ко второй"
            };
            //Варианты "Ко второй"
            string[] answer3 = new string[2]
            {
                "Ко второй", "ко второй"
            };
            //Диалог
            Console.WriteLine("Спина болит?");
            Console.ReadLine();
            Console.WriteLine("Потому что не помолился");
            Console.ReadLine();
            Console.WriteLine("Ой, ладно.\nА на пары идешь или тебе ко второй?");
            string word6 = (Console.ReadLine());
            //Варианты
            if (answer1.Contains(word6))
            {
                Console.WriteLine("Врать грешно");
                Console.ReadLine();
            }
            else if (answer2.Contains(word6))
            {
                Console.WriteLine("Бог и деканат знают всё, грешник");
                Console.ReadLine();
            }
            else if (answer3.Contains(word6))
            {
                Console.WriteLine("Грешно первую пропускать");
                Console.ReadLine();
            }
            Console.WriteLine("Если два слова введешь, то отпустят тебе грех, возможно…\nСейчас введи первое…");
            string name = "Colt";
            Question(name);
        }
        //Метод Миши
        static void Misha()
        {
            Console.WriteLine("Ты же бухой, даже когда трезвый.\nО чем говорить с тобой-то, братишка?");
            Console.ReadLine();
            Console.WriteLine("Всё тобою сказанное может быть использовано против тебя.\nБыстро введи первое слово");
            string name = "Misha";
            Question(name);
        }
        //Метод кого-то
        static void Unknow()
        {
            //Варианты "Да"
            string[] answer4 = new string[2]
            {
               "Да", "да"
            };
            //Варианты "Нет
            string[] answer5 = new string[2]
           {
               "Нет", "нет"
           };
            Console.WriteLine("Во,уважаю, братишка.\nА хочешь историю расскажу?\nДа? Нет?");
            string word7 = (Console.ReadLine());
            //Если "Да"
            if (answer4.Contains(word7))
            {
                Console.WriteLine("Такие как ты бабам нравятся");
                Console.ReadLine();
            }
            //Если "Нет"
            else if (answer5.Contains(word7))
            {
                Console.WriteLine("Да не пизди, хочешь");
                Console.ReadLine();
            }
            Console.WriteLine("В общем, перед историей тебе нужно ввести два слова. Ну или свою мысль любую.\nВот сейчас введи первое");
            string name = "Unknow";
            Question(name);
        }
        //Метод вопроса
        public static void Question(string name)
        {
            //Массив с рандомом
            string[] mathy = new string[3]
            {
                "Влад - пидор", "Кольт - грешник", "Миша - алкаш"
            };
            Random ff = new Random();
            //Переменные с которыми будет сравниваться пришедшая
            string name1 = "Vlad";
            string name2 = "Colt";
            string name3 = "Misha";
            string name4 = "Unknow";

            Console.ForegroundColor = ConsoleColor.Yellow;
            string word7 = (Console.ReadLine());
            //Диалог для Влада
            switch (name1 == name)
            {
                case (true):
                    Console.WriteLine("А теперь второе слово");
                    string word8 = (Console.ReadLine());
                    Console.WriteLine("Идет анализ...");
                    Timer();
                    Console.WriteLine("Проанализировав слова {0} и {1}, я узнал, что Ты пидор", word7, word8);
                    Console.ReadLine();
                    Kogor();
                    break;
            }
            //Диалог для Кольта
            switch (name2 == name)
            {
                case (true):
                    Console.WriteLine("А теперь второе");
                    string word8 = (Console.ReadLine());
                    Console.WriteLine("Идет анализ...");
                    Timer();
                    Console.WriteLine("Не сложилось, не срослось.\nАнализ слов {0} и {1} показал, что грешишь прогулами, даже если ко второй идешь.\nГрех не отпустят, в деканате опустят. Крепись.", word7, word8);
                    Console.ReadLine();
                    Kogor();
                    break;
            }
            //Диалог Миши
            switch (name3 == name)
            {
                case (true):
                    Console.WriteLine("А теперь второе");
                    Console.ReadLine();
                    Console.WriteLine("Идет анализ...");
                    Timer();
                    Console.WriteLine("Какой-то пьяный бред!\nНа работу пошел! Чисти!");
                    Kogor();
                    break;
            }
            //Диалог Анона
            switch (name4 == name)
            {
                case (true):
                    Console.WriteLine("Введи второе");
                    Console.ReadLine();
                    Console.WriteLine("Идет анализ...");
                    Timer();
                    Console.WriteLine("Ну ты мамкин филасаф.\nА ты знаешь, что " + mathy[ff.Next(3)]);
                    Console.ReadLine();
                    Console.WriteLine("Ну такое то стыдно не знать. Удачи, братишка");
                    Console.ReadLine();
                    break;
            }

        }
        //Метод таймера
        public static void Timer()
        {
            int i = 5;
            do
            {
                Console.WriteLine(i);
                i--;
                Thread.Sleep(1000);
            }
            while (i > 0);
        }
        //Метод Когора
        static void Kogor()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nКстати, Когор приезжает в Питер 2-го января.\nНе напивайся сильно, браток.");
            Console.ReadLine();
        }
    }
}
