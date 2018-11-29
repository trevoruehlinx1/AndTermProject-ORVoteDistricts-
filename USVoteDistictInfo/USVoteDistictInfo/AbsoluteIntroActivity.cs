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
    [Activity(Label = "AbsoluteIntroActivity",MainLauncher = true)]
    public class AbsoluteIntroActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.AbsoluteIntroActivity);

            // Create your application here
            var submitButton = FindViewById<Button>(Resource.Id.submitButton);
            var absoluteImage = FindViewById<ImageView>(Resource.Id.absoluteImage);
            var republicanCheckbox = FindViewById<RadioButton>(Resource.Id.republicanButton);
            var democratCheckbox = FindViewById<RadioButton>(Resource.Id.DemocratButton);
            var independentCheckbox = FindViewById<RadioButton>(Resource.Id.independentButton);
            var unaffiliatedCheckbox = FindViewById<RadioButton>(Resource.Id.noneButton);

            absoluteImage.SetImageResource(Resource.Drawable.VoteLogo);

            submitButton.Click += delegate
            {
                Intent introIntent = new Intent(this, typeof(IntroActivity));
                if (republicanCheckbox.Checked == true)
                    introIntent.PutExtra("affiliation", "republican");
                if (democratCheckbox.Checked == true)
                    introIntent.PutExtra("affiliation", "democrat");
                if (independentCheckbox.Checked == true)
                    introIntent.PutExtra("affiliation", "independent");
                if (unaffiliatedCheckbox.Checked == true)
                    introIntent.PutExtra("affiliation", "unaffiliated");
                StartActivity(introIntent);
            };
        }
    }
}