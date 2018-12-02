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
    [Activity(Label = "CVPIInfoActivity",MainLauncher = false)]
    public class CPVIInfoActivity : Activity
    {
        int count;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.CPVI);

            var instructionsLabel = FindViewById<TextView>(Resource.Id.instructionLabel);
            var clickButton = FindViewById<Button>(Resource.Id.clickButton);
            var clickCountLabel = FindViewById<TextView>(Resource.Id.countLabel);

            if (savedInstanceState != null)
                count = savedInstanceState.GetInt("count");
            clickCountLabel.Text = count.ToString();



            clickButton.Click += delegate
            {
                if (count >= 1 && count < 6)
                    instructionsLabel.Text = "At least you have voted.";
                if (count >= 6 && count < 10)
                    instructionsLabel.Text = "Your a voter.";
                if (count >= 10 && count < 15)
                    instructionsLabel.Text = "You are a serious voter.";
                if (count > 15)
                    instructionsLabel.Text = "You are a voting master.";
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