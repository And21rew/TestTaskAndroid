using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject gameEndScreen;
    [SerializeField] private TMP_Text finalScoreText;
    [SerializeField] private TMP_Text scoreText;

    [SerializeField] private GameObject[] players;
    [SerializeField] private GameObject[] bg;

    private int score;
    public int Score { get { return score; } }

    private void Start()
    {
        StopTimeInGame();
        bg[PlayerPrefs.GetInt("BgSkin")].SetActive(true);
    }

    public void StartGame()
    {
        score = 0;
        players[PlayerPrefs.GetInt("PlayerSkin")].SetActive(true);
        UpdateScoreUI();
        StartTimeInGame();
    }

    public void QuitGame() => SceneManager.LoadScene(0);

    public void UpdateScore()
    {
        score++;
        UpdateScoreUI();
    }

    private void UpdateScoreUI() => scoreText.text = score.ToString();

    public void StartTimeInGame() => Time.timeScale = 1f;

    public void StopTimeInGame() => Time.timeScale = 0f;

    public void GameEnd()
    {
        StopTimeInGame();
        scoreText.gameObject.SetActive(false);
        gameEndScreen.SetActive(true);
        finalScoreText.text = $"Вы разбились!\n\n\nВаш результат:\n{score}\n\n\nДля продолжения нажмите на экран...";
        UpdateBestScore();
    }

    private void UpdateBestScore()
    {
        if (score > PlayerPrefs.GetInt("BestScore"))
            PlayerPrefs.SetInt("BestScore", score);
    }

    public void Restartlevel() => SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
}
