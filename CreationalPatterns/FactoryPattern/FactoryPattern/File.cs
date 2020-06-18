using System.Collections.Generic;

namespace FactoryPattern
{
    abstract class File
    {
        private List<Items> _Itemss = new List<Items>();
        // Constructor calls abstract Factory method
        public File()
        {
            this.CreateItemss();
        }
        public List<Items> Itemss
        {
            get { return _Itemss; }
        }
        // Factory Method
        public abstract void CreateItemss();
    }
}