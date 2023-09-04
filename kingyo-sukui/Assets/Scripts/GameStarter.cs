using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStarter : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject higoi;
    [SerializeField] Scorer scorer;

    bool Playing;

    float PlayTime;
    void Start()
    {
        higoi.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            higoi.SetActive(true);
            Playing = true;
        }

        if (Playing)
        {
            PlayTime += Time.deltaTime;
            if (PlayTime > 10)
            {
                finishgame();
            }
        }
    }

    public void finishgame(){
        scorer.ResetScore();
        higoi.SetActive(false);
        Playing = false;
        PlayTime = 0;
    }
}
