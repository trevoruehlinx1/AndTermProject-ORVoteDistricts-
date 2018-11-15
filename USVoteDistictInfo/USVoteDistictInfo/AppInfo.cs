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
            stateNamesForSpinner.Add("Oregon");
            stateNamesForSpinner.Add("California");
            stateNamesForSpinner.Add("Washington");
            stateNamesForSpinner.Add("Idaho");
            return stateNamesForSpinner;
        } 
    }
}