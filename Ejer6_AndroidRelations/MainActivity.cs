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
        public EditText textoEditado;
        private Button boton1;
        private Button boton2;
        private Button boton3;
        private Button boton4;
        private Button boton5;
        private Button boton6;
        private Button boton7;
        private Button boton8;
        private Button boton9;
        public Button botonConfirmacion;
    
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_main);

            Android.Support.V7.Widget.Toolbar toolbar = FindViewById<Android.Support.V7.Widget.Toolbar>(Resource.Id.toolbar);
            SetSupportActionBar(toolbar);

            FloatingActionButton fab = FindViewById<FloatingActionButton>(Resource.Id.fab);
                
        }

        private void AgregarFuncionalidad()
        {

            boton1 = FindViewById<Button>(Resource.Id.botonuno);
            boton2 = FindViewById<Button>(Resource.Id.botondos);
            boton3 = FindViewById<Button>(Resource.Id.botontres);
            boton4 = FindViewById<Button>(Resource.Id.botoncuatro);
            boton5 = FindViewById<Button>(Resource.Id.botoncinco);
            boton6 = FindViewById<Button>(Resource.Id.botonseis);
            boton7 = FindViewById<Button>(Resource.Id.botonsiete);
            boton8 = FindViewById<Button>(Resource.Id.botonocho);
            boton9 = FindViewById<Button>(Resource.Id.botonnueve);
            botonConfirmacion = FindViewById<Button>(Resource.Id.botonConfirmacion);

            boton1.Click += colocarTexto;
            boton2.Click += colocarTexto;
            boton3.Click += colocarTexto;
            boton4.Click += colocarTexto;
            boton5.Click += colocarTexto;
            boton6.Click += colocarTexto;
            boton7.Click += colocarTexto;
            boton8.Click += colocarTexto;
            boton9.Click += colocarTexto;
            botonConfirmacion.Click += confirmacion;
        }
        private void colocarTexto(object sender,EventArgs e)
        {
            Button botonElegido = (Button)sender;
            textoEditado.Text = textoEditado.Text += botonElegido.Text;
        }
       private void confirmacion(object sender,EventArgs e)
        {
            if (textoEditado.Text.Equals("1234"))
            {
                SetContentView(Resource.Layout.activity_main);
                
            }
            else
            {
                textoEditado.SetTextColor(Android.Graphics.Color.Red);
            }
        }    
    }
}

