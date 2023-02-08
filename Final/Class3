using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace shop10;

internal static class Menu
{
    public static void Meni(string menitext,string content)
    {
        MeniUp(menitext);
        MeniContent(content);
    }
    private static void MeniUp(string menitext)
    {
        Console.SetCursorPosition((Console.WindowWidth - menitext.Length) / 2, 0);
        Console.WriteLine(menitext);
        for (int i = 0; i < Console.WindowWidth; i++)
            Console.Write("-");
    }
    public static void MeniContent(string content)
    {
        Console.SetCursorPosition(0, 2);
        Console.WriteLine(content);
    }
    public static int MenuCUA(AutObject newe, int ChoseUserpos, bool CorU)
    {

        Control.ReadKey(MainClass.CUAcontent.Split("\n").Length - 5);
        Control.MenuArrow(MainClass.CUAcontent.Split("\n").Length - 5);
        if (Control.key.Key == ConsoleKey.Enter)
        {
            Console.SetCursorPosition(MainClass.CUAcontent.Split("\n")[Control.YCursorPos - 2].Length, Control.YCursorPos);
            string text = null;
            if (Control.YCursorPos - 2 != 5)
                text = Console.ReadLine();
            switch (Control.YCursorPos - 2)
            {
                case 0:
                    try { newe.id = UInt32.Parse(text); }
                    catch
                    {
                        Console.SetCursorPosition(0, MainClass.CUAcontent.Split("\n").Length + 2);
                        Console.WriteLine("Вводите число в ID и roole");
                    }
                    break;
                case 1:
                    newe.login = text;
                    break;
                case 2:
                    newe.password = text;
                    break;
                case 3:
                    try { newe.role = UInt32.Parse(text); }
                    catch
                    {
                        Console.SetCursorPosition(0, MainClass.CUAcontent.Split("\n").Length + 2);
                        Console.WriteLine("Вводите число в ID и roole");
                    }
                    break;
                case 4:
                    Console.SetCursorPosition(0, MainClass.CUAcontent.Split("\n").Length + 2);
                    Console.WriteLine("                          ");
                    if (newe.login != null && newe.password != null)
                    {
                        List<AutObject> checusers = Sterealizer.desteruser<List<AutObject>>(Startname.Users);
                        if (CorU)
                        {
                            checusers.RemoveAt(ChoseUserpos);
                        }
                        checusers.Add(newe);
                        Sterealizer.steruser(checusers, Startname.Users);
                    }
                    else
                    {
                        Console.SetCursorPosition(0, MainClass.CUAcontent.Split("\n").Length + 2);
                        Console.WriteLine("Заполните все поля");
                    }
                    break;
            }

        }
        return ChoseUserpos;
    }
    public static int MenuCUPM(EmployeObject newe, int ChoseUserpos, bool CorU)
    {
        Control.ReadKey(MainClass.CUPMcontent.Split("\n").Length);
        Control.MenuArrow(MainClass.CUPMcontent.Split("\n").Length);
        if (Control.key.Key == ConsoleKey.Enter)
        {
            Console.SetCursorPosition(MainClass.CUPMcontent.Split("\n")[Control.YCursorPos - 2].Length, Control.YCursorPos);
            string text = null;
            if (Control.YCursorPos - 2 != 8)
                text = Console.ReadLine();
            switch (Control.YCursorPos - 2)
            {
                case 0:
                    try { newe.id = UInt32.Parse(text); }
                    catch
                    {
                        Console.SetCursorPosition(0, MainClass.CUPMcontent.Split("\n").Length + 2);
                        Console.WriteLine("Вводите Данные правильно");
                    }
                    break;
                case 1:
                    newe.surname = text;
                    break;
                case 2:
                    newe.name = text;
                    break;
                case 3:
                    newe.patronymic = text;
                    break;
                case 4:
                    try { newe.born = DateTime.Parse(text); }
                    catch
                    {
                        Console.SetCursorPosition(0, MainClass.CUPMcontent.Split("\n").Length + 2);
                        Console.WriteLine("Вводите Данные правильно");
                    }
                    break;
                case 5:
                    try { newe.serialnumber = Int32.Parse(text); }
                    catch
                    {
                        Console.SetCursorPosition(0, MainClass.CUPMcontent.Split("\n").Length + 2);
                        Console.WriteLine("Вводите Данные правильно");
                    }
                    break;
                case 6:
                    newe.status = text;
                    break;
                case 7:
                    try { newe.pay = UInt32.Parse(text); }
                    catch
                    {
                        Console.SetCursorPosition(0, MainClass.CUPMcontent.Split("\n").Length + 2);
                        Console.WriteLine("Вводите Данные правильно");
                    }
                    break;
                case 8:
                    try { newe.iduser = UInt32.Parse(text); }
                    catch
                    {
                        Console.SetCursorPosition(0, MainClass.CUPMcontent.Split("\n").Length + 2);
                        Console.WriteLine("Вводите Данные правильно");
                    }
                    break;
                case 9:
                    Console.SetCursorPosition(0, MainClass.CUPMcontent.Split("\n").Length + 2);
                    Console.WriteLine("                          ");
                    if (newe.surname != null && newe.name != null && newe.patronymic != null && newe.status != null)
                    {
                        List<EmployeObject> checusers = Sterealizer.desteruser<List<EmployeObject>>(Startname.Employee);
                        if (CorU)
                        {
                            checusers.RemoveAt(ChoseUserpos);
                        }
                        checusers.Add(newe);
                        Sterealizer.steruser(checusers, Startname.Employee);
                    }
                    else
                    {
                        Console.SetCursorPosition(0, MainClass.CUPMcontent.Split("\n").Length + 2);
                        Console.WriteLine("Заполните все поля");
                    }
                    break;
            }

        }
        return ChoseUserpos;
    }
    public static int MenuCUWM(GoodGodObject newe, int ChoseUserpos, bool CorU)
    {

        Control.ReadKey(MainClass.CUWMcontent.Split("\n").Length);
        Control.MenuArrow(MainClass.CUWMcontent.Split("\n").Length);
        if (Control.key.Key == ConsoleKey.Enter)
        {
            Console.SetCursorPosition(MainClass.CUWMcontent.Split("\n")[Control.YCursorPos - 2].Length, Control.YCursorPos);
            string text = null;
            if (Control.YCursorPos - 2 != 5)
                text = Console.ReadLine();
            switch (Control.YCursorPos - 2)
            {
                case 0:
                    try { newe.id = UInt32.Parse(text); }
                    catch
                    {
                        Console.SetCursorPosition(0, MainClass.CUWMcontent.Split("\n").Length + 2);
                        Console.WriteLine("Вводите число в ID и roole");
                    }
                    break;
                case 1:
                    newe.name = text;
                    break;
                case 2:
                    try { newe.cost = UInt32.Parse(text); }
                    catch
                    {
                        Console.SetCursorPosition(0, MainClass.CUWMcontent.Split("\n").Length + 2);
                        Console.WriteLine("Вводите число в ID и roole");
                    }
                    break;
                case 3:
                    try { newe.count = UInt32.Parse(text); }
                    catch
                    {
                        Console.SetCursorPosition(0, MainClass.CUWMcontent.Split("\n").Length + 2);
                        Console.WriteLine("Вводите число в ID и roole");
                    }
                    break;
                case 4:
                    Console.SetCursorPosition(0, MainClass.CUWMcontent.Split("\n").Length + 2);
                    Console.WriteLine("                          ");
                    if (newe.id.ToString() != null && newe.name != null && newe.cost.ToString() != null && newe.count.ToString() != null)
                    {
                        List<GoodGodObject> checusers = Sterealizer.desteruser<List<GoodGodObject>>(Startname.God);
                        if (CorU)
                        {
                            checusers.RemoveAt(ChoseUserpos);
                        }
                        checusers.Add(newe);
                        Sterealizer.steruser(checusers, Startname.God);
                    }
                    else
                    {
                        Console.SetCursorPosition(0, MainClass.CUWMcontent.Split("\n").Length + 2);
                        Console.WriteLine("Заполните все поля");
                    }
                    break;
            }
        }
        return ChoseUserpos;
    }
    public static int MenuCUBP(BookeepingentryObject newe, int ChoseUserpos, bool CorU)
    {

        Control.ReadKey(MainClass.CUBPcontent.Split("\n").Length);
        Control.MenuArrow(MainClass.CUBPcontent.Split("\n").Length);
        if (Control.key.Key == ConsoleKey.Enter)
        {
            Console.SetCursorPosition(MainClass.CUBPcontent.Split("\n")[Control.YCursorPos - 2].Length, Control.YCursorPos);
            string text = null;
            if (Control.YCursorPos - 2 != 6)
                text = Console.ReadLine();
            switch (Control.YCursorPos - 2)
            {
                case 0:
                    try { newe.id = UInt32.Parse(text); }
                    catch
                    {
                        Console.SetCursorPosition(0, MainClass.CUBPcontent.Split("\n").Length + 2);
                        Console.WriteLine("Вводите Данные правильно");
                    }
                    break;
                case 1:
                    newe.name = text;
                    break;
                case 2:
                    try { newe.data = DateTime.Parse(text); }
                    catch
                    {
                        Console.SetCursorPosition(0, MainClass.CUBPcontent.Split("\n").Length + 2);
                        Console.WriteLine("Вводите Данные правильно");
                    }
                    break;
                case 3:
                    try { newe.cost = UInt32.Parse(text); }
                    catch
                    {
                        Console.SetCursorPosition(0, MainClass.CUBPcontent.Split("\n").Length + 2);
                        Console.WriteLine("Вводите Данные правильно");
                    }
                    break;
                case 4:
                    try { newe.plus = bool.Parse(text); }
                    catch
                    {
                        Console.SetCursorPosition(0, MainClass.CUBPcontent.Split("\n").Length + 2);
                        Console.WriteLine("Вводите Данные правильно");
                    }
                    break;
                case 5:
                    Console.SetCursorPosition(0, MainClass.CUBPcontent.Split("\n").Length + 2);
                    Console.WriteLine("                          ");
                    if (newe.id.ToString() != null && newe.name != null && newe.data.ToString() != null && newe.plus.ToString() != null && newe.cost !=null)
                    {
                        List<BookeepingentryObject> checusers = Sterealizer.desteruser<List<BookeepingentryObject>>(Startname.Cost);
                        if (CorU)
                        {
                            checusers.RemoveAt(ChoseUserpos);
                        }
                        checusers.Add(newe);
                        Sterealizer.steruser(checusers, Startname.Cost);
                    }
                    else
                    {
                        Console.SetCursorPosition(0, MainClass.CUBPcontent.Split("\n").Length + 2);
                        Console.WriteLine("Заполните все поля");
                    }
                    break;
            }
        }
        return ChoseUserpos;
    }
}
