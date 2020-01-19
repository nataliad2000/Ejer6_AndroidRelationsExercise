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
    [Activity(Label = "Activity1")]
    public class Activity1 : Activity
    {
        public TextView textoPaginaNueva;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.Activity1Layout);
            nuevaPagina();
        }
        private void nuevaPagina()
        {
            textoPaginaNueva = FindViewById<TextView>(Resource.Id.textoPaginaNueva);
            FragmentManager.BeginTransaction()
                .Replace(Resource.Id.textoPaginaNueva,new Fragment()).Commit();
        }

       
    }
}