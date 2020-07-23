using System;
using System.Collections.Generic;
using System.Text;

namespace BackEndTask3
{
    public interface ICarService
    {
        Car BuildCar(List<Parts> parts);
    }
}
