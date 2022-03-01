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
using System.Text.RegularExpressions;

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
            bool isEmail = Regex.IsMatch(email.Text, @"^[a-z]([\w]*[\w\.]*(?!\.)@gmail.com)", RegexOptions.IgnoreCase);
            bool isUser = Regex.IsMatch(user.Text, @"^[a-z-A-Z]*$", RegexOptions.IgnoreCase);
            bool isName = Regex.IsMatch(name.Text, @"^[a-z-A-Z]*$", RegexOptions.IgnoreCase);

            if (string.IsNullOrEmpty(name.Text)  )
            {
                //Toast.MakeText(this, "enter name data", ToastLength.Short).Show();
                name.Error = "enter name data";
            }
            else if (!isName)
            {
                name.Error = "digit isnot allow";
            }


            else if(string.IsNullOrEmpty(email.Text))
            {
                //Toast.MakeText(this, "enter email data", ToastLength.Short).Show();
                email.Error = "enter email data";
            }
         
            else if(!isEmail)
            {

                email.Error = "Invalid email address";

            }
            
        
         

            else if (string.IsNullOrEmpty(user.Text))
            {
                //Toast.MakeText(this, "enter user data", ToastLength.Short).Show();
                user.Error = "enter user data";
            }
            else if (!isUser)
            {
                user.Error = "digit isnot allow";
            }

            else if (string.IsNullOrEmpty(pass.Text))
            {
                // Toast.MakeText(this, "enter password data", ToastLength.Short).Show();
                pass.Error = "enter password data";
            }
            else if ((pass.Text.Length) < 8)
            {
                //Toast.MakeText(this, "enter password 8 charater ", ToastLength.Short).Show();
                pass.Error = "cannot allow <8 character  ";
            }

            else
            {
                StartActivity(typeof(MainActivity));
                Finish();
            }
           
        }
    }
}