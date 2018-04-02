using System;
using System.Timers;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Reflection;

namespace InfoBox
{
    /// <summary>
    /// Interaction logic for InfoBoxWindow.xaml
    /// </summary>
    public partial class InfoBoxWindow : Window
    {
        // Constructor for class;
        // msg -> text to be displayed in message box.
        // delay -> time to keep window open, in milliseconds.
        // warn -> false for an information box, true for a warning box.
        public InfoBoxWindow(string msg = "Information", int delay = 5000, bool warn = false)
        {
            InitializeComponent();
            string pth = System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            this.Icon = BitmapFrame.Create(new Uri("pack://application:,,,/info.ico", UriKind.RelativeOrAbsolute));
            // If warning box set appropriate window decorations.
            if (warn)
            {
                this.Icon = BitmapFrame.Create(new Uri("pack://application:,,,/warn.ico", UriKind.RelativeOrAbsolute));
                this.Title = "Warning";
                var b = new BrushConverter();
                this.Background = (Brush)b.ConvertFrom("#FFFBB3B3");
            }
            // Set message, start timer, and open window.
            content.Text = msg;
            Timer t = new Timer();
            t.Interval = delay;
            t.Elapsed += new ElapsedEventHandler(t_end);
            t.Start();
        }
        // Close window after elapsed time.
        private void t_end(object sender, ElapsedEventArgs e)
        {
            this.Dispatcher.Invoke(new Action(() =>
            {
                this.Close();
            }), null);
        }
    }
}
