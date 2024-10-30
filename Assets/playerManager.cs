// Intializing and calling on environment
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Valve.VR.InteractionSystem;

public class playerManager : MonoBehaviour
{
    public TargetManager targetManager; // Public reference to the target manager script
    private Vector3 originalPos; // A private variable to store the initial position of the player
    public TargetManager targetNum; // A public reference to a target manager variable


    // Collects and stores the intial location information of the player object for future respawns
    private void Start()
    {
        originalPos = this.transform.position; // Stores the initial position of the player
        //playerDirection = this.transform.forward;
        //originalRot = this.transform.rotation;
        Teleport.Player.Listen(TryAdvance); // Calls the TryAdvance function when the player teleports
    }


    // This what controls the character respawn function
    public void TryAdvance(TeleportMarkerBase target)
    {
        // Monitors if the player is in contact with the current defined target for the "mission" 
        // When player comes in contact with the target, Respawn method is invoked
        if (target != null && targetManager.AdvanceTarget(target.transform))
        {
            Respawn(); // Calls the Respawn function when the player reaches the target
        }
    }

    //This is how the character respawns
    void Respawn()
    {
        // Position is reset to original Pos which is collected upon start of game
        transform.position = originalPos; // Resets the player position to the original position
        transform.rotation = Quaternion.identity; // Resets the player rotation
        // Resets the timer to 0.0 in the CSV writer
        targetManager.GetComponent<CSV_Writer>().ResetTimer(); // Calls the ResetTimer function of the CSV_Writer script
    }

}