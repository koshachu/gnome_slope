using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    
    public ParticleSystem snow;
    public TextMeshProUGUI scoreText;
    private int score;

    
    private static GameManager instance;
    public static GameManager Instance => instance;
    // Start is called before the first frame update

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        StartGame();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        SpawnManager.Instance.OnStartGame();
        snow.Play();
        UpdateScore(0);
    }

    public void UpdateScore(int scoreAdd)
    {
        score += scoreAdd;
        scoreText.text = "score: " + score;
    }

    public void EndGame()
    {
        Debug.Log("Game Over!");
        SceneManager.LoadScene("Game Over");
    }
}
