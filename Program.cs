namespace VariablesAndOutput
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
                $" {mathematics}\nБаллы по физике: {physics}";
            Console.Write(result);
            Console.ReadKey();
        }
    }
}