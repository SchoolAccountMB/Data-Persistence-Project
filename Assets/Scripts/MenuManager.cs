using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public TMP_InputField inputName;

    public TMP_Text highScoreText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ScoreNameManager.Instance.LoadHighScore();

        inputName.text = ScoreNameManager.Instance.playerName;

        highScoreText.text = "Best Score: " + ScoreNameManager.Instance.playerName + " = " + ScoreNameManager.Instance.highScore;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        ScoreNameManager.Instance.playerName = inputName.text;
        SceneManager.LoadScene(1);
    }

    public void QuitGame()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }
}
