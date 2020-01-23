using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.Design.Widget;
using Android.Util;
using Android.Views;
using Android.Widget;
using Java.IO;

namespace Ejer6_AndroidRelations
{
    [Activity(Label = "ventana2",Theme ="@style/Theme.AppCombat.Light.NoActionBar")]
    public class ventana2 : Activity
    {
        private const string V = "personas.dat";
        EditText nombre,apellidos;
        List<Persona> personas;
        ListView listaAgregacionPersonas;
        
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Pestaña2);
            
         
        }
        void AgregarMiembros()
        {
            nombre = FindViewById<EditText>(Resource.Id.nombrePersona);
            apellidos = FindViewById<EditText>(Resource.Id.apellidoPersona);
            listaAgregacionPersonas = FindViewById<ListView>(Resource.Id.tablaPersonasAñadidas);
            for(int i = 0; i < personas.Count; i++)
            {
                Persona p = new Persona();
                p.nombre = nombre.Text;
                p.apellidos = apellidos.Text;
                listaAgregacionPersonas.ShowContextMenu();
            }          
            

        }
        void GuargarPersonas(List<Persona>personas)
        {
            string fichero = "personas.txt";
            string linea = null;
            try
            {
                FileInputStream fileInputStream = new FileInputStream(new File(fichero));
                FileInputStream fileInputStream1 = fileInputStream;
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.Append("nombre: "+nombre + " apellidos: " + apellidos);
                
            }
            catch (FileNotFoundException e)
            {
                Log.Debug("Error", "el fichero no se ha encontrado");
            }

          
        }
    }
}