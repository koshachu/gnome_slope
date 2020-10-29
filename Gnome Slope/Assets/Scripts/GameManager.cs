using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Button startButton;
    public ParticleSystem snow;
    public GameObject titleScreen;
    private SpawnManager spawnManager;
    // Start is called before the first frame update
    void Start()
    {
        spawnManager = GameObject.Find("Spawn Manager").GetComponent<SpawnManager>();
        startButton.GetComponent<Button>();
        startButton.onClick.AddListener(StartGame);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        spawnManager.OnStartGame();
        snow.Play();
        titleScreen.gameObject.SetActive(false);
    }
}
