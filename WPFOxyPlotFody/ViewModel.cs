using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace WPFOxyPlotFody
{
    [ImplementPropertyChanged]
    class ViewModel
    {
        Random rand = new Random();
        public Collection<CollectionDataValue> Data { get; set; }

        public class CollectionDataValue
        {
            public double xData { get; set; }
            public double yData { get; set; }
        }


        public double RandomNumberValue { get; set; }

        public double ExampleValue { get; set; }

        public ViewModel()
        {
            DispatcherTimer dispatcherTimer = new DispatcherTimer();
            dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);
            dispatcherTimer.Interval = new TimeSpan(0, 0, 1);
            dispatcherTimer.Start();

            Data = new Collection<CollectionDataValue>();
            ExampleValue = 0;

        }

        /// <summary>
        /// Handles the Tick event of the dispatcherTimer control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {

            
            RandomNumberValue = 21.5 + rand.NextDouble();
            Data.Add(new CollectionDataValue { xData = ExampleValue, yData = 21.5 + rand.NextDouble() });
            ExampleValue++;

        } 
    }
}
