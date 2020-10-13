using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class QuestOutline : MonoBehaviour
{
    //Step needed for quest
    public int stepNeeded;
    //Current step from the pedometer
    public int stepCurrent;
    //Check completion of quest
    public bool questCompletion;

    public void checkStep(int step)
    {
        stepCurrent = Mathf.Min(stepCurrent + 1, stepNeeded);
        if (stepCurrent >= stepNeeded && !questCompletion)
        {
            this.questCompletion = true;
        }
    }

 
    //Need to find a way to get the step counter in from the pedometer and then get it in a variable to compare with the set values
    //Refresh from zero at the start of each day
    //Get current date and store in a variable
    //Add step currency when daily quest are achieved
    //3 set quests
    //Text for quest:
    //1) The way to start your day! (step_counter/1000)
    //2) You're halfway to a healthy walking day! (step_counter/5000)
    //3) Nice job hitting the 5 digits! (step_counter/10000)
    

}
