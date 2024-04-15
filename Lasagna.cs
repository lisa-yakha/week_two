//task: https://exercism.org/tracks/csharp/exercises/lucians-luscious-lasagna
//first iteration:
class Lasagna
{
    public int ExpectedMinutesInOven()
    {
        //int min = 40;
        return 40;
    }

    public int RemainingMinutesInOven(int min_in_oven)
    {
        int min_left = 40 - min_in_oven;
        return min_left;

    }

    public int PreparationTimeInMinutes(int layers)
    {
        int min_prep = layers * 2;
        return min_prep;
    }

    public int ElapsedTimeInMinutes(int layers, int min_in_oven)
    {
        int min_overall = layers * 2 + min_in_oven;
        return min_overall;
    }
    //var lasagna = new Lasagna();
    //lasagna.ExpectedMinutesInOven();

    // TODO: define the 'RemainingMinutesInOven()' method

    // TODO: define the 'PreparationTimeInMinutes()' method

    // TODO: define the 'ElapsedTimeInMinutes()' method
}
//second iteration:
class Lasagna
{
    public int ExpectedMinutesInOven()
    {
        return 40;
    }

    public int RemainingMinutesInOven(int min_in_oven)
    {
        return 40 - min_in_oven; ;

    }

    public int PreparationTimeInMinutes(int layers)
    {
        return layers * 2;
    }

    public int ElapsedTimeInMinutes(int layers, int min_in_oven)
    {
        return layers * 2 + min_in_oven;
    }
    //var lasagna = new Lasagna();
    //lasagna.ExpectedMinutesInOven();

    // TODO: define the 'RemainingMinutesInOven()' method

    // TODO: define the 'PreparationTimeInMinutes()' method

    // TODO: define the 'ElapsedTimeInMinutes()' method
}