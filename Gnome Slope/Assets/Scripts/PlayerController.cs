using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float playerSpeed;
    private float xPositionBound = 16;
    private float zPositionBound = 7.5f;
    private Rigidbody playerRigidBody;
    public GameObject projectilePrefab;

    // Start is called before the first frame update
    void Start()
    {
        playerRigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMovement();

        // Method launches projectiles from the Player
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }

    }

    // Player moves, based on vertical and horizontal input with use of RigidBody Component
    void PlayerMovement()
    {
        float verticalInput = Input.GetAxis("Vertical");
        float horizontalInput = Input.GetAxis("Horizontal");

        playerRigidBody.AddForce(Vector3.forward * playerSpeed * verticalInput);
        playerRigidBody.AddForce(Vector3.right * playerSpeed * horizontalInput);

        // Restricts Player from moving out of the field of view on X Axis
        if(transform.position.x < -xPositionBound)
        {
            transform.position = new Vector3(-xPositionBound, transform.position.y, transform.position.z);
        }
        if(transform.position.x > xPositionBound)
        {
            transform.position = new Vector3(xPositionBound, transform.position.y, transform.position.z);
        }

        // Restricts Player from moving out of the field of view on Z Axis 
        if(transform.position.z < -zPositionBound)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -zPositionBound);
        }
        if (transform.position.z > zPositionBound)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zPositionBound);
        }
    }
}

