using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float playerSpeed;
    private Rigidbody playerRigidBody;
    // Start is called before the first frame update
    void Start()
    {
        playerRigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMovement();
    }

    // Player moves, based on vertical and horizontal input with use of RigidBody Component
    void PlayerMovement()
    {
        float verticalInput = Input.GetAxis("Vertical");
        float horizontalInput = Input.GetAxis("Horizontal");

        playerRigidBody.AddForce(Vector3.forward * playerSpeed * verticalInput);
        playerRigidBody.AddForce(Vector3.right * playerSpeed * horizontalInput);
    }
}

