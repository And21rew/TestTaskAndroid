using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private TMP_Text bestScoreText;
    private readonly int maxFps = 60;

    private void Awake()
    {
        SetFpsLimit();
    }

    private void Start()
    {
        SetBestScoreText();
    }

    private void SetFpsLimit() => Application.targetFrameRate = maxFps;

    private void SetBestScoreText() => bestScoreText.text = $"Лучший счет: {PlayerPrefs.GetInt("BestScore")}";

    public void StartGameScene() => SceneManager.LoadScene(1);

    public void SwitchScreen(GameObject screen) => screen.SetActive(!screen.activeInHierarchy);

    public void CloseGame() => Application.Quit();
}
