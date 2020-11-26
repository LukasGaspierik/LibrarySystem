using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terminal.Gui;

namespace LibrarySystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Application.Init();

            var top = Application.Top;

            Console.Title = "Kniznicny System";
            Colors.Base.Normal = Application.Driver.MakeAttribute(Color.White, Color.Black);

            var win = new Window()
            {
                Title = "Library System",
                Width = Dim.Fill(),
                Height = Dim.Fill()
            };

            var mat = new Window()
            {
                Title = "Matematika",
                Width = Dim.Fill(),
                Height = Dim.Fill(),
                Visible = true,

            };

            var Dej = new Window()
            {
                Title = "Dejepis",
                Width = Dim.Fill(),
                Height = Dim.Fill(),
                Visible = true,

            };

            var Ang = new Window()
            {
                Title = "Angličtina",
                Width = Dim.Fill(),
                Height = Dim.Fill(),
                Visible = true,

            };

            var Nej = new Window()
            {
                Title = "Nemčina",
                Width = Dim.Fill(),
                Height = Dim.Fill(),
                Visible = true,

            };

            var Pro = new Window()
            {
                Title = "Programovanie",
                Width = Dim.Fill(),
                Height = Dim.Fill(),
                Visible = true,

            };

            var Ele = new Window()
            {
                Title = "Elektrotechnika",
                Width = Dim.Fill(),
                Height = Dim.Fill(),
                Visible = true,

            };

            void TurnOnMath()
            {

                top.Add(mat);
                top.Redraw(new Rect(0, 0, Console.WindowWidth, Console.WindowHeight));

            }
            void TurnOnDej()
            {

                top.Add(Dej);
                top.Redraw(new Rect(0, 0, Console.WindowWidth, Console.WindowHeight));
            }
            void TurnOnAng()
            {

                top.Add(Ang);
                top.Redraw(new Rect(0, 0, Console.WindowWidth, Console.WindowHeight));

            }
            void TurnOnNej()
            {

                top.Add(Nej);
                top.Redraw(new Rect(0, 0, Console.WindowWidth, Console.WindowHeight));

            }
            void TurnOnPro()
            {

                top.Add(Pro);
                top.Redraw(new Rect(0, 0, Console.WindowWidth, Console.WindowHeight));

            }
            void TurnOnEle()
            {

                top.Add(Ele);
                top.Redraw(new Rect(0, 0, Console.WindowWidth, Console.WindowHeight));

            }


            int consoleCenter = Console.WindowWidth / 2;

            var btnMat = new Button(Console.WindowWidth / 2 - 7, 10, "Matematika");
            btnMat.Clicked += TurnOnMath;
            var btnDej = new Button(Console.WindowWidth / 2 - 6, 12, "Dejepis");
            btnDej.Clicked += TurnOnDej;
            var btnAng = new Button(Console.WindowWidth / 2 - 7, 14, "Angličtina");
            btnAng.Clicked += TurnOnAng;
            var btnNej = new Button(Console.WindowWidth / 2 - 6, 16, "Nemčina");
            btnNej.Clicked += TurnOnNej;
            var btnPro = new Button(Console.WindowWidth / 2 - 9, 18, "Programovanie");
            btnPro.Clicked += TurnOnPro;
            var btnEle = new Button(Console.WindowWidth / 2 - 10, 20, "Elektrotechnika");
            btnEle.Clicked += TurnOnEle;
            win.Add(
            //...
            btnAng,btnMat,btnDej,btnNej,btnPro,btnEle,
            //...

            new Label(consoleCenter - 37, 0, @"  _      _ _                             _____           _                 "),
            new Label(consoleCenter - 37, 1, @" | |    (_) |                           / ____|         | |                "),
            new Label(consoleCenter - 37, 2, @" | |     _| |__  _ __ __ _ _ __ _   _  | (___  _   _ ___| |_ ___ _ __ ___  "),
            new Label(consoleCenter - 37, 3, @" | |    | | '_ \| '__/ _` | '__| | | |  \___ \| | | / __| __/ _ \ '_ ` _ \ "),
            new Label(consoleCenter - 37, 4, @" | |____| | |_) | | | (_| | |  | |_| |  ____) | |_| \__ \ ||  __/ | | | | |"),
            new Label(consoleCenter - 37, 5, @" |______|_|_.__/|_|  \__,_|_|   \__, | |_____/ \__, |___/\__\___|_| |_| |_|"),
            new Label(consoleCenter - 37, 6, @"                                 __/ |          __/ |                      "),
            new Label(consoleCenter - 37, 7, @"                                |___/          |___/                       ")



            );
            mat.Add(
            new Label(0,0, "Autor"),
            new Label(0,1, "Počet Kníh"),
            new Label(0,2, "Počet Strán"),
            new Label(0,3, "Obsah"),
            new Label(0,4, "Požičané"),
            new Label(0,5, "Dostupné")


            );
            mat.Add(
            new Label(0, 0, "Autor"),
            new Label(0, 1, "Počet Kníh"),
            new Label(0, 2, "Počet Strán"),
            new Label(0, 3, "Obsah"),
            new Label(0, 4, "Požičané"),
            new Label(0, 5, "Dostupné")

             
            );
            Dej.Add(
            new Label(0, 0, "Autor"),
            new Label(0, 1, "Počet Kníh"),
            new Label(0, 2, "Počet Strán"),
            new Label(0, 3, "Obsah"),
            new Label(0, 4, "Požičané"),
            new Label(0, 5, "Dostupné")



            );
            Nej.Add(
            new Label(0, 0, "Autor"),
            new Label(0, 1, "Počet Kníh"),
            new Label(0, 2, "Počet Strán"),
            new Label(0, 3, "Obsah"),
            new Label(0, 4, "Požičané"),
            new Label(0, 5, "Dostupné")

            
            );
            Pro.Add(
            new Label(0, 0, "Autor"),
            new Label(0, 1, "Počet Kníh"),
            new Label(0, 2, "Počet Strán"),
            new Label(0, 3, "Obsah"),
            new Label(0, 4, "Požičané"),
            new Label(0, 5, "Dostupné")


            );
            Ele.Add(
            new Label(0, 0, "Autor"),
            new Label(0, 1, "Počet Kníh"),
            new Label(0, 2, "Počet Strán"),
            new Label(0, 3, "Obsah"),
            new Label(0, 4, "Požičané"),
            new Label(0, 5, "Dostupné")
 

            );
            Nej.Add(
            new Label(0, 0, "Autor"),
            new Label(0, 1, "Počet Kníh"),
            new Label(0, 2, "Počet Strán"),
            new Label(0, 3, "Obsah"),
            new Label(0, 4, "Požičané"),
            new Label(0, 5, "Dostupné")

                );


            top.Add(win);

            var menuBar = new MenuBar(new MenuBarItem[]
                {
                    new MenuBarItem("File", new MenuItem[]
                    {
                        new MenuItem("New project", "", () => {}),
                        new MenuItem("Open project", "", () => { }),
                        new MenuItem("Save project", "", () => { }),
                        new MenuItem("Export subtitles", "", () => { }),
                    }),
                    new MenuBarItem("Settings", new MenuItem[]
                    {

                    }),
                    new MenuBarItem("About", new MenuItem[]
                    {

                    }),
                }
            );

            top.Add(menuBar);
            Application.Run();
        }
    }
}