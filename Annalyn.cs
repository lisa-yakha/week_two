//task:https://exercism.org/tracks/csharp/exercises/annalyns-infiltration/
//one iteration for now

using System;

static class QuestLogic
{
    public static bool CanFastAttack(bool knightIsAwake)
    {
        //throw new NotImplementedException("Please implement the (static) QuestLogic.CanFastAttack() method");
        if (knightIsAwake == true)
            return false;
        else
            return true;
    }

    public static bool CanSpy(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake)
    {
        if (knightIsAwake == true || archerIsAwake == true || prisonerIsAwake == true)
            return true;
        else
            return false;
        //throw new NotImplementedException("Please implement the (static) QuestLogic.CanSpy() method");

    }

    public static bool CanSignalPrisoner(bool archerIsAwake, bool prisonerIsAwake)
    {
        if (archerIsAwake == false && prisonerIsAwake == true)
            return true;
        else
            return false;
        //throw new NotImplementedException("Please implement the (static) QuestLogic.CanSignalPrisoner() method");
    }

    public static bool CanFreePrisoner(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake, bool petDogIsPresent)
    {
        if (petDogIsPresent == true && archerIsAwake == false)
            return true;
        if (petDogIsPresent == false && (prisonerIsAwake == true && knightIsAwake == false && archerIsAwake == false))
            return true;
        else
            return false;
        //throw new NotImplementedException("Please implement the (static) QuestLogic.CanFreePrisoner() method");
    }
}