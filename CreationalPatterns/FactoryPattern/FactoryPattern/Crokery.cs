namespace FactoryPattern
{
    class Crokery : File
    {
        public override void CreateItemss()
        {
            Itemss.Add(new PlatesItems());
            Itemss.Add(new GlassesItems());
            Itemss.Add(new TeasetItems());
            Itemss.Add(new BowlsItems());
        }
    }
}