using System.Collections;
using UnityEngine;

public class PowerupController : BasePowerupController
{
    protected override void ActivatePowerup(Collider other)
    {
        var playerControllerScript = other.GetComponent<PlayerController>();
        playerControllerScript.SpeedBoost();
        Debug.Log("Speed boost");
    }
}
