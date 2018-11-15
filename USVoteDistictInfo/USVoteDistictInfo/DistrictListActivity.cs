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
    [Activity(Label = "DistrictListActivity")]
    public class DistrictListActivity : ListActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here

            // Initialize the list and array for the list
            VotingDistrict votingDistrict = new VotingDistrict();
            votingDistrict.AddDistrictInfoToLists();
            string selectedState = Intent.GetStringExtra("selectedState");
            List<VotingDistrict> districtList = votingDistrict.GetStateDistrictList(selectedState);
            string[] districtArray = new string[districtList.Count];

            for (int i = 0; i < districtArray.Length; i++)
            {
                districtArray[i] =
                   districtList[i].State +" " + districtList[i].Name +" "+ districtList[i].PoliticalAffiliation;
            }

            // Create your application here
            ListAdapter = new ArrayAdapter<string>(this, Resource.Layout.list_item,districtArray);

            ListView.TextFilterEnabled = true;
        }
    }
}