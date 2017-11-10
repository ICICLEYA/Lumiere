using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CheckMode : MonoBehaviour {
    public GameObject MusicBg;
    public GameObject AchiveBg;
    public GameObject CreditBg;
    public GameObject OptionBg;


    void Awake () {
        MusicBg.SetActive(true);
        AchiveBg.SetActive(false);
        CreditBg.SetActive(false);
        OptionBg.SetActive(false);
    }

    public void MusicGet()
    {
        MusicBg.SetActive(true);
        AchiveBg.SetActive(false);
        CreditBg.SetActive(false);
        OptionBg.SetActive(false);
    }

    public void AchiveGet()
    {
        MusicBg.SetActive(false);
        AchiveBg.SetActive(true);
        CreditBg.SetActive(false);
        OptionBg.SetActive(false);
    }
	
    public void CreditGet()
    {
        MusicBg.SetActive(false);
        AchiveBg.SetActive(false);
        CreditBg.SetActive(true);
        OptionBg.SetActive(false);
    }

    public void OptionGet()
    {
        MusicBg.SetActive(false);
        AchiveBg.SetActive(false);
        CreditBg.SetActive(false);
        OptionBg.SetActive(true);
    }

    public void Getmusic()
    {
        SceneManager.LoadScene(2);
    }
}
