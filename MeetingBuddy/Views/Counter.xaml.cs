using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MeetingBuddy.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Counter : ContentPage
    {
        private int count = 0;
        public Counter()
        {
            InitializeComponent();
        }

        private void IncrementCounterClicked(object sender, EventArgs e)
        {
            count++;
            CounterLabel.Text = count.ToString();
        }
    }
}