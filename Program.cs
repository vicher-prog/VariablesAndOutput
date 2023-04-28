using static System.Formats.Asn1.AsnWriter;

namespace VariablesAndOutput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задание 1. Создание переменных и вывод

            //Ф.И.О.
            string fullName;
            //Возраст
            byte age;
            //Email
            string email;
            //Баллы по программированию
            float programming;
            //Баллы по математике
            float mathematics;
            //Баллы по физике
            float physics;
            //Результат
            string result;

            fullName = "Иван Иванович Иванов";
            age = 17;
            email = "ivan.ivanov@gmail.com";

            programming = 9.5f;
            mathematics = 8.7f;
            physics = 3.1f;

            result = $"ФИО: {fullName}\nВозраст: {age}\nEmail: " +
                $"{email}\nБаллы по программированию: {programming}\nБаллы по математике:" +
                $"{mathematics}\nБаллы по физике: {physics}";
            Console.Write(result + "\n\nНажмите любую кнопку");
            Console.ReadKey();

            //Задание 2. Реализация подсчёта количества баллов по всем предметам

            //Переменная под сумму баллов
            float summ;
            //Подсчёт суммы баллов
            summ = programming + mathematics + physics;
            //Переменная под средний балл
            float averageScore;
            //Вычисление среднего балла
            averageScore = summ / 3;

            result = $"Сумма баллов по всем дисциплинам: {summ:0.00}\nСреднее арифметическое всех баллов: {averageScore:0.00}";

            Console.Write(result + "\n\nНажмите любую кнопку");
            Console.ReadKey();

        }
    }
}