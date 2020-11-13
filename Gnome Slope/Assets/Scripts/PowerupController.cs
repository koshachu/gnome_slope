using System.Collections;
using UnityEngine;

public class PowerupController : MonoBehaviour
{
    bool shouldBeDestroyed = false;


    private void Start()
    {
        StartCoroutine(PowerupCountDown());
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !shouldBeDestroyed)
        {
            shouldBeDestroyed = true;
            Destroy(gameObject);
            var playerControllerScript = other.GetComponent<PlayerController>();
            playerControllerScript.SpeedBoost();
            Debug.Log("Speed boost");
            
        }
        
    }

    IEnumerator PowerupCountDown()
    {
        yield return new WaitForSeconds(5);
        Debug.Log("Speed is set to normal");
       

    }



}
