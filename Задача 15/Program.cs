Console.Write("Введиnt номер дня недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

void CheckingTheDayOfTheWeek (int dayNumber) {
  if (dayNumber == 6 || dayNumber == 7) {
  Console.WriteLine("Выходной");
  }
  else if (dayNumber < 1 || dayNumber > 7) {
    Console.WriteLine("Ошибка, столько дней в недели нет");
  }
  else Console.WriteLine("Будничний день");
}

CheckingTheDayOfTheWeek(dayNumber);
