using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BasePowerupController : MonoBehaviour
{
    bool shouldBeDestroyed = false;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !shouldBeDestroyed)
        {
            shouldBeDestroyed = true;
            Destroy(gameObject);
            ActivatePowerup(other);
        }
    }

    protected abstract void ActivatePowerup(Collider other);


}
