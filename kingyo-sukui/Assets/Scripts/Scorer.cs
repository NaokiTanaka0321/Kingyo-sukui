using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Scorer : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] TextMeshProUGUI score_text;
    int score = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddScore(){
        score++;
        Debug.Log(score);
        score_text.text = "SCORE:" + score; //str型とintでも結合できる
    }

    public void ResetScore(){
        score_text.text = "FINISH! SCORE:" + score;
        score = 0;
        Debug.Log(score);
    }

}
