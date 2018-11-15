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
    public class VotingDistrict
    {
        public string Name { get; set; }
        public string State { get; set; }
        public string PoliticalAffiliation { get; set; }

        private List<VotingDistrict> oregon = new List<VotingDistrict>();
        private List<VotingDistrict> california = new List<VotingDistrict>();
        private List<VotingDistrict> washington = new List<VotingDistrict>();
        private List<VotingDistrict> idaho = new List<VotingDistrict>();

        //Add District information to the lists
        public void AddDistrictInfoToLists()
        {
            oregon.Add(new VotingDistrict { State = "OR", Name = "District 1", PoliticalAffiliation = "Democrat" });
            oregon.Add(new VotingDistrict { State = "OR", Name = "District 2", PoliticalAffiliation = "Democrat" });
            oregon.Add(new VotingDistrict { State = "OR", Name = "District 3", PoliticalAffiliation = "Democrat" });
            oregon.Add(new VotingDistrict { State = "OR", Name = "District 4", PoliticalAffiliation = "Democrat" });
            california.Add(new VotingDistrict { State = "CA", Name = "District 1", PoliticalAffiliation = "Democrat" });
            california.Add(new VotingDistrict { State = "CA", Name = "District 2", PoliticalAffiliation = "Democrat" });
            california.Add(new VotingDistrict { State = "CA", Name = "District 3", PoliticalAffiliation = "Democrat" });
            california.Add(new VotingDistrict { State = "CA", Name = "District 4", PoliticalAffiliation = "Democrat" });
        }

        public List<VotingDistrict> GetStateDistrictList(string stateName)
        {
            if (stateName == "Oregon")
                return oregon;
            if (stateName == "California")
                return california;
            if (stateName == "Idaho")
                return idaho;
            else
                return washington;
        }
    }
}