using System;

class RemoteControlCar
{
   private int DistanceDriven { get; set; } = 0;
        private int RemainingBattery { get; set; } = 100;
    public static RemoteControlCar Buy()
    {
        return new RemoteControlCar();
    }

    public string DistanceDisplay()
    {
       return $"Driven {DistanceDriven} meters";
    }

    public string BatteryDisplay()
    {
        if (RemainingBattery == 0) return "Battery empty";
        return $"Battery at {RemainingBattery}%";
    }

    public void Drive()
    {
       if (RemainingBattery > 0) { 
            DistanceDriven += 20;
            RemainingBattery -= 1;
            }
    }
}
