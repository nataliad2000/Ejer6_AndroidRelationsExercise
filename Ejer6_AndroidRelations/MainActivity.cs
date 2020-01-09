using System;
using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Support.Design.Widget;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;
using AlertDialog = Android.App.AlertDialog;

namespace Ejer6_AndroidRelations
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme.NoActionBar", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        private Button MuestraDialog;
        private EditText edittext;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_main);

            Android.Support.V7.Widget.Toolbar toolbar = FindViewById<Android.Support.V7.Widget.Toolbar>(Resource.Id.toolbar);
            SetSupportActionBar(toolbar);

            FloatingActionButton fab = FindViewById<FloatingActionButton>(Resource.Id.fab);
            fab.Click += FabOnClick;
            MostrarEditText();

            edittext.KeyPress += (object sender, View.KeyEventArgs e) =>
              {
                  e.Handled = false;
                  if (e.Event.Action == KeyEventActions.Down && e.KeyCode == Keycode.Enter)
                  {
                      Toast.MakeText(this, edittext.Text, ToastLength.Short).Show();
                      e.Handled = true;
                  }
              };
        }

       

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.menu_main, menu);
            return true;
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            int id = item.ItemId;
            if (id == Resource.Id.action_settings)
            {
                return true;
            }

            return base.OnOptionsItemSelected(item);
        }

        private void FabOnClick(object sender, EventArgs eventArgs)
        {
            View view = (View) sender;
            Snackbar.Make(view, "Replace with your own action", Snackbar.LengthLong)
                .SetAction("Action", (Android.Views.View.IOnClickListener)null).Show();
        }
        private void MuestraDialogo(object sender,EventArgs args)
        {

            string texto = edittext.Text;
            AlertDialog.Builder VentanaAlerta = new AlertDialog.Builder(this);
            VentanaAlerta.SetMessage(texto);
            VentanaAlerta.SetTitle(texto);
            VentanaAlerta.Show();
        }
        private void MostrarEditText()
        {
            edittext = FindViewById<EditText>(Resource.Id.textoPrincipal);
            MuestraDialog = FindViewById<Button>(Resource.Id.boton);

            MuestraDialog.Click += MuestraDialogo;
        }
    }
}

