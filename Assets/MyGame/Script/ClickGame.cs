using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ClickGame : MonoBehaviour
{
    public Button clickButton;
    public Button saveButton;
    public Button loadButton;
    public TMP_Text scoreText;
    public Button minusButton;

    private int score = 0;

    void Start()
    {
        clickButton.onClick.AddListener(ClickToPlus);
        saveButton.onClick.AddListener(SaveScore);
        loadButton.onClick.AddListener(LoadScore);
        minusButton.onClick.AddListener(ClickToMinus);
   
        UpdateScoreText();
    }

    void ClickToPlus()
    {
        score++;
        UpdateScoreText();
    }

    void ClickToMinus()
    {
        score--;
        UpdateScoreText();
    }

    

    void SaveScore()
    {
        PlayerPrefs.SetInt("SavedScore", score);
        PlayerPrefs.Save();
    }

    void LoadScore()
    {
        score = PlayerPrefs.GetInt("SavedScore", 0);
        UpdateScoreText();
    }

    void UpdateScoreText()
    {
        scoreText.text = $"Score: {score}";
    }
}
