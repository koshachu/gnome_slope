using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiesMovement : MonoBehaviour
{
    private float zPositionBound = -30;
    public float enemySpeed = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Destroying enemies when they reach lower bound
        if (transform.position.z < zPositionBound)
        {
            Destroy(gameObject);
        }
        
        // Enemies movement
        transform.Translate(Vector3.back * enemySpeed * Time.deltaTime);
    }
}
