using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CramCalcUI
{
    internal class PayloadTypeItem(PayloadType pType)
    {
        public PayloadType ID { get; } = pType;

        public static PayloadTypeItem[] pTypeItemArr =
        [
            new(PayloadType.Explosive),
            new(PayloadType.Frag),
            new(PayloadType.EMP),
            new(PayloadType.Incendiary)
        ];
    }
}
