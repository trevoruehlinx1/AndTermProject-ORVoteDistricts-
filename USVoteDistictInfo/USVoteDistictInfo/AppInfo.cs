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
                ageMessage = "An appropriate number of votes for someone under 18 years old.";
            else if (count == 1)
                ageMessage = "An appropriate number of trips to the ballot box for someone under 20";
            else
            {
                age = count * 2 + 18;
                ageMessage = count+" is an acceptable number of votes for someone who is " +age+ 
                                " years old or younger.";
            }
            return ageMessage;
        }
    }
}