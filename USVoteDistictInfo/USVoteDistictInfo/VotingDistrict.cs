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
        public string CPVI { get; set; }
        public string Representative { get; set; }
        List<VotingDistrict> Oregon { get { return oregon; } }

        private List<VotingDistrict> oregon = new List<VotingDistrict>();
        private List<VotingDistrict> california = new List<VotingDistrict>();
        private List<VotingDistrict> washington = new List<VotingDistrict>();
        private List<VotingDistrict> idaho = new List<VotingDistrict>();

        //Add District information to the lists
        public void AddDistrictInfoToLists()
        {
            //oregon.Add(new VotingDistrict { State = "", Name = "", PoliticalAffiliation = "", CPVI = "", Representative = "" });
            oregon.Add(AddDistrict("OR", "District 1", "Democrat", "D+9", "Suzanne Bonamici"));
            oregon.Add(AddDistrict("OR", "District 2", "Republican", "R+11", "Greg Walden"));
            oregon.Add(AddDistrict("OR", "District 3", "Democrat", "D+24", "Earl Blumenaur"));
            oregon.Add(AddDistrict("OR", "District 4", "Democrat", "EVEN", "Peter Dafazio"));
            oregon.Add(AddDistrict("OR", "District 5", "Democrat", "EVEN", "Kurt Schrauder"));
            washington.Add(AddDistrict("WA", "District 1", "Democrat", "D+6", "Suzan DelBene"));
            washington.Add(AddDistrict("WA", "District 2", "Democrat", "D+10", "Rick Larsen"));
            washington.Add(AddDistrict("WA", "District 3", "Republican", "R+4", "Jamie Herrera"));
            washington.Add(AddDistrict("WA", "District 4", "Republican", "R+13", "Dan Newhouse"));
            washington.Add(AddDistrict("WA", "District 5", "Republican", "R+8", "Cathy McMorris"));
            washington.Add(AddDistrict("WA", "District 6", "Democrat", "D+6", "Derek Kilmer"));
            washington.Add(AddDistrict("WA", "District 7", "Democrat", "D+33", "Pramila Jayapal"));
            washington.Add(AddDistrict("WA", "District 8", "Republican", "EVEN", "Dave Reichert"));
            washington.Add(AddDistrict("WA", "District 9", "Democrat", "D+21", "Adam Smith"));
            washington.Add(AddDistrict("WA", "District 10", "Democrat", "D+5", "Dennis Heck"));
            idaho.Add(AddDistrict("ID", "District 1", "Republican", "R+21", "Paul Labrador"));
            idaho.Add(AddDistrict("ID", "District 2", "Republican", "R+17", "Mike Simpson"));

        }

        public List<VotingDistrict> GetStateDistrictList(string stateName)
        {
            if (stateName == "Oregon")
                return oregon;
            if (stateName == "Washington")
                return washington;
            if (stateName == "Idaho")
                return idaho;
            else
                return california;
        }
        public VotingDistrict AddDistrict(string state, string name, string pa, string cpvi, string rep)
        {
            VotingDistrict district = new VotingDistrict
            {
                State = state,
                Name = name,
                PoliticalAffiliation = pa,
                CPVI = cpvi,
                Representative = rep
            };
            return district;
        }
    }
}