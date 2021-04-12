using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Alcohol
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            
        }

      

        private void DatePicker_OnDateSelected(object sender, DateChangedEventArgs e)
        {
            

            TimeSpan Age = DateTime.Now - e.NewDate;
            int AgeInYears = Convert.ToInt32(Age.TotalDays/365);
            int AgeDifference = Convert.ToInt32(21 - AgeInYears);

            if (AgeInYears> 21)
             {
                display.Text = $"You are legal! You are {AgeInYears} years";
            }else if( AgeInYears < 21)
            {
                display.Text = $"You are not legal! You need to wait {AgeDifference} years";
            }
        }


    }
}
