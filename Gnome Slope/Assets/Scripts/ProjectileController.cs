using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class ProjectileController : MonoBehaviour
{
    public float projectileSpeed;
    private float topBoundaryZ = 30;

    private bool shouldBeDestroyed;
        

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z > topBoundaryZ)
        {
            Destroy(gameObject);
        }
        transform.Translate(Vector3.forward * Time.deltaTime * projectileSpeed);

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy") && !shouldBeDestroyed)
        {
            shouldBeDestroyed = true;
            GameManager.Instance.UpdateScore(10);
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
    }
}
