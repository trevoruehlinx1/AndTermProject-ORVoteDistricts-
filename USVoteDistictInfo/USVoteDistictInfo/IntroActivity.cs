using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;
using System.Collections.Generic;
using USVoteDistictInfo;
using Android.Content;

namespace USVoteDistictInfo
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = false)]
    public class IntroActivity : AppCompatActivity
    {
        string selectedState;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.introActivity);

            string affiliation = Intent.GetStringExtra("affiliation");

            var submitButton = FindViewById<Button>(Resource.Id.submitButton);
            var stateImageView = FindViewById<ImageView>(Resource.Id.stateImage);
            if(affiliation == "republican")
                stateImageView.SetImageResource(Resource.Drawable.RepublicanImage);
            if (affiliation == "democrat")
                stateImageView.SetImageResource(Resource.Drawable.DemocraticDonkey);
            if (affiliation == "independent")
                stateImageView.SetImageResource(Resource.Drawable.IndependentImage);
            if (affiliation == "unaffiliated")
                stateImageView.SetImageResource(Resource.Drawable.NoAffiliation);


            //STATE SPINNER INITIALIZATION
            AppInfo appInfo = new AppInfo();
            var stateSpinner = FindViewById<Spinner>(Resource.Id.stateSpinner);
            var adapter = new ArrayAdapter(this, Android.Resource.Layout.SimpleSpinnerItem, appInfo.GetStateNamesForSpinner());
            stateSpinner.Adapter = adapter;

            // Event handler for selected spinner item
            selectedState = "";
            stateSpinner.ItemSelected += delegate (object sender, AdapterView.ItemSelectedEventArgs e)
            {
                Spinner spinner = (Spinner)sender;
                selectedState = (string)spinner.GetItemAtPosition(e.Position);
                submitButton.Text = "See the voting districts for " + selectedState;
            };
            submitButton.Click += delegate
            {
                Intent intent = new Intent(this, typeof(DistrictListActivity));
                intent.PutExtra("selectedState", selectedState);
                StartActivity(intent);
            };
            var CVPIInfoButton = FindViewById<Button>(Resource.Id.button1);
            CVPIInfoButton.Click += delegate
            {
                Intent CVPIIntent = new Intent(this, typeof(CVPIInfoActivity));
                StartActivity(CVPIIntent);
            };
        }
        protected override void OnSaveInstanceState(Bundle outState)
        {
            base.OnSaveInstanceState(outState);
        }
    }
}

