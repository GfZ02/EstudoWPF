using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace fuçando.Core
{
    class colors
    {

        public void Cores()
        {

        }

        public SolidColorBrush getcoroff()
        {
            Color color = new Color();
            color = Color.FromRgb(69, 70, 240);
            SolidColorBrush coro = new SolidColorBrush(color);

            return coro;
        }

        public SolidColorBrush getcoron()
        {
            Color color = new Color();
            color = Color.FromRgb(52, 123, 217);
            SolidColorBrush coro = new SolidColorBrush(color);

            return coro;
        }

        public SolidColorBrush getcorlb()
        {
            Color color = new Color();
            color = Color.FromRgb(227, 45, 250);
            SolidColorBrush coro = new SolidColorBrush(color);

            return coro;
        }

    }

}
