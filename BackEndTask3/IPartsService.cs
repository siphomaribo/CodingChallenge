using System;
using System.Collections.Generic;
using System.Text;

namespace BackEndTask3
{
    public interface IPartsService
    {
        List<Parts> GetParts(Enum CarType);
    }
}
