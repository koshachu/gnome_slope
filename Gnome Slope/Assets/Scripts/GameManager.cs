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

    private static GameManager instance;
    public static GameManager Instance => instance;
    // Start is called before the first frame update

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        startButton.GetComponent<Button>();
        startButton.onClick.AddListener(StartGame);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        SpawnManager.Instance.OnStartGame();
        snow.Play();
        titleScreen.gameObject.SetActive(false);
    }
}
