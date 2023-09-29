// Initialize environment
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class text : MonoBehaviour
{
    public Text missionStatement;
    public string currentTarget;

    // Creates the mission statment and implements it to the environment
    void Start()
    {
        currentTarget = GetComponent<TargetManager>().targets[TargetManager.targetNum].name;
        missionStatement.text = "Target: " + currentTarget;
    }

    // Updates the mission statment upon respawn
    void Update()
    {
        currentTarget = GetComponent<TargetManager>().targets[TargetManager.targetNum].name;
        missionStatement.text = "Target: " + currentTarget;
    }
}
