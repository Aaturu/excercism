class Lasagna
{    
    private int ExpectedMinutes = 40;
    // TODO: define the 'ExpectedMinutesInOven()' method
    public int ExpectedMinutesInOven() => ExpectedMinutes;

    // TODO: define the 'RemainingMinutesInOven()' method
    public int RemainingMinutesInOven(int x) => ExpectedMinutes - x;
    
    // TODO: define the 'PreparationTimeInMinutes()' method
    public int PreparationTimeInMinutes(int x) => 2 * x;
    
    // TODO: define the 'ElapsedTimeInMinutes()' method
    public int ElapsedTimeInMinutes(int x, int y) => x * 2 + y;
    
}
