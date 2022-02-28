using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using AndroidX.AppCompat.App;

namespace task1
{
    [Activity(Label = "task1", Theme = "@style/AppTheme")]
    public class MainActivity : AppCompatActivity
    {
        private Button login;
        private ImageView fb, ig;
        private TextView user, pass, forgot,regsiter;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            login = FindViewById<Button>(Resource.Id.button1);
            fb = FindViewById<ImageView>(Resource.Id.imageView1);
            ig = FindViewById<ImageView>(Resource.Id.imageView2);
            forgot = FindViewById<TextView>(Resource.Id.forgot);
            regsiter = FindViewById<TextView>(Resource.Id.textView1);
            user = FindViewById<EditText>(Resource.Id.editText3);
            pass = FindViewById<EditText>(Resource.Id.editText4);
            fb.Click += Fb_Click;
            ig.Click += Ig_Click;
            login.Click += Login_Click;
            forgot.Click += Forgot_Click;
            regsiter.Click += Regsiter_Click;

        }

        private void Regsiter_Click(object sender, System.EventArgs e)
        {
            StartActivity(typeof(registerss));
            Finish();
        }

        private void Forgot_Click(object sender, System.EventArgs e)
        {
            Toast.MakeText(this, "OTP send this number ", ToastLength.Short).Show();
        }

        private void Login_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(user.Text) )
            {
                Toast.MakeText(this, "enter user data", ToastLength.Short).Show();
            }
            else if(string.IsNullOrEmpty(pass.Text))
            {
                Toast.MakeText(this, "enter password data", ToastLength.Short).Show();
            }
            else
            {
                Toast.MakeText(this, "login  successfully", ToastLength.Short).Show();
            }
        }

        private void Ig_Click(object sender, System.EventArgs e)
        {
            Toast.MakeText(this, "google sign in ", ToastLength.Short).Show();
        }

        private void Fb_Click(object sender, System.EventArgs e)
        {
            Toast.MakeText(this, "facebook sign in ", ToastLength.Short).Show();
        }
    
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}