class Lasagna
{
    public int ExpectedMinutesInOven(){
        return 40;
    }

    public int RemainingMinutesInOven(int minutes){
        return ExpectedMinutesInOven() - minutes;
    }

    public int PreparationTimeInMinutes(int layers){
        return layers * 2;
    }

    public int ElapsedTimeInMinutes(int layers, int minutes){
        int preparationTime = PreparationTimeInMinutes(layers);
        //int remainingTime = RemainingMinutesInOven(minutes);
        return  preparationTime + minutes;
    }
}
