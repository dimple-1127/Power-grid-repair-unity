using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    public TextMeshProUGUI scoreText;
    public GameObject winText;
    public GameObject loseText;

    private int score = 0;

    void Awake()
    {
        instance = this;
    }

    void Start()
    {
        score = 0;
        scoreText.text = "Score: 0";

        if (winText != null)
            winText.SetActive(false);

        if (loseText != null)
            loseText.SetActive(false);

        Time.timeScale = 1f;
    }

    public void AddScore()
    {
        score++;
        scoreText.text = "Score: " + score;

        if (score >= 5)
        {
            winText.SetActive(true);
            Time.timeScale = 0f;
        }
    }

    public void GameOver()
    {
        loseText.SetActive(true);
        Time.timeScale = 0f;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            Time.timeScale = 1f;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}