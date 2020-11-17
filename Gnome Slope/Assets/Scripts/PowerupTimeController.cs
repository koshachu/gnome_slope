using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerupTimeController : BasePowerupController
{
    protected override void ActivatePowerup(Collider other)
    {
        var playerControllerScript = other.GetComponent<PlayerController>();
        playerControllerScript.TimeFreeze();
        Debug.Log("Time is freezed");
    }
       
}
