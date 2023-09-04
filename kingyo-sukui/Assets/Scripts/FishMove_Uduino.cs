using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishMove_Uduino : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Scorer scorer;

    bool Staying;

    int NumPoi = 3;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate (0.0f, 0.4f, 0.0f, Space.World );
    }

    void OnTriggerEnter(Collider col){
        if (col.gameObject.CompareTag("Poi"))
        {
            Staying = true;
        }
    }

    void OnTriggerExit(Collider col){
        if (col.gameObject.CompareTag("Poi"))
        {
            Staying = false;
        }
    }

    public void Pick(){
        if (Staying)
        {
            Debug.Log("PICK");
            float x = Random.Range(-7.0f, 7.0f);
            float z = Random.Range(-4.0f, 4.0f);
            transform.position = new Vector3(x,0f,z);

            scorer.AddScore();
            Staying = false;
        }
    }

    

    


}
