using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace USVoteDistictInfo
{
    public class AppInfo
    {
        private List<string> stateNamesForSpinner = new List<string>();

        public List<string> GetStateNamesForSpinner()
        {
            stateNamesForSpinner.Add("Alabama");
            stateNamesForSpinner.Add("Arkansas");
            stateNamesForSpinner.Add("California");
            stateNamesForSpinner.Add("Colorado");
            stateNamesForSpinner.Add("Idaho");
            stateNamesForSpinner.Add("Oregon");
            stateNamesForSpinner.Add("Washington");

            return stateNamesForSpinner;
        } 
        
        public string GetAgeMessage(int count)
        {
            string ageMessage = "";
            int age;
            if (count == 0)
                ageMessage = "You must be under 18";
            else if (count == 1)
                ageMessage = "You must be something like 18 or 19 years old.";
            else
            {
                age = count * 2 + 18;
                ageMessage = "You must be somewhere around " + age + " years old.";
            }
            return ageMessage;
        }
    }
}