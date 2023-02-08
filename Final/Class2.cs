using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace shop10
{
    internal class BookeePingentry : CRUD
    {
        const string readmenutext = "Бухгалтер Read";
        const string createmenutext = "Бухгалтер Create";
        const string updatemenutext = "Бухгалтер Update";
        private static BookeepingentryObject ChoseUser = null;
        private static int ChoseUserpos;
        private static int ChoseUserposDelit = -1;
        private const string hadtabulate = "ID Name Cost Data Plus";
        public static bool CRUDe()
        {
            if (Control.key.Key == (ConsoleKey)MainClass.keybinds.Enter)
                switch (Control.YCursorPos - 1)
                {
                    case 1:
                        Create();
                        Control.YCursorPos = 2;
                        return true;
                    case 2:
                        if (ChoseUser != null)
                            Dlete();
                        return true;
                    case 3:
                        Read();
                        Control.YCursorPos = 2;
                        return true;
                    case 4:
                        if (ChoseUser != null)
                            Update();
                        Control.YCursorPos = 2;
                        return true;
                }
            return false;
        }
        private static void Create()
        {
            Console.Clear();
            Menu.Meni(createmenutext + ": " + Aut.username, MainClass.CUBPcontent);
            BookeepingentryObject newe = new BookeepingentryObject();
            while (Control.key.Key != ConsoleKey.Escape)
            {
                ChoseUserpos = Menu.MenuCUBP(newe, ChoseUserpos, false);//true Create
            }
            Console.Clear();
            Menu.Meni(MainClass.bookeepingentrytext + ": " + Aut.username, MainClass.CRUDcontent);
        }
        private static void Dlete()
        {

            if (Control.key.Key == (ConsoleKey)MainClass.keybinds.Enter && ChoseUserposDelit != ChoseUserpos)
            {
                List<BookeepingentryObject> checusers = Sterealizer.desteruser<List<BookeepingentryObject>>(Startname.Cost);
                checusers.RemoveAt(ChoseUserpos);
                ChoseUserposDelit = ChoseUserpos;
                Sterealizer.steruser(checusers, Startname.Cost);
            }
        }
        private static void Read()
        {
            string find = null;
            string findteg = null;
            string text = null;
            Console.Clear();
            Menu.Meni(readmenutext + ": " + Aut.username, TabulatBookeepingentry.ListUsers(find, findteg, hadtabulate));
            while (Control.key.Key != (ConsoleKey)MainClass.keybinds.Escape)
            {
                Control.ReadKey(TabulatBookeepingentry.Finde.Count + 1);
                Control.MenuArrow(TabulatBookeepingentry.Finde.Count + 1);
                if (Control.key.Key == (ConsoleKey)MainClass.keybinds.Enter && Control.YCursorPos - 2 != 0)
                {
                    ChoseUser = TabulatBookeepingentry.Finde[Control.YCursorPos - 3];
                    ChoseUserpos = Control.YCursorPos - 3;
                }
                else if (Control.key.Key == (ConsoleKey)MainClass.keybinds.Enter && Control.YCursorPos - 2 == 0)
                {
                    Console.SetCursorPosition(9, Control.YCursorPos);
                    text = Console.ReadLine();
                    findteg = text.Split(": ")[0];
                    if (text.Split(": ").Length == 2)
                        find = text.Split(": ")[1];
                    Console.Clear();
                    Menu.Meni(readmenutext + ": " + Aut.username, TabulatBookeepingentry.ListUsers(find, findteg, hadtabulate));
                }
            }
            Console.Clear();
            Menu.Meni(MainClass.bookeepingentrytext + ": " + Aut.username, MainClass.CRUDcontent);
        }
        private static void Update()
        {

            Console.Clear();
            Menu.Meni(updatemenutext + ": " + Aut.username, MainClass.CUBPcontent);
            BookeepingentryObject newe = new BookeepingentryObject();
            while (Control.key.Key != (ConsoleKey)MainClass.keybinds.Enter)
            {
                ChoseUserpos = Menu.MenuCUBP(newe, ChoseUserpos, true);//true Update
            }
            Console.Clear();
            Menu.Meni(MainClass.bookeepingentrytext + ": " + Aut.username, MainClass.CRUDcontent);

        }
    }
}