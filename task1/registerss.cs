using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace task1
{
    [Activity(Label = "registerss")]
    public class registerss : Activity
    {
        private Button reg;
        private ImageView fb, ig;
        private EditText name, email, user, pass;
        private TextView log;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.register);
            // Create your application here
            reg = FindViewById<Button>(Resource.Id.button1);
            fb = FindViewById<ImageView>(Resource.Id.imageView1);
            ig = FindViewById<ImageView>(Resource.Id.imageView2);
            name = FindViewById<EditText>(Resource.Id.editText1);
            email = FindViewById<EditText>(Resource.Id.editText2);
            user = FindViewById<EditText>(Resource.Id.editText3);
            pass = FindViewById<EditText>(Resource.Id.editText4);
            log = FindViewById<TextView>(Resource.Id.textView1);
            reg.Click += Reg_Click;
            fb.Click += Fb_Click;
            ig.Click += Ig_Click;
            log.Click += Log_Click;
        }

        private void Log_Click(object sender, EventArgs e)
        {
            StartActivity(typeof(MainActivity));
            Finish();
        }

        private void Ig_Click(object sender, EventArgs e)
        {
            Toast.MakeText(this, "google sign in ", ToastLength.Short).Show();
        }

        private void Fb_Click(object sender, EventArgs e)
        {
            Toast.MakeText(this, "facebook sign in ", ToastLength.Short).Show();
        }

        private void Reg_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(name.Text)   || string.IsNullOrEmpty(user.Text) || string.IsNullOrEmpty(pass.Text))
            {
                Toast.MakeText(this, "enter name data", ToastLength.Short).Show();
            }
            else if(string.IsNullOrEmpty(email.Text))
            {
                Toast.MakeText(this, "enter email data", ToastLength.Short).Show();
            }
            else if (string.IsNullOrEmpty(user.Text))
            {
                Toast.MakeText(this, "enter user data", ToastLength.Short).Show();
            }
            else if (string.IsNullOrEmpty(pass.Text))
            {
                Toast.MakeText(this, "enter password data", ToastLength.Short).Show();
            }

            else
            {
                StartActivity(typeof(MainActivity));
                Finish();
            }
        }
    }
}