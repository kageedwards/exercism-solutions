class Lasagna
{
    const int PREP_TIME = 2;
    const int COOKING_TIME = 40;
    
    // TODO: define the 'ExpectedMinutesInOven()' method
    public int ExpectedMinutesInOven() {
        return COOKING_TIME;
    }
    
    // TODO: define the 'RemainingMinutesInOven()' method
    public int RemainingMinutesInOven(int minutesInOven) {
        return ExpectedMinutesInOven() - minutesInOven;
    }
    
    // TODO: define the 'PreparationTimeInMinutes()' method
    public int PreparationTimeInMinutes(int layers) {
        return PREP_TIME * layers;
    }
    
    // TODO: define the 'ElapsedTimeInMinutes()' method
    public int ElapsedTimeInMinutes(int layers, int minutesInOven) {
        return PreparationTimeInMinutes(layers) + minutesInOven;
    }
}
