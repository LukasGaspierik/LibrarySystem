using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terminal.Gui;
using System.IO;

namespace LibrarySystem
{
    class Program
    {
        private static Toplevel top;
        static void Main(string[] args)
        {
            Application.Init();
            top = Application.Top; 
            Console.Title = "Kniznicny System";
            Colors.Base.Normal = Application.Driver.MakeAttribute(Color.White, Color.Black);

            var win = new Window()
            {
                Title = "Library System",
                Width = Dim.Fill(),
                Height = Dim.Fill()

            };


            OpenDialog opendialog = new OpenDialog("Open Bookfile", "Open Bookfile");

            void OnClickEvent()
            {
                Button btnCLick = new Button(50, 19, "Read");
                opendialog.Add(btnCLick);
                btnCLick.Clicked += onSelectBook;
                Window temp = new Window();
                temp.Add(opendialog);
                top.Add(temp);

            }

            void onSelectBook()
            {
                string[] readText = File.ReadAllLines(opendialog.FilePath.ToString());
                string názov = readText[0];
                string autor = readText[1];
                string knihydokopy = readText[2];
                string pozkniny = readText[3];
                string knihykdisp = readText[4];
                string pocetstran = readText[5];

                var preview = new Window()
                {
                    Title = názov,
                    Width = Dim.Fill(),
                    Height = Dim.Fill(),
                    Visible = true,
                     
                };

                preview.Add(
                    new Label(0, 0, "Nazov: " + názov),
                    new Label(0, 1, "Author: " + autor),
                    new Label(0, 2, "Knihy do kopy: " + knihydokopy),
                    new Label(0, 3, "Požičané kniny: " + pozkniny),
                    new Label(0, 4, "Knihy k dispozícii: " + knihykdisp),
                    new Label(0, 5, "Počet strán: " + pocetstran)
                );


                top.Add(preview);

            };

            

            




            int consoleCenter = Console.WindowWidth / 2;

            var btnFindBook = new Button(Console.WindowWidth / 2 - 7, 13, "FIND BOOKS");
            btnFindBook.Clicked += OnClickEvent;

            

            win.Add(btnFindBook);
            win.Add(
                new Label(consoleCenter - 37, 0, @"  _      _ _                             _____           _                 "),
                new Label(consoleCenter - 37, 1, @" | |    (_) |                           / ____|         | |                "),
                new Label(consoleCenter - 37, 2, @" | |     _| |__  _ __ __ _ _ __ _   _  | (___  _   _ ___| |_ ___ _ __ ___  "),
                new Label(consoleCenter - 37, 3, @" | |    | | '_ \| '__/ _` | '__| | | |  \___ \| | | / __| __/ _ \ '_ ` _ \ "),
                new Label(consoleCenter - 37, 4, @" | |____| | |_) | | | (_| | |  | |_| |  ____) | |_| \__ \ ||  __/ | | | | |"),
                new Label(consoleCenter - 37, 5, @" |______|_|_.__/|_|  \__,_|_|   \__, | |_____/ \__, |___/\__\___|_| |_| |_|"),
                new Label(consoleCenter - 37, 6, @"                                 __/ |          __/ |                      "),
                new Label(consoleCenter - 37, 7, @"                                |___/          |___/                       ")

                ) ;
                
            top.Add(win);

            /*
             * var menuBar = new MenuBar(new MenuBarItem[] {
                new MenuBarItem("File", new MenuItem[] {
                    new MenuItem ("SKOLA", "", () => Application.Run (opendialog)),
                    new MenuItem ("EPIKA", "", () => Application.Run(savedialog)),
                    new MenuItem ("POEZIA", "", () => Application.Run (opendialog)),
                    new MenuItem ("ROMAN", "", () => Application.Run(savedialog)),
                    new MenuItem ("CREDITS", "", () => {

                    var a = MessageBox.Query("CREDITS", "Make Lukáš and David");


                    }),
                    new MenuBarItem("Settings",new MenuItem[] {


                    }),
                    new MenuBarItem("About", new MenuItem[] {



                    }),
                }),

            }
            );
            top.Add(menuBar);
            */
            Application.Run();
            Application.Run();


        }
    }
}
