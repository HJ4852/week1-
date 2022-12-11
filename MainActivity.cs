using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using AndroidX.AppCompat.App;
using System;

namespace W1_Friday_activity
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        private TextView txtNum1;
        private double num1,calculation;
        private Button na, nu, au, an, un;

        protected override void OnCreate(Bundle savedInstanceState)
        {
           
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.layout1);
            na = FindViewById<Button>(Resource.Id.btnna);
            nu = FindViewById<Button>(Resource.Id.btnnu);
            au = FindViewById<Button>(Resource.Id.btnau);
            an = FindViewById<Button>(Resource.Id.btnan);
            un = FindViewById<Button>(Resource.Id.btnun);
            txtNum1 = FindViewById<TextView>(Resource.Id.txtNum1);
            na.Click += na_click;
            nu.Click += nu_click;
            au.Click += au_click;
            an.Click += an_click;
            un.Click += un_click;
        }

        private void na_click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(txtNum1.Text);
            calculation = num1 * 0.94;
            string result = Convert.ToString(calculation);
            Toast.MakeText(context: this, text: result, duration: ToastLength.Long).Show();
        }
        private void nu_click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(txtNum1.Text);
            calculation = num1 * 0.64;
            string result = Convert.ToString(calculation);
            Toast.MakeText(context: this, text: result, duration: ToastLength.Long).Show();
        }
        private void au_click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(txtNum1.Text);
            calculation = num1 * 0.68;
            string result = Convert.ToString(calculation);
            Toast.MakeText(context: this, text: result, duration: ToastLength.Long).Show();
        }
        private void an_click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(txtNum1.Text);
            calculation = num1 * 1.06;
            string result = Convert.ToString(calculation);
            Toast.MakeText(context: this, text: result, duration: ToastLength.Long).Show();
        }
        private void un_click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(txtNum1.Text);
            calculation = num1 * 1.56;
            string result = Convert.ToString(calculation);
            Toast.MakeText(context: this, text: result, duration: ToastLength.Long).Show();
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}