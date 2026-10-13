// using System.Data;

// int[] recordBooks = { 1042, 1058, 1071, 1093, 1105 };
// int target = 1072;
// bool found = false;

// foreach (int number in recordBooks)
// {
//    if (number == target)
//    {
//       found = true;
//       break;
//    }
// }
// Console.WriteLine(found ? "Студент найден" : "Студент не найден");


// int variant = 1;
// bool isPrime = true;

// if (variant <= 1) isPrime = false;

// for (int divisor = 2; divisor < variant; divisor++)
// {
//    if (variant % divisor == 0)
//    {
//       isPrime = false;
//       break;
//    }
// }
// Console.WriteLine(isPrime ? "Номер варианта простой" : "Номер варианта составной");


// int[] pointsPerLab = { 0, -1, 10, 9, -1, 7 };
// int sum = 0;
// int count = 0;

// foreach (int points in pointsPerLab)
// {
//    if (points < 0)
//    {
//       continue;
//    }
//    sum += points;
//    count++;
// }
// Console.WriteLine($"Сумма баллов за сданные работы: {sum}");
// Console.WriteLine($"Сколько работ было сдано: {count}");


// using System.Data.Common;

// int[] groupIds = { 101, 104, 107, 104, 110 };
// bool hasDuplicates = false;

// for (int i = 0; i < groupIds.Length; i++)
// {
//    if (hasDuplicates) break;
//    for (int j = i + 1; j < groupIds.Length; j++)
//    {
//       if (groupIds[i] == groupIds[j])
//       {
//          hasDuplicates = true;
//          Console.WriteLine($"Совпавшие номера: {groupIds[i]} и {groupIds[j]}");
//          break;
//       }
//    }
// }
// Console.WriteLine(hasDuplicates ? "Есть повторяющиеся номера" : "Все номера уникальны");


// int days = 5;
// int lessonsPerDay = 6;
// bool found = false;
// for (int day = 1; day <= days && !found; day++)
// {
//    for (int lesson = 1; lesson <= lessonsPerDay; lesson++)
//    {
//       bool isFree = (day == 3 && lesson == 4);

//       if (isFree)
//       {
//          Console.WriteLine($"Свободный слот: день {day}, урок {lesson}");
//          found = true;
//          break;
//       }
//    }
// }

// if (!found)
// {
//    Console.WriteLine("Свободных слотов нет");
// }


//Сам. задания
//В
// int[] numbers = { 1, 6, 7, 8, 9 };
// int sum = 0;
// foreach (int num in numbers)
// {
//    if (num % 2 != 0)
//    {
//       continue;
//    }
//    sum += num;
// }
// Console.WriteLine($"Сумма только чётных чисел: {sum}");

//Г
// int[] groupIds = { 101, 104, 107, 104, 110 };
// bool hasDuplicates = false;

// for (int i = 0; i < groupIds.Length; i++)
// {
//    if (hasDuplicates)
//    {
//       break;
//    }
//    for (int j = i + 1; j < groupIds.Length; j++)
//    {
//       if (groupIds[i] == groupIds[j])
//       {
//          hasDuplicates = true;
//          break;
//       }
//    }
// }
// if (hasDuplicates)
// {
//    Console.WriteLine("В массиве есть повторяющиеся элементы");
// }
// else
// {
//    Console.WriteLine("В массиве нет повторяющихся элементов");
// }


// Console.Write("Введите свою фамилию: "); 
// string surname = Console.ReadLine()!.Trim(); 
// if (string.IsNullOrEmpty(surname)) { 
// Console.WriteLine("Фамилия не введена. Завершение работы."); 
// return; 
// } 
// Random rnd = new(surname.GetHashCode() + DateTime.Now.DayOfYear); 
// var assigned = Enumerable.Range(1, 10) 
// .OrderBy(_ => rnd.Next()) 
// .Take(2) 
// .OrderBy(x => x) 
// .ToList();
// Console.WriteLine($"Задачи: №{assigned[0]} и №{assigned[1]}");

//Инд. вариант
//3
int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
int sum = 0;

foreach (int num in numbers)
{
   if (num % 3 == 0)
   {
      continue;
   }
   sum += num;
}
Console.WriteLine($"Сумма всех чисел, кроме кратных 3: {sum}");
//
//10
