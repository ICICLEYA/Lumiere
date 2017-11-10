using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class select : MonoBehaviour {

    public GameObject BackGrundNightRave;
    public GameObject imageNightRave;
    public GameObject BackGrundWhatchild;
    public GameObject imageWhatchild;
    public GameObject BackGrundFollowme;
    public GameObject imageFollowme;
    // Use this for initialization
    void Awake () {
        BackGrundNightRave.SetActive(false);
        imageNightRave.SetActive(false);
        BackGrundWhatchild.SetActive(false);
        imageWhatchild.SetActive(false);
        BackGrundFollowme.SetActive(true);
        imageFollowme.SetActive(true);
    }
    public void GetNight()
    {
        BackGrundNightRave.SetActive(true);
        imageNightRave.SetActive(true);
        BackGrundWhatchild.SetActive(false);
        imageWhatchild.SetActive(false);
        BackGrundFollowme.SetActive(false);
        imageFollowme.SetActive(false);
    }
    public void GetWhatchild()
    {
        BackGrundNightRave.SetActive(false);
        imageNightRave.SetActive(false);
        BackGrundWhatchild.SetActive(true);
        imageWhatchild.SetActive(true);
        BackGrundFollowme.SetActive(false);
        imageFollowme.SetActive(false);
    }
    public void GetFollowme()
    {
        BackGrundNightRave.SetActive(false);
        imageNightRave.SetActive(false);
        BackGrundWhatchild.SetActive(false);
        imageWhatchild.SetActive(false);
        BackGrundFollowme.SetActive(true);
        imageFollowme.SetActive(true);
    }

}
