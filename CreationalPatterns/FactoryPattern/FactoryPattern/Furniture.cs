namespace FactoryPattern
{
    class Furniture : File
    {
        // Factory Method implementation
        public override void CreateItemss()
        {
            Itemss.Add(new SofasetItems());
            Itemss.Add(new BedItems());
            Itemss.Add(new DiningItems());
        }
    }
}