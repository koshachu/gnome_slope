using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float playerSpeed;
    private float xPositionBound = 16;
    private float zPositionBound = 7.5f;
    private float powerupValue = 20f;
    // private Rigidbody playerRigidBody;
    public GameObject projectilePrefab;
    public int maxHealth = 100;
    public int currentHealth;

    public HealthBar healthBar;
    

    internal void SpeedBoost()
    {
        playerSpeed += powerupValue;
        StartCoroutine(PowerupCountDown());
        
    }

    internal void TimeFreeze()
    {
        if (Time.timeScale == 1.0f)
        {
            Time.timeScale = 0.5f;
        }
        StartCoroutine(PowerupTimeFreeze());
    }



    // Start is called before the first frame update
    void Start()
    {
        healthBar.SetMaxHealth(maxHealth);
        currentHealth = maxHealth;
        // playerRigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.H))
        {
            TakeDamage(10);
        }

        PlayerMovement();

        // Method launches projectiles from the Player
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }

    }

    void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);

        if (currentHealth == 0)
        {
            GameManager.Instance.EndGame();
        }
    }

    // Player moves, based on vertical and horizontal input with use of RigidBody Component
     void PlayerMovement()
    {
        float verticalInput = Input.GetAxis("Vertical");
        float horizontalInput = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.forward * playerSpeed * verticalInput * Time.deltaTime);
        transform.Translate(Vector3.right * playerSpeed * horizontalInput * Time.deltaTime);

             

        // Restricts Player from moving out of the field of view on X Axis
        if (transform.position.x < -xPositionBound)
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

    IEnumerator PowerupCountDown()
    {
        yield return new WaitForSeconds(5);
        playerSpeed -= powerupValue;


    }

    IEnumerator PowerupTimeFreeze()
    {
        yield return new WaitForSeconds(5);
        Time.timeScale = 1.0f;
    }
}

