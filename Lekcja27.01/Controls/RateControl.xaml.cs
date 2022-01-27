using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Controls
{
    /// <summary>
    /// Logica di interazione per RateControl.xaml
    /// </summary>
    public partial class RateControl : UserControl
    {
        private Ellipse[] circles;
        private int selectedValue;

        public SolidColorBrush SelectedColor { get; set; } = new SolidColorBrush(Colors.Yellow);
        public SolidColorBrush UnselectedColor { get; set; } = new SolidColorBrush(Colors.Gray);

        public Action<int> ValueChanged { get; set; }

        public int SelectedValue
        {
            get => selectedValue; 
            set
            {
                if(value>=0 && value<=circles.Length)
                {
                    selectedValue = value;
                    ColorCircles(selectedValue);
                    if(ValueChanged != null)
                    {
                        ValueChanged(selectedValue);
                    }
                }
            }
        }

        public RateControl()
        {
            InitializeComponent();
            circles = new Ellipse[circlesGrid.Children.Count];
            for(int i = 0; i < circles.Length; i++)
            {
                circles[i] = circlesGrid.Children[i] as Ellipse;
            }
            ColorCircles(selectedValue);
        }

        private void ColorCircles(int nr)
        {
            for (int i = 0; i < circles.Length; i++)
            {
                if (i < nr)
                {
                    circles[i].Fill = SelectedColor;
                }
                else
                {
                    circles[i].Fill = UnselectedColor;
                }
            }
        }

        private void Ellipse_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(sender is Ellipse circle)
            {
                int nr = int.Parse(circle.Tag.ToString());
                SelectedValue = nr;
            }
        }

        private void Ellipse_MouseEnter(object sender, MouseEventArgs e)
        {
            if (sender is Ellipse circle)
            {
                int nr = int.Parse(circle.Tag.ToString());
                ColorCircles(nr);
            }
        }

        private void Ellipse_MouseLeave(object sender, MouseEventArgs e)
        {
            ColorCircles(SelectedValue);
        }
    }
}
