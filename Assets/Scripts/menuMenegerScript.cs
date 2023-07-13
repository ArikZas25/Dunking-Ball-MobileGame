using UnityEngine;
using UnityEngine.SceneManagement;

public class menuMenegerScript : MonoBehaviour
{
    public static bool clickOnButton;
    //[Header("--------- sound ---------")]
    //audioManagerScript audioManager;
    private void Awake()
    {
        //audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<audioManagerScript>();
        
    }
    void Start()
    {
        //audioManager.playSFX(audioManager.backgroundmusic);
    }
    public void ChangeScene(string LoadScene)
    {
        SceneManager.LoadScene("game scene");
        clickOnButton = true; // menuMenegerScript.clickOnButton = true; ---> at movementforplayer
                              // GetComponent<movmentforplayer>().enabled = true;
        NewGame1();
    }
    public void NewGame1()
    {
        destroy.RingIsOut = false;
    }


}
