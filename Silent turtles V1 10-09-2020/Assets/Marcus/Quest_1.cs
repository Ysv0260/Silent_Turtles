using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quest_1 : QuestOutline
{
    public int steps;
    
    public Quest_1(int amountneeded, int steps)
    {
        //Set the steps from the pedometer, must figure out how
        stepCurrent = 0;
        stepNeeded = amountneeded;
        questCompletion = false;
        this.steps = steps;
    }
    
}
