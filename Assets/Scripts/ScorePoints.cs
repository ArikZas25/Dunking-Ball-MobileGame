using UnityEngine;
using TMPro;


public class ScorePoints : MonoBehaviour{
    public TMP_Text MyScoreText;
    public TMP_Text comboNum;
    private bool tuchedRing;
    public int score;
    public int ComboNum;

    public static bool CameraShake;

    void Start(){
        tuchedRing = false;
        score = 0;
        ComboNum = 0;
        comboNum.enabled = false;
        CameraShake = false;
    }

    public void Update()
    {
        if (ComboNum > 10)
        {
            ComboNum = 10;
            comboNum.text = "combo:+" + ComboNum.ToString();
        }
        else if (ComboNum <= 0)
        {
            comboNum.enabled = false;
            comboNum.text = "combo:+" + 0.ToString();
        }
        if (ComboNum > 0) { 
        comboNum.text = "combo:+" + ComboNum.ToString();
        comboNum.enabled = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D tuchedpoint){
       
        if (tuchedpoint.tag == "point" && tuchedRing){  
            score ++;
            MyScoreText.text = score.ToString();
            Invoke("tuchedBeforePoint", 0.1f);
        }
        else if (tuchedpoint.tag == "point" && !tuchedRing)
        {
            GotComboPoint();
            Debug.Log("combo");
        }
    }





    private void OnCollisionEnter2D(Collision2D collision){
        tuchedRing = true;
    }


    private void tuchedBeforePoint(){
        tuchedRing = false;
        ComboNum = 0;
    }
    private void GotComboPoint(){
        CameraShake = true;
        score++;
        ComboNum ++;
        score += ComboNum;// add + 1
        MyScoreText.text = score.ToString();
    }
}
