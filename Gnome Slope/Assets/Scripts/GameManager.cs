using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public bool isGameActive;
    public GameObject titleScreen;
    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // When Game starts
    public void StartGame()
    {
        isGameActive = true;
        titleScreen.gameObject.SetActive(false);
    }
}

