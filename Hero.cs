using System;

namespace MsHostBuilderApp
{
    public class Hero
    {
        public Guid ID { get; set; }
        public string Name { get; set; }

        public Hero()
        {
            ID = Guid.NewGuid();
        }
    }
}
