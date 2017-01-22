using Android.App;
using Android.Runtime;
using Android.Widget;
using Android.OS;

namespace Custom_GridView_BaseAdapter
{
    [Activity(Label = "Custom GridView BaseAdapter", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {

        private GridView gv;
        private CustomAdapter adapter;
        private JavaList<Fruit> fruits; 

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            gv = FindViewById<GridView>(Resource.Id.gv);

            adapter=new CustomAdapter(GetFruits(),this);

            gv.Adapter = adapter;

            gv.ItemClick += gv_ItemClick;



        }

        void gv_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            Toast.MakeText(this,fruits[e.Position].Name,ToastLength.Short).Show();
        }

        //POPULATE FRUITS
        private JavaList<Fruit> GetFruits()
        {
            fruits = new JavaList<Fruit>();

            Fruit f;

            f = new Fruit("Apple", Resource.Drawable.apples);
            fruits.Add(f);

            f = new Fruit("Oranges", Resource.Drawable.oranges);
            fruits.Add(f);

            f = new Fruit("Pineapple", Resource.Drawable.pineapple);
            fruits.Add(f);

            f = new Fruit("Apples", Resource.Drawable.apples);
            fruits.Add(f);

            f = new Fruit("Mango", Resource.Drawable.mango);
            fruits.Add(f);

            f = new Fruit("Grapes", Resource.Drawable.grapes);
            fruits.Add(f);




            return fruits;

        }

      
    }
}

