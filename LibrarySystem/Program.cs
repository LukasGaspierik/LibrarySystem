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

            var win = new Window()
            {
                Title = "Library System",
                Width = Dim.Fill(),
                Height = Dim.Fill()
            };
            win.Add(
                new Label(Console.WindowWidth/2-8,0,"Library System"),
                new Button(Console.WindowWidth/2-9,2,"Search Books")
                
                
                
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