using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Ejer6_AndroidRelations
{
    
    public class fragmentoAgregacion : Fragment
    {
        private EditText _nombre;
        private EditText _apellido;
        private CheckBox _masculino;
        private CheckBox _femenino;
        private Button _botonAgregacion;
        Persona p1 = new Persona();
        public void  FragmentoAgregacion()
        {
            
        }
        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
        }
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            var vista = inflater.Inflate(Resource.Layout.Pestaña1, container, false);
            _nombre = vista.FindViewById<EditText>(Resource.Id.nombrePersona);
            _apellido = vista.FindViewById<EditText>(Resource.Id.apellidoPersona);
            _botonAgregacion = vista.FindViewById<Button>(Resource.Id.botonAgregacion);
            _masculino = vista.FindViewById<CheckBox>(Resource.Id.Masculino);
            _femenino = vista.FindViewById<CheckBox>(Resource.Id.Femenino);
            return vista;
        }
    }
}