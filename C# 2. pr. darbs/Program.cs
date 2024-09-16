//// 1. Uzdevums

//Console.Write("Ievadiet skaitli: ");
//int num = Convert.ToInt32(Console.ReadLine());

//if (num % 2 == 0)
//{
//    Console.WriteLine(num + " - pāra skaitlis");
//}
//else
//{
//    Console.WriteLine(num + " - nepāra skaitlis");
//}


//// 2. Uzdevums

//Console.WriteLine("Ievadiet x:");
//double x = Convert.ToDouble(Console.ReadLine());

//Console.WriteLine("Ievadiet y:");
//double y = Convert.ToDouble(Console.ReadLine());

//if (y == 0)
//{
//    Console.WriteLine("Dalīšana ar 0");
//}
//else
//{
//    Console.WriteLine("Rezultāts = " + x / y);
//}


//// 3. Uzdevums

//Console.Write("Ievadiet vārdu: ");
//string name = Console.ReadLine();

//if (name.Length < 5)
//{
//    Console.WriteLine("Jābūt 5 simboliem");
//}
//else if (name == "Sandis")
//{
//    Console.WriteLine("Parole ievadīta pareizi");
//}
//else
//{
//    Console.WriteLine("Parole ievadīta nepareizi");
//}


//// 4. Uzdevums

//Console.WriteLine("1-Kvadrāta perimetra formula");
//Console.WriteLine("2-Kvadrāta laukuma formula");
//Console.WriteLine("3-Kvadrāta diagonāles formula");

//Console.WriteLine("Ievadiet malu a: ");

//int a = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Izvēlēties darbību:");
//int job = Convert.ToInt32(Console.ReadLine());


//switch (job)
//{
//    case 1:
//        Console.WriteLine("Kvadrāta perimetrs: " + a * 4);
//        break;
//    case 2:
//        Console.WriteLine("Kvadrāta laukums: " + a * a);
//        break;
//    case 3:
//        Console.WriteLine("Kvadrāta diagonāle: " + (Math.Sqrt(2) * a));
//        break;
//    default:
//        Console.WriteLine("Tādas darbības nav");
//        break;
//}


// 5. uzdevums

//Console.Write("Ievadi atzīmi (%): ");
//int grade = Convert.ToInt32(Console.ReadLine());

//if (grade < 0 || grade > 100)
//{
//    Console.WriteLine("Ievadīts nepareizs formāts");
//}
//else if (grade <= 49)
//{
//    Console.WriteLine("Nepietiekami");
//}
//else if (grade <= 59)
//{
//    Console.WriteLine("Gandrīz vidēji");
//}
//else if (grade <= 69)
//{
//    Console.WriteLine("Vidēji");
//}
//else if (grade <= 79)
//{
//    Console.WriteLine("Labi");
//}
//else if (grade <= 89)
//{
//    Console.WriteLine("Ļoti labi");
//}
//else 
//{
//    Console.WriteLine("Izcili");
//}


//// 6. uzdevums

//Console.Write("Ievadi 1 lenki: ");
//int first = Convert.ToInt32(Console.ReadLine());
//Console.Write("Ievadi 2 lenki: ");
//int second = Convert.ToInt32(Console.ReadLine());
//Console.Write("Ievadi 3 lenki: ");
//int third = Convert.ToInt32(Console.ReadLine());

//if (first + second + third != 180)
//{
//    Console.WriteLine("Kluda: ievaditie lenki neveido trijsturi.");
//}
//else if (first == second && second == third)
//{
//    Console.WriteLine("Vienadmalu trijsturis");
//}
//else if (first != second && first != third && second != third)
//{
//    Console.WriteLine("Dazadsanu trijsturis");
//}
//else 
//{
//    Console.WriteLine("Vienadsanu trijsturis");
//}


//// 7. Uzdevums

//Console.Write("Ievadiet patereto elektribas daudzumu (kWh): ");
//int kwh = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Izveleties tarifu planu:");
//Console.WriteLine("1. Majsaimniecibas Tarifs");
//Console.WriteLine("2. Komercdarbibas Tarifs");
//Console.WriteLine("3. Rupniecibas Tarifs");

//Console.Write("Ievadiet tarifu plana numur (1, 2 vai 3): ");
//int planNr = Convert.ToInt32(Console.ReadLine());
//double expense = 0;

//switch (planNr)
//{
//    case 1:
//        if (kwh <= 100)
//        {
//            expense = 0.15 * kwh;
//        }
//        else if (kwh <= 300)
//        {
//            expense = (100 * 0.15) + (kwh - 100) * 0.20;
//        }
//        else
//        {
//            expense = (100 * 0.15) + (200 * 0.2) + (kwh - 300) * 0.25;
//        }
//        break;
//    case 2:
//        if (kwh <= 200)
//        {
//            expense = 0.30 * kwh;
//        }
//        else if (kwh <= 500)
//        {
//            expense = (200 * 0.3) + (kwh - 200) * 0.35;
//        }
//        else
//        {
//            expense = (200 * 0.3) + (300 * 0.35) + (kwh - 500) * 0.40;
//        }
//        break;
//    case 3:
//        if (kwh <= 500)
//        {
//            expense = 0.50 * kwh;
//        }
//        else if (kwh <= 1000)
//        {
//            expense = (500 * 0.5) + (kwh - 500) * 0.55;
//        }
//        else
//        {
//            expense = (500 * 0.5) + (500 * 0.55) + (kwh - 1000) * 0.60;
//        }
//        break;
//}

//Console.WriteLine("Jusu elektribas rekins ir: " + expense + " EUR.");