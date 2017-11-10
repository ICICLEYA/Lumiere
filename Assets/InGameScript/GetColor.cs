using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetColor : MonoBehaviour {

    public GameObject R100;
    public GameObject B100;
    public GameObject Y100;

    public float tt = 0;
    public float Red = 0;
    public float Bule = 0;
    public float Yellow = 0;


    void Awake() {

        R100.SetActive(false);
        B100.SetActive(false);
        Y100.SetActive(false);


    }
    // Use this for initialization
    public void RedOnButten()
    {
        R100.SetActive(true);
        B100.SetActive(false);
        Y100.SetActive(false);
        Red++;
        Bule = 0;
        Yellow = 0;
    }

    // Update is called once per frame
    public void BuleOnButten () {
        B100.SetActive(true);
        R100.SetActive(false);
        Y100.SetActive(false);
        Bule++;
        Red = 0;
        Yellow = 0;
    }

    public void YellowOnButton() {
        Y100.SetActive(true);
        R100.SetActive(false);
        B100.SetActive(false);
        Yellow++;
        Red = 0;
        Bule = 0;
    }


}
