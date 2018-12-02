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
    [Activity(Label = "CVPIInfoActivity",MainLauncher = true)]
    public class CVPIInfoActivity : Activity
    {
        int count;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.CVPI);

            var instructionsLabel = FindViewById<TextView>(Resource.Id.instructionLabel);
            var clickButton = FindViewById<Button>(Resource.Id.clickButton);
            var clickCountLabel = FindViewById<TextView>(Resource.Id.countLabel);

            if (savedInstanceState != null)
                count = savedInstanceState.GetInt("count");
            clickCountLabel.Text = count.ToString();



            clickButton.Click += delegate
            {
                count++;
                clickCountLabel.Text = count.ToString();
            };
        }
        protected override void OnSaveInstanceState(Bundle outState)
        {
            outState.PutInt("count", count);
            base.OnSaveInstanceState(outState);
        }
    }
}