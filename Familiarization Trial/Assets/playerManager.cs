// Intializing and calling on environment
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Valve.VR.InteractionSystem;

public class playerManager : MonoBehaviour
{
    public TargetManager targetManager;
    private Vector3 originalPos;
    public TargetManager targetNum;

    // Collects and stores the intial location information of the player object for future respawns
    private void Start()
    {
        originalPos = this.transform.position;
        Teleport.Player.Listen(TryAdvance);
    }

    // This what controls the character respawn function
    public void TryAdvance(TeleportMarkerBase target)
    {
        // Monitors if the player is in contact with the current defined target for the "mission" 
        // When player comes in contact with the target, Respawn method is invoked
        if (target != null && targetManager.AdvanceTarget(target.transform))
        {
            Respawn();
        }
    }

    //This is how the character respawns
    void Respawn()
    {
        // Position is reset to original Pos which is collected upon start fo game
        transform.position = originalPos;
        // Resets the timer to 0.0 in the CSV writer
    }

}
