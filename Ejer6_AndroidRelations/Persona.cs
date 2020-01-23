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
    class Persona
    {
       public string nombre
        {
            get => nombre;
            set
            {
                nombre = value;
            }
        }
        public string apellidos
        {
            get => apellidos;
            set
            {
                apellidos = value;
            }
        }
       
    }
}