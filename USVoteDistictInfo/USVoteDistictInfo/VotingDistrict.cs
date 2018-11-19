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
        public string CPVA { get; set; }
        public string Representative { get; set; }

        private List<VotingDistrict> oregon = new List<VotingDistrict>();
        private List<VotingDistrict> california = new List<VotingDistrict>();
        private List<VotingDistrict> washington = new List<VotingDistrict>();
        private List<VotingDistrict> idaho = new List<VotingDistrict>();

        //Add District information to the lists
        public void AddDistrictInfoToLists()
        {
            oregon.Add(AddVotingDistrict("OR", "District 1", "Democrat", "D+9", "Suzanne Bonamici"));
            oregon.Add(AddVotingDistrict("OR", "District 2", "Republican", "R+11", "Greg Walden"));
            oregon.Add(AddVotingDistrict("OR", "District 3", "Democrat", "D+24", "Earl Blumenaur"));
            oregon.Add(AddVotingDistrict("OR", "District 4", "Democrat", "EVEN", "Peter Dafazio"));
            oregon.Add(AddVotingDistrict("OR", "District 5", "Democrat", "EVEN", "Kurt Schrauder"));
            washington.Add(AddVotingDistrict("WA", "District 1", "Democrat", "D+6", "Suzan DelBene"));
            washington.Add(AddVotingDistrict("WA", "District 2", "Democrat", "D+10", "Rick Larsen"));
            washington.Add(AddVotingDistrict("WA", "District 3", "Republican", "R+4", "Jamie Herrera"));
            washington.Add(AddVotingDistrict("WA", "District 4", "Republican", "R+13", "Dan Newhouse"));
            washington.Add(AddVotingDistrict("WA", "District 5", "Republican", "R+8", "Cathy McMorris"));
            washington.Add(AddVotingDistrict("WA", "District 6", "Democrat", "D+6", "Derek Kilmer"));
            washington.Add(AddVotingDistrict("WA", "District 7", "Democrat", "D+33", "Pramila Jayapal"));
            washington.Add(AddVotingDistrict("WA", "District 8", "Republican", "EVEN", "Dave Reichert"));
            washington.Add(AddVotingDistrict("WA", "District 9", "Democrat", "D+21", "Adam Smith"));
            washington.Add(AddVotingDistrict("WA", "District 10", "Democrat", "D+5", "Dennis Heck"));
            idaho.Add(AddVotingDistrict("ID", "District 1", "Republican", "R+21", "Paul Labrador"));
            idaho.Add(AddVotingDistrict("ID", "District 2", "Republican", "R+17", "Mike Simpson"));

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
        public VotingDistrict AddVotingDistrict(string state, string name, string pa, string cpva, string rep)
        {
            VotingDistrict district = new VotingDistrict
            {
                State = state,
                Name = name,
                PoliticalAffiliation = pa,
                CPVA = cpva,
                Representative = rep
            };
            return district;
        }
    }
}