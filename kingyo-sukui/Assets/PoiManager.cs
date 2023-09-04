using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Uduino;
public class PoiManager : MonoBehaviour
{
    // Start is called before the first frame update
    UduinoManager u;

    [SerializeField] FishMove_Uduino fish;
    [SerializeField] GameStarter gameStarter;

    int NumBreakPoi;
    [SerializeField] GameObject Zanki1;
    [SerializeField] GameObject Zanki2;
    int[] Pressure = new int[2];
    void Start()
    {
        u = UduinoManager.Instance;
        u.pinMode(AnalogPin.A0, PinMode.Input);
    }

    // Update is called once per frame
    void Update()
    {
        //Pressure[0] = 1024 - u.analogRead(AnalogPin.A0);
        Debug.Log(Pressure[0]);
        if (Pressure[1] > Pressure[0] && Pressure[1] > 800)
        {
            BreakPoi();
        }
        else if (Pressure[1] > Pressure[0] && Pressure[1] > 600)
        {
            fish.Pick();
        }
        Pressure[1] = Pressure[0];
    }

    void BreakPoi()
    {
        if (NumBreakPoi == 0)
        {
            Zanki1.SetActive(false);
            NumBreakPoi++;
        }
        else if (NumBreakPoi == 1)
        {
            Zanki2.SetActive(false);
            NumBreakPoi++;
        }
        else
        {
            gameStarter.finishgame();
            Zanki1.SetActive(false);
            Zanki2.SetActive(false);
            NumBreakPoi = 0;
        }
    }
}
