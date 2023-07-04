using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuMenegerScript : MonoBehaviour
{
    public static bool clickOnButton;

    audioManagerScript audioManager;
    public void ChangeScene(string LoadScene)
    {
        SceneManager.LoadScene("game scene");
        clickOnButton = true; // menuMenegerScript.clickOnButton = true; ---> at movementforplayer
                              // GetComponent<movmentforplayer>().enabled = true;
        NewGame1();
    }

    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<audioManagerScript>();
    }
    public void NewGame1()
    {
        destroy.RingIsOut = false;
    }

    private void Update()
    {
        if (Time.time == 0f)
        {
            audioManager.playSFX(audioManager.backgroundmusic);
        }
    }
}
