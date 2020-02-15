using System;

namespace MsHostBuilderApp
{
    public class Enemy
    {
        public string Name { get; set; }
        public Guid ID { get; set; }

        public Enemy()
        {
            ID = Guid.NewGuid();
        }
    }
}
