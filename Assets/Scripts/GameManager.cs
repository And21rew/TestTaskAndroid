using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject pauseScreen, gameEndScreen;
    [SerializeField] private TMP_Text scoreText;

    private int score;

    private void Start()
    {
        score = 0;
        UpdateScoreUI();
        StartTimeInGame();
    }

    public void UpdateScore()
    {
        score++;
        UpdateScoreUI();
    }

    private void UpdateScoreUI()
    {
        scoreText.text = score.ToString();
    }

    public void StartTimeInGame() => Time.timeScale = 1f;

    public void StopTimeInGame() => Time.timeScale = 0f;

    public void SwitchPause()
    {
        if (pauseScreen.activeInHierarchy) StartTimeInGame();
        else StopTimeInGame();
        pauseScreen.SetActive(!pauseScreen.activeInHierarchy);
    }

    public void GameEnd()
    {
        StopTimeInGame();
        gameEndScreen.SetActive(true);
    }

    public void Restartlevel() => SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
}
