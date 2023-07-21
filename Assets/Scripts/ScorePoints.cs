using UnityEngine;
using TMPro;


public class ScorePoints : MonoBehaviour {
    [Header("--------- score ---------")]
    public TMP_Text MyScoreText;
    public TMP_Text highScoreText;
    public TMP_Text comboNum;
    private bool tuchedRing;
    public int score;
    public static int ComboNumber;

    [Header("--------- color ---------")]
    [SerializeField] private Material myCelingMaterial;
    [SerializeField] private Material myFloorMaterial;
    [SerializeField] private Material PlayerMat;
    [SerializeField] private Material combo1color;
    [SerializeField] private Material combo2color;
    [SerializeField] private Material combo3color;
    [SerializeField] private Material combo4color;
    [SerializeField] private Material combo5color;
    [SerializeField] private Material combo6color;
    [SerializeField] private Material combo7color;
    [SerializeField] private Material combo8color;
    [SerializeField] private Material combo9color;
    [SerializeField] private Material combo10color;


    [Header("--------- shake ---------")]
    public static bool CameraShake;

    void Start() {
        if (score > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", score);
            highScoreText.text = score.ToString();
        }
        tuchedRing = false;
        score = 0;
        ComboNumber = 0;
        comboNum.enabled = false;
        CameraShake = false;

        highScoreText.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
    }

    public void Update()
    {
        if (ComboNumber > 10)
        {
            ComboNumber = 10;
            comboNum.text = "combo:+" + ComboNumber.ToString();
        }
        else if (ComboNumber <= 0)
        {
            comboNum.enabled = false;
            comboNum.text = "combo:+" + 0.ToString();
        }
        if (ComboNumber > 0) {
            comboNum.text = "combo:+" + ComboNumber.ToString();
            comboNum.enabled = true;
        }

    }

    private void OnTriggerEnter2D(Collider2D tuchedpoint){
       
        if (tuchedpoint.tag == "point" && tuchedRing){  
            score ++;
            MyScoreText.text = score.ToString();
            Invoke("tuchedBeforePoint", 0.1f);
            if(score > PlayerPrefs.GetInt("HighScore", 0))
            {
                PlayerPrefs.SetInt("HighScore", score);
                highScoreText.text = score.ToString();
            }
           
        }
        else if (tuchedpoint.tag == "point" && !tuchedRing)
        {
            GotComboPoint();
            CheckifColorChange();
            Debug.Log("combo");
            
        }
    }

   





    private void OnCollisionEnter2D(Collision2D collision){
        tuchedRing = true;
        if (tuchedRing)
        {
            PlayerMat.color = Color.red;
        }
        if (collision.collider.tag == "celing")
        {
            myCelingMaterial.color = Color.red;
            GameMeneger.GameIsOver = true;
        }
        if (collision.collider.tag == "floor")
        {
            myFloorMaterial.color = Color.red;
            GameMeneger.GameIsOver = true;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (tuchedRing)
        {
            PlayerMat.color = Color.white;
        }
    }
    /*
    private void OnCollisionExit2D(Collision2D collision)
    {

        myCelingMaterial.color = Color.yellow;
        myFloorMaterial.color = Color.yellow;
    }
    */

    private void tuchedBeforePoint(){
        tuchedRing = false;
        ComboNumber = 0;
    }
    private void GotComboPoint(){
        CameraShake = true;
        score++;
        ComboNumber++;
        score += ComboNumber;// add + 1
        MyScoreText.text = score.ToString();
        Invoke("CameraStopShake", 0.5f);
        if (score > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", score);
            highScoreText.text = score.ToString();
        }
    }

    private void CameraStopShake()
    {
        CameraShake = false;
    }

    void CheckifColorChange()
    {

        if (ComboNumber == 0)
        {
            PlayerMat.color = Color.white;
        }
        else if (ComboNumber == 1)
        {
            PlayerMat.color = combo1color.color;
        }
        else if (ComboNumber == 2)
        {
            PlayerMat.color = combo2color.color;
        }
        else if (ComboNumber == 3)
        {
            PlayerMat.color = combo3color.color;
        }
        else if (ComboNumber == 4)
        {
            PlayerMat.color = combo4color.color;
        }
        else if (ComboNumber == 5)
        {
            PlayerMat.color = combo5color.color;
        }
        else if (ComboNumber == 6)
        {
            PlayerMat.color = combo6color.color;
        }
        else if (ComboNumber == 7)
        {
            PlayerMat.color = combo7color.color;
        }
        else if (ComboNumber == 8)
        {
            PlayerMat.color = combo8color.color;
        }
        else if (ComboNumber == 9)
        {
            PlayerMat.color = combo9color.color;
        }
        else if (ComboNumber == 10)
        {
            PlayerMat.color = combo10color.color;

        }
    }
}
