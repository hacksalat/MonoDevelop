using System;
using Gtk;

namespace Test002Widgets
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Application.Init();
            MainWindow win = new MainWindow();
            win.Show();

            Gtk.TextView view;
            Gtk.TextBuffer buffer;

            view = new Gtk.TextView();
            buffer = view.Buffer;

            buffer.Text = "Hello, this is some text";

            win.Add(view);
            win.ShowAll();
            Application.Run();
        }
    }
}
