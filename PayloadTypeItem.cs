using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CramCalcUI
{
    internal class PayloadTypeItem
    {
        public PayloadTypeItem(PayloadType pType) 
        {
            ID = pType;
        }
        public PayloadType ID { get; }

        public static PayloadTypeItem[] pTypeItemArr = new PayloadTypeItem[]
        {
            new PayloadTypeItem(PayloadType.Explosive),
            new PayloadTypeItem(PayloadType.Frag),
            new PayloadTypeItem(PayloadType.EMP)
        };
    }
}
