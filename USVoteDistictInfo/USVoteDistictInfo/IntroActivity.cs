using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;
using System.Collections.Generic;
using USVoteDistictInfo;
using Android.Content;

namespace USVoteDistictInfo
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class IntroActivity : AppCompatActivity
    {
        string selectedState;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.introActivity);

            var submitButton = FindViewById<Button>(Resource.Id.submitButton);
            var stateImageView = FindViewById<ImageView>(Resource.Id.stateImage);
            stateImageView.SetImageResource(Resource.Drawable.VoteLogo);


            //STATE SPINNER INITIALIZATION
            AppInfo appInfo = new AppInfo();
            var stateSpinner = FindViewById<Spinner>(Resource.Id.stateSpinner);
            var adapter = new ArrayAdapter(this, Android.Resource.Layout.SimpleSpinnerItem, appInfo.GetStateNamesForSpinner());
            stateSpinner.Adapter = adapter;

            // Event handler for selected spinner item
            string selectedState = "";
            stateSpinner.ItemSelected += delegate (object sender, AdapterView.ItemSelectedEventArgs e)
            {
                Spinner spinner = (Spinner)sender;
                selectedState = (string)spinner.GetItemAtPosition(e.Position);
            };
            submitButton.Click += delegate
            {
                Intent intent = new Intent(this, typeof(DistrictListActivity));
                intent.PutExtra("selectedState", selectedState);
                StartActivity(intent);
            };
        }
    }
}

