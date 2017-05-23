using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;

namespace AndroidNotificationsExample
{
    [Activity(Label = "AndroidNotificationsExample", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {

        private static readonly int btnClickNotification = 9999;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);

            var btnSend = FindViewById<Button>(Resource.Id.btnSend);

            btnSend.Click += BtnSend_Click;
        }

        private void BtnSend_Click(object sender, System.EventArgs e)
        {
            Bundle valuesSend = new Bundle();
            valuesSend.PutString("sendContent", "This is content sent from activity 1");

            Intent newIntent = new Intent(this, typeof(Second_Activity));

            newIntent.PutExtras(valuesSend);

            Android.Support.V4.App.TaskStackBuilder stackBuilder = new Android.Support.V4.App.TaskStackBuilder.
        }
    }
}

