using Android.App;
using Android.OS;
using Android.Runtime;
using AndroidX.AppCompat.App;
using Android.Widget;

namespace Droid_Calculator
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
          
            Button sumar = FindViewById<Button>(Resource.Id.Sumar);
            Button restar = FindViewById<Button>(Resource.Id.Restar);
            Button multiplicar = FindViewById<Button>(Resource.Id.Multiplicar);
            Button dividir = FindViewById<Button>(Resource.Id.Dividir);
            TextView resultado = FindViewById<TextView>(Resource.Id.Resultado);
            

            sumar.Click += (sender, e) =>
            {
                EditText cantidad1 = FindViewById<EditText>(Resource.Id.Cantidad1);
                EditText cantidad2 = FindViewById<EditText>(Resource.Id.Cantidad2);
                int factor1 = int.Parse(cantidad1.Text);
                int factor2 = int.Parse(cantidad2.Text);
                resultado.Text = (factor1 + factor2).ToString();
            };
            restar.Click += (sender, e) =>
            {
                EditText cantidad1 = FindViewById<EditText>(Resource.Id.Cantidad1);
                EditText cantidad2 = FindViewById<EditText>(Resource.Id.Cantidad2);
                int factor1 = int.Parse(cantidad1.Text);
                int factor2 = int.Parse(cantidad2.Text);
                resultado.Text = (factor1 - factor2).ToString();
            };
            multiplicar.Click += (sender, e) =>
            {
                EditText cantidad1 = FindViewById<EditText>(Resource.Id.Cantidad1);
                EditText cantidad2 = FindViewById<EditText>(Resource.Id.Cantidad2);
                int factor1 = int.Parse(cantidad1.Text);
                int factor2 = int.Parse(cantidad2.Text);
                resultado.Text = (factor1 * factor2).ToString();
            };
            dividir.Click += (sender, e) =>
            {
                EditText cantidad1 = FindViewById<EditText>(Resource.Id.Cantidad1);
                EditText cantidad2 = FindViewById<EditText>(Resource.Id.Cantidad2);
                int factor1 = int.Parse(cantidad1.Text);
                int factor2 = int.Parse(cantidad2.Text);
                resultado.Text = (factor1 / factor2).ToString();
            };
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
        
    }
}