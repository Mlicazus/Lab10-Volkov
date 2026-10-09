// string subject = "Программирование";
// foreach (char letter in subject)
// {
//     System.Console.WriteLine(letter);
// }
// System.Console.WriteLine(subject.Length);

// int[] grades = { 4, 5, 3, 5, 4 };
// int sum = 0;
// foreach (int grade in grades)
// {
//     System.Console.WriteLine(grade);
//     sum += grade;
// }
// System.Console.WriteLine($"Сумма всех оценок: {sum}");
// System.Console.WriteLine($"Средний балл: {sum/grades.Length}");

// string[] students = { "Аня", "Ярослав", "Вика" };
// int count = 0;
// foreach (string student in students)
// {
//     System.Console.WriteLine(student);
//     count++;
// }
// System.Console.WriteLine($"Кол-во учеников в массиве {count}");


// int[] points = { 10, 20, 15 };
// for (int i = 0; i < points.Length; i++)
// {
//     points[i] += 5;
//     System.Console.WriteLine(points[i]);
// }

// string[] students = { "Аня", "Борис", "Вика" };
// int number = 1;
// foreach (string student in students)
// {
//     System.Console.WriteLine($"{number}. {student}");
//     number++;
// }

// // Задача А
// int[] numbers = { 1, 2, 3, 4, 5 };
// int sum = 0;
// foreach (int number in numbers)
// {
//     System.Console.WriteLine(number);
//     sum += number;
// }
// System.Console.WriteLine($"Сумма: {sum}");

// // Задача Б
// string[] days = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресение" };
// foreach (string day in days) {
//     System.Console.WriteLine($"{day}!");
// }

// System.Console.Write("Введите свою фамилию: ");
// string surname = System.Console.ReadLine()!.Trim();
// if (string.IsNullOrEmpty(surname))
// {
//     System.Console.WriteLine("Фамилия не введена. Завершение работы.");
//     return;
// }
// Random rnd = new(surname.GetHashCode() + DateTime.Now.DayOfYear);
// var assigned = Enumerable.Range(1, 10)
//     .OrderBy(_ => rnd.Next())
//     .Take(2)
//     .OrderBy(x => x)
//     .ToList();
// System.Console.WriteLine($"Задачи: №{assigned[0]} и №{assigned[1]}");

// // Вариант 1
// int[] temperatures = { 10, 20, 30, 35, 28, -5, 0 };
// int sum = 0;
// foreach (int temperature in temperatures)
// {
//     sum += temperature;
// }
// System.Console.WriteLine($"Средняя температура: {sum/temperatures.Length}");

// Вариант 7
int[] scores = { 5, 5, 4, 2, 4, 4, 5 };
int count = 0;
foreach (int score in scores)
{
    if (score == 5)
    {
        count++;
    }
}
System.Console.WriteLine($"Кол-во оценок 5: {count}");