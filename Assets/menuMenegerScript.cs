using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuMenegerScript : MonoBehaviour
{
    public static bool GameOverBool;
    public void ChangeScene(string LoadScene)
    {
        SceneManager.LoadScene("game scene");
        GameOverBool = false; // menuMenegerScript.GameOverBool = true; ---> at movementforplayer
    } 
}
