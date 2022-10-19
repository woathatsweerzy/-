internal class Ижедневник
{
    static void Main(string[] args)
    {
        DateOnly note_date1 = new DateOnly(2022, 10, 15); 
        DateOnly note_date2 = new DateOnly(2022, 10, 18);
        DateOnly note_date3 = new DateOnly(2022, 10, 14);
        date(note_date1, note_date2, note_date3);
    }
    static void date(DateOnly check_date1 , DateOnly check_date2, DateOnly check_date3)
    {
        DateOnly date = new DateOnly(2022, 10, 19);
        Console.WriteLine(date);
        ConsoleKeyInfo key = Console.ReadKey();
        while (key.Key != ConsoleKey.Escape)
        {
            key = Console.ReadKey();
            if (key.Key == ConsoleKey.RightArrow)
            {
                date = date.AddDays(1);
                Console.Clear();
                Console.WriteLine(date);
            }
            else if (key.Key == ConsoleKey.LeftArrow)
            {
                date = date.AddDays(-1);
                Console.Clear();
                Console.WriteLine(date);
            }
            else if ((key.Key != ConsoleKey.RightArrow) | (key.Key != ConsoleKey.LeftArrow))
            {
                continue;
            }
            if (date == check_date1)
            {
                note_menu1();
            }
            else if (date == check_date2)
            {
                note_menu2();
            }
            else if (date == check_date3)
            {
                note_menu3();
            }
        }
    }
    static void choice()
    {
        int pos = 1;
        ConsoleKeyInfo key = Console.ReadKey();
        if (key.Key == ConsoleKey.DownArrow)
        {
            pos++;
            Console.SetCursorPosition(0, pos);
            Console.WriteLine("->");
        }
        if (key.Key == ConsoleKey.UpArrow)
        {
            pos--;
            Console.SetCursorPosition(0, pos);
            Console.WriteLine("->");
        }
        Console.SetCursorPosition(0, pos);
        Console.WriteLine("->");
    }
    static void note_menu1()
    {
        note note1 = new note();
        note1.note_name = "   1. Приехаль в Моджайзк";
        note1.note_desc = "Я приехал на свою ррродину! хочу сгонять к своим одноклассникам";
        Console.WriteLine(note1.note_name);
        note note2 = new note();
        note2.note_name = "   2. помогите тут ремонт =(";
        note2.note_desc = "я хотел сидеть отдыхать а тут ремонт пипец красим стены емае";
        Console.WriteLine(note2.note_name);
    }
    static void note_menu2()
    {
        note note3 = new note();
        note3.note_name = "   1. Вернулься в Моськву";
        note3.note_desc = "урррра буду играть в компутер";
        Console.WriteLine(note3.note_name);
        note note4 = new note();
        note4.note_name = "   2. помргите тут дз =(";
        note4.note_desc = "я хотел сидеть отдыхать а тут дз отчень много какое ежедневник  сижу пишу уже 6 часов ааааа";
        Console.WriteLine(note4.note_name);
    }
    static void note_menu3()
    {
        note note5 = new note();
        note5.note_name = "   1. Кажется у меня дэрчик";
        note5.note_desc = "ооо еее урааа да еее у меня др подарили много денег подвеску и кружку с жириновским =) всех люблю все молодцы <3";
        Console.WriteLine(note5.note_name);
    }
}
