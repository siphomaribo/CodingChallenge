using System;
using System.Collections.Generic;
using System.Net.Sockets;

namespace BackEndTask3
{
    public class Factory
    {
        private IRobotService _robotService;
        private IPartsService _partsService;
        private ICarService _carService;

        /* It's always good practice to code against the interface. It allows us to test our code properly because we can mock the interfaces.
         * I am proposing that we use Dependency Injection pattern. As already mentioned above, our code will be more testable. We also going to achieve a more readability
         * along side that, our code can also be reusable
         * With Dependency Injection, we don't have to instatiate the services on the constructors, the IoC takes car of that. we can pass everything as interface.
         *
         * I would also have a factory pattern to get the Parts for either Robot or Car. This would help us clean this class a little bit more because we'd remove the last two
         * methods GetRobotPartsFor and only use the service to get the parts
         */

        public Factory(IRobotService robotService, IPartsService partsService, ICarService carService)
        {
            _robotService = robotService;
            _partsService = partsService;
            _carService = carService;
        }

        public Robot BuildRobot(RobotType RobotType)
        {
            var parts = GetRobotPartsFor(RobotType);

            if (parts?.Count == 0) return null;

            switch (RobotType)
            {
                case RobotType.RoboticDog:
                    return _robotService.BuildRobotDog(parts);
                case RobotType.RoboticCat:
                    return _robotService.BuildRobotCat(parts);
                case RobotType.RoboticDrone:
                    return _robotService.BuildRobotDrone(parts);
                case RobotType.RoboticCar:
                    return _robotService.BuildRobotCar(parts);
                default:
                    return null;
            }
           
        }

        public Car BuildCar(Enum CarType)
        {
            var parts = GetCarPartsFor(CarType);

            if (parts?.Count == 0) return null;
            
            return _carService.BuildCar(parts);
        
        }

        
        public List<Parts> GetRobotPartsFor(RobotType RobotType)
        {
            return _partsService.GetParts(RobotType);
        }

        public List<Parts> GetCarPartsFor(Enum CarType)
        {
            return _partsService.GetParts(CarType);
        }
    }
}
