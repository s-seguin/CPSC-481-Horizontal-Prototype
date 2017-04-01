using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Media;

namespace CPSC_481_Horizontal_Prototype.Classes
{
    public class LoadingAdorner : Adorner
    {
        public LoadingAdorner(UIElement adornerElement)
            : base(adornerElement)
        { }

        protected override void OnRender(System.Windows.Media.DrawingContext drawingContext)
        {
            double height = SystemParameters.PrimaryScreenHeight;
            double width = SystemParameters.PrimaryScreenWidth;

            drawingContext.DrawRectangle(Brushes.Gray, new Pen(Brushes.Gray, 1), new Rect(new Size(width, height)));
            base.OnRender(drawingContext);
        }
    }
}
