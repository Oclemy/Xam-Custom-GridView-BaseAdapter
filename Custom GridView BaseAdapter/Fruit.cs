using System;


namespace Custom_GridView_BaseAdapter
{
    class Fruit
    {
        private String name;
        private int image;

        public Fruit(string name, int image)
        {
            this.name = name;
            this.image = image;
        }

        public string Name
        {
            get { return name; }
        }

        public int Image
        {
            get { return image; }
        }
    }
}