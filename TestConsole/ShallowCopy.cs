using System;

namespace TestConsole
{
    class ShallowCopy:ICloneable
    {
        public int I { get; set; }
        public int J { get; set; }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}