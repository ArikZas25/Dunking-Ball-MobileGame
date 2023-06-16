using UnityEngine;
using TMPro;


public class ScorePoints : MonoBehaviour{
    public TMP_Text MyScoreText;
    public TMP_Text comboNum;
    private bool tuchedRing;
    public int score;
    public int ComboNum;

    void Start(){
        tuchedRing = true;
        score = 0;
        ComboNum = 0;
    }

    public void Update(){
        if (ComboNum > 10){
            ComboNum = 10;
            comboNum.text = ComboNum.ToString();
        }
        if (ComboNum > 1) { 
        comboNum.text = ComboNum.ToString();
        }else if (ComboNum <= 0) {
         comboNum.text = 0.ToString();
        }
    }

    private void OnTriggerEnter2D(Collider2D tuchedpoint){
       
        if (tuchedpoint.tag == "point" && tuchedRing){
            MyScoreText.text = score.ToString();
            score ++;
            Invoke("tuchedBeforePoint", 0.1f);
            Debug.Log("point");
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
        MyScoreText.text = score.ToString();
        score += ComboNum + 1;
        ComboNum += 1;
    }
}
