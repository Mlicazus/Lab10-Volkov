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


int[] points = { 10, 20, 15 };
for (int i = 0; i < points.Length; i++)
{
    points[i] += 5;
    System.Console.WriteLine(points[i]);
}
