using static System.Console;
Clear();
// 3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда
// 5 ->  Пятница
Write("Введите номер дня недели, где 1 это Понедельник, чтобы узнать название: ");
int DayOFWeek = Convert.ToInt32(ReadLine());
if (DayOFWeek==1) WriteLine("Понедельник");
if (DayOFWeek==2) WriteLine("Вторник");
if (DayOFWeek==3) WriteLine("Среда");
if (DayOFWeek==4) WriteLine("Четверг");
if (DayOFWeek==5) WriteLine("Пятница");
if (DayOFWeek==6) WriteLine("Суббота");
if (DayOFWeek==7) WriteLine("Воскресенье");
