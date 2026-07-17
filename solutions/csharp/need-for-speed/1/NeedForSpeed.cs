using System;

class RemoteControlCar
    {
         // TODO: define the constructor for the 'RemoteControlCar' class
        private int _battery= 100;
        private int _drivingDistance = 0;
        private int _speed;
        private int _batteryDrain;
        public RemoteControlCar(int speed, int battery)
        {
            _batteryDrain = battery;
            _speed = speed;
        }
        public bool BatteryDrained()
        {
            if (_batteryDrain > _battery) return true;
            return _battery== 0 ? true : false;

        }

        public int DistanceDriven()
        {
            return _drivingDistance;
        }

        public void Drive()
        {
            if (!BatteryDrained())
            {
                _drivingDistance = _drivingDistance + _speed;
                _battery = _battery - _batteryDrain;
            }
            
        }

        public static RemoteControlCar Nitro()
        {
            return new RemoteControlCar(50, 4);
        }
    }

    class RaceTrack
    {
        // TODO: define the constructor for the 'RaceTrack' class
        private int _distance;
        public RaceTrack(int distance)
        {
            _distance = distance;
        }
        public bool TryFinishTrack(RemoteControlCar car)
        {
            bool canFinish = false;
            while (!car.BatteryDrained() && car.DistanceDriven()<= _distance)
            {
                car.Drive();
                if (car.DistanceDriven() >= _distance) canFinish = true;
            }
            return canFinish;
        }
    }