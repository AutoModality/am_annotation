namespace AM_Annotator
{
    class FeatureLabel
    {
        private int Id;
        private int X;
        private int Y;
        private int Width;
        private int Height;
        public FeatureLabel(int id, int x, int y, int width, int height)
        {
            Id = id;
            X = x;
            Y = y;
            Width = width;
            Height = height;
        }

        public int getId()
        {
            return Id;
        }
        public int getX()
        {
            return X;
        }
        public int getY()
        {
            return Y;
        }
        public int getWidth()
        {
            return Width;
        }
        public int getHeight()
        {
            return Height;
        }
    }
}