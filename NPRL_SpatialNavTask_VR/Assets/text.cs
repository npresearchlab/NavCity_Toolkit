// Initialize environment
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class text : MonoBehaviour
{
    public Text missionStatement;
    public string currentTarget;

    // Start is called before the first frame update. Creates the mission statment and implements it to the environment
    void Start()
    {
        // Get the name of the current target from the TargetManager script and set it as the currentTarget variable
        currentTarget = GetComponent<TargetManager>().targets[TargetManager.targetNum].name;
        // Set the mission statement text to display the name of the current target
        missionStatement.text = "Target: " + currentTarget;
    }

    /*Update is called once per frame. This function updates the mission statement text when the player respawns
    or when the target changes*/
    void Update()
    {
        // Get the name of the current target from the TargetManager script and set it as the currentTarget variable
        currentTarget = GetComponent<TargetManager>().targets[TargetManager.targetNum].name;
        // Set the mission statement text to display the name of the current target
        missionStatement.text = "Target: " + currentTarget;
    }
}
