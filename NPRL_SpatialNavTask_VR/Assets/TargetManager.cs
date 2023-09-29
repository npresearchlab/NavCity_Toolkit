// Initializing environment
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetManager : MonoBehaviour
{
    // Creates an array with the targets for the task
    public static int targetNum = 0; // a public static integer that represents the current target number
    public Transform[] targets = new Transform[9]; // an array of 9 transforms that represents the targets

    // Moves the player throught the missions and prevents them from reseting the mission on the wrong target
    public bool AdvanceTarget(Transform currentTarget)
    {
        // Pulls current target information from the array defined before 
        if (currentTarget != targets[targetNum]) // if the current target is not equal to the target at the current target number in the array
        {
            return false; // return false, indicating that the player has not advanced to the next target
        }
        // Moves the target to the next target in the array
        targetNum++; // increment the target number to move to the next target

        return true; // return true, indicating that the player has advanced to the next target
    }
}
