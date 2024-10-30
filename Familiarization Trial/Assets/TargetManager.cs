// Initializing environment
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetManager : MonoBehaviour
{
    // Creates an array with the targets for the task
    public static int targetNum = 0;
    public Transform[] targets = new Transform[9];
    
    // Moves the player throught the missions and prevents them from reseting the mission on the wrong target
    public bool AdvanceTarget(Transform currentTarget)
    {
        // Pulls current target information from the array defined before 
        if (currentTarget != targets[targetNum])
        {
            return false;
        }
        // Moves the target to the next target in array 
        targetNum++;

        return true;
    }
}
