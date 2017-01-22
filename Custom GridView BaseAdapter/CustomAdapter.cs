
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Object = Java.Lang.Object;

namespace Custom_GridView_BaseAdapter
{
    class CustomAdapter : BaseAdapter
    {
        private Context c;
        private JavaList<Fruit> fruits;
        private LayoutInflater inflater;

        public CustomAdapter(JavaList<Fruit> fruits, Context c)
        {
            this.fruits = fruits;
            this.c = c;
        }


        public override Object GetItem(int position)
        {
            return fruits.Get(position);
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            if (inflater == null)
            {
                inflater = (LayoutInflater) c.GetSystemService(Context.LayoutInflaterService);
            }

            if (convertView == null)
            {
                convertView = inflater.Inflate(Resource.Layout.Model, parent, false);
            }

            //BIND DATA
            TextView nameTxt = convertView.FindViewById<TextView>(Resource.Id.nameTxt);
            ImageView img = convertView.FindViewById<ImageView>(Resource.Id.fruitImg);

            nameTxt.Text = fruits[position].Name;
            img.SetImageResource(fruits[position].Image);


            return convertView;
        }

        public override int Count
        {
            get { return fruits.Size(); }
        }
    }
}