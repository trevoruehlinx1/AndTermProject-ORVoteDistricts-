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
        string message;
        AppInfo appInfo;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.CPVI);

            var instructionsLabel = FindViewById<TextView>(Resource.Id.instructionLabel);
            var plusClickButton = FindViewById<Button>(Resource.Id.clickButton);
            var minusClickButton = FindViewById<Button>(Resource.Id.clickButton2);
            var clickCountLabel = FindViewById<TextView>(Resource.Id.countLabel);
            appInfo = new AppInfo();

            if (savedInstanceState != null)
            {
                count = savedInstanceState.GetInt("count");
                message = savedInstanceState.GetString("ageMessage");
                clickCountLabel.Text = count.ToString();
                instructionsLabel.Text = message;
            }
            plusClickButton.Click += delegate
            {
                count++;
                clickCountLabel.Text = count.ToString();
                instructionsLabel.Text = appInfo.GetAgeMessage(count);
            };
            minusClickButton.Click += delegate
            {
                count--;
                clickCountLabel.Text = count.ToString();
                instructionsLabel.Text = appInfo.GetAgeMessage(count);
            };
        }
        protected override void OnSaveInstanceState(Bundle outState)
        {
            outState.PutInt("count", count);
            outState.PutString("ageMessage", appInfo.GetAgeMessage(count));
            base.OnSaveInstanceState(outState);
        }
    }
}