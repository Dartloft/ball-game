using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{

    public static bool gameOver;
    public static bool levelWin;

    public GameObject gameOverPanel;
    public GameObject WinPanel;

    public static int CurrentLevelIndex;
    public static int PassingRings;

    public TextMeshProUGUI currentLevelText;
    public TextMeshProUGUI nextLevelText;

    public Slider ProgressBar;



    public void Awake()
    {
        CurrentLevelIndex = PlayerPrefs.GetInt("CurrentLevelIndex", 1);
    }
   

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1f;
        PassingRings = 0;
        gameOver = false;
        levelWin = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(gameOver)
        {
            Time.timeScale = 0;

            gameOverPanel.SetActive(true);

            if(Input.GetKey(KeyCode.A))
            {
                SceneManager.LoadScene(0);
            }
        }


        currentLevelText.text = CurrentLevelIndex.ToString();
        nextLevelText.text = (CurrentLevelIndex + 1).ToString();

        int progress = PassingRings * 100 / FindObjectOfType<GameManager>().numrings;
        ProgressBar.value = progress;

        if (levelWin)
        {
            WinPanel.SetActive(true);
            if(Input.GetKey(KeyCode.A))
            {
                PlayerPrefs.SetInt("currentLevelIndex", CurrentLevelIndex + 1);
                SceneManager.LoadScene(0);
            }
        }


    }


   
}
