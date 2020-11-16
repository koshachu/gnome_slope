using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerupTimeController : MonoBehaviour
{
    bool shouldBeDestroyed = false;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !shouldBeDestroyed)
        {
            shouldBeDestroyed = true;
            Destroy(gameObject);
            var playerControllerScript = other.GetComponent<PlayerController>();
            playerControllerScript.TimeFreeze();
            Debug.Log("Time is freezed");

        }

    }
}
