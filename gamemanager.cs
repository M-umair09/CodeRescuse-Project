using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class gamemanager : MonoBehaviour
{
    public static gamemanager instance;
    public GameObject pauseScreenPanal;
    public GameObject resumeScreenPanal;
    public GameObject gameOverScreenPanal;
    public GameObject restart;
    public int coinScore = 0;
    public TextMeshProUGUI coinScoreText;

    public GameObject youwinpanel;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    private void Start()
    {
        coinScoreText.text = "score " + coinScore;
    }
    public void ScoreIncrement()
    {
        coinScore = coinScore + 1;
        coinScoreText.text = "score " + coinScore;
    
     }
    public void PauseBTN()
    {
        resumeScreenPanal.SetActive(true);
        pauseScreenPanal.SetActive(false);
        Time.timeScale = 0.0f;

    }
    public void PlayBTN()
    {
        Time.timeScale = 1.0f;
        resumeScreenPanal.SetActive(false);
        pauseScreenPanal.SetActive(true);
    } 
    public void GameOver()
    {
        gameOverScreenPanal.SetActive(true);
    }
    public void RestartBTN()
    {
        SceneManager.LoadScene("carscene");

    }

        public void win()
    {
         youwinpanel.SetActive(true);
    }


}
