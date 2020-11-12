using UnityEngine;

public class PowerupController : MonoBehaviour
{
    bool shouldBeDestroyed = false;

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


}
