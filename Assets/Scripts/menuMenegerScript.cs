using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using Unity.VisualScripting;

public class menuMenegerScript : MonoBehaviour
{
    public static bool clickOnButton;
    public TMP_Text highScoreText;

    public void Start()
    {
        highScoreText.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
    }
    public void ChangeScene(string LoadScene)
    {
        SceneManager.LoadScene("game scene");
        clickOnButton = true; 
        NewGame1();
    }
    public void NewGame1()
    {
        destroy.RingIsOut = false;
    }

    public void restartHighscore() {
        PlayerPrefs.DeleteKey("HighScore");
    }


}
