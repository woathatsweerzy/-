internal class Ижедневник
{
    static void Main(string[] args)
    {
        DateOnly date = new DateOnly(2022, 10, 19);
        int pos = 1;
        note[] note = notes();
        ConsoleKeyInfo key = Console.ReadKey();

            while (key.Key != ConsoleKey.Escape)
            {
                pos = arrow(key, pos);
                /*string[] note_desc = notes();*/
                Console.WriteLine(note);

                date = switch_date(key, date);
                Console.Clear();
                Console.WriteLine(date);
                if (date == new DateOnly(2022, 10, 15))
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    /*if ((pos == 1) & (key.Key == ConsoleKey.Enter))
                    {
                        Console.WriteLine(,"\n --------- \n", );
                    }*/
                }
                foreach (note item in note)
                {
                    if (item.note_date == date)
                    {
                        Console.WriteLine("  " + item.note_name);
                        if (key.Key == ConsoleKey.Enter && item.note_posi == pos)
                        {
                            menu(item, key);
                            Console.Clear();
                        }
                    }
                }
            if (pos < 1)
                {
                    pos = 1;
                }
                else if (pos > 2)
                {
                    pos = 2;
                }
                Console.SetCursorPosition(0, pos);
                Console.WriteLine("->");
                key = Console.ReadKey();
            }
        static int arrow(ConsoleKeyInfo key1, int pos1)
        {
            if (key1.Key == ConsoleKey.DownArrow)
            {
                pos1++;
            }
            if (key1.Key == ConsoleKey.UpArrow)
            {
                pos1--;
            }
            return pos1;
        }
        static DateOnly switch_date(ConsoleKeyInfo key1, DateOnly date1)
        {
            if (key1.Key == ConsoleKey.RightArrow)
            {
                date1 = date1.AddDays(1);
            }
            else if (key1.Key == ConsoleKey.LeftArrow)
            {
                date1 = date1.AddDays(-1);
            }
            return date1;
        }
        static void menu(note itemin, ConsoleKeyInfo key1)
        {
            do
            {
                Console.Clear();
                Console.WriteLine(itemin.note_name);
                Console.WriteLine(itemin.note_desc);
                ConsoleKeyInfo key2 = Console.ReadKey();
                key1 = key2;
                Console.Clear();
            } while (key1.Key != ConsoleKey.Escape);
        }
        static note[] notes()
        {

            note note1 = new note();
            note1.note_date = new DateOnly(2022, 10, 15);
            note1.note_name = "   1. Приехаль в Моджайзк";
            note1.note_desc = "Я приехал на свою ррродину! \nхочу сгонять к своим одноклассникам<3";
            note1.note_posi = 1;

            note note2 = new note();
            note2.note_date = new DateOnly(2022, 10, 15);
            note2.note_name = "   2. помогите тут ремонт =(";
            note2.note_desc = "я хотел сидеть отдыхать \nа тут ремонт пипец красим стены емае";
            note2.note_posi = 1;

            note note3 = new note();
            note3.note_date = new DateOnly(2022, 10, 18);
            note3.note_name = "   1. Вернулься в Моськву";
            note3.note_desc = "урррра \nбуду играть в компутер";
            note3.note_posi = 1;

            note note4 = new note();
            note4.note_date = new DateOnly(2022, 10, 18);
            note4.note_name = "   2. помргите тут дз =(";
            note4.note_desc = "я хотел сидеть отдыхать \nа тут дз отчень много какое ежедневник  \nсижу пишу уже 6 часов ааааа";
            note4.note_posi = 1;

            note note5 = new note();
            note5.note_date = new DateOnly(2022, 10, 14);
            note5.note_name = "   1. Кажется у меня дэрчик";
            note5.note_desc = "ооо еее урааа да еее у меня др \nподарили много денег подвеску и кружку с жириновским =) \nвсех люблю все молодцы <3";
            note5.note_posi = 1;

            note[] notes = new note[] { note1, note2, note3, note4, note5 };
            /*string[] note_names = new string[] { note1.note_name, note2.note_name, note3.note_name, note4.note_name, note5.note_name };
            string[] note_descs = new string[] { note1.note_desc, note2.note_desc, note3.note_desc, note4.note_desc, note5.note_desc };*/
            return notes;
        }
    }
}
