using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour {

    public GameObject BackBack;
    public GameObject play;
    public GameObject pause1;
    public GameObject pause2;
    public GameObject Backtomeun;
    public GameObject Regame;

    public float fuck;

    private timing fuckyou;

    void Awake()
    {
        BackBack.SetActive(false);
        pause2.SetActive(false);
        play.SetActive(false);
        Backtomeun.SetActive(false);
        Regame.SetActive(false);
        fuckyou = GameObject.Find("Button").GetComponent("timing") as timing;

    }

    public void Pausee()
    {
        fuck = fuckyou.timetime;
        BackBack.SetActive(true);
        pause1.SetActive(false);
        pause2.SetActive(true);
        play.SetActive(true);
        Backtomeun.SetActive(true);
        Regame.SetActive(true);
        fuck = Time.timeScale = 0;
    }

    public void Pause2()
    {
        BackBack.SetActive(false);
        pause1.SetActive(true);
        pause2.SetActive(false);
        play.SetActive(false);
        Backtomeun.SetActive(false);
        Regame.SetActive(false);
        fuck = Time.timeScale = 1;

    }
}
