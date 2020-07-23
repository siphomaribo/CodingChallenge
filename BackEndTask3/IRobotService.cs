using System;
using System.Collections.Generic;
using System.Text;

namespace BackEndTask3
{
    public interface IRobotService
    {
        Robot BuildRobotCar(List<Parts> parts);
        Robot BuildRobotDog(List<Parts> parts); 
        Robot BuildRobotCat(List<Parts> parts);
        Robot BuildRobotDrone(List<Parts> parts);
    }
}
