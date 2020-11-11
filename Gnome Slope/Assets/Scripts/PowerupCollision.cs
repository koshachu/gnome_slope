using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerupCollision : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Speed boost");
        Destroy(gameObject);
    }


}
