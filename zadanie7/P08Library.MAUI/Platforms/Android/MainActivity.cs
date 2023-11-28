using Android.App;
using Android.Content.PM;
using Android.OS;

namespace P08Library.MAUI
{
    [Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density)]
    public class MainActivity : MauiAppCompatActivity
    {
    }

    protected override void OnCreate(Bundle savedInstanceState)
    {
#if DEBUG
        HttpsURLConnection.DefaultHostnameVerifier = new AllowAllHostnameVerifier();
#endif
        base.OnCreate(savedInstanceState);
    }
}
