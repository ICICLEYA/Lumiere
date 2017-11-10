using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class timing : MonoBehaviour
{

    public float timetime = 0.00f;
    public int Redtiming = 1;
    public int regamamama;
    public GameObject Redthing;
    public GameObject effect1;
    public GameObject effect2;
    public GameObject effect3;

    public Transform spon;
    public Transform tomove;

    private GetColor makecolor;

    private float Red11;
    private float Bule11;
    private float Yellow11;


    void Awake()
    {
        makecolor = GameObject.Find("Button").GetComponent("GetColor") as GetColor;
        
    }
    void Update()
    {
        Red11 = makecolor.Red;
        Bule11 = makecolor.Bule;
        Yellow11 = makecolor.Yellow;

        timetime += (Mathf.Floor((Time.deltaTime * 0.75f) * 100) * 1 / 100);

        if (timetime >= 0 && 0.5 > timetime)
        {
            Redtiming = 1;
        }
        else if (timetime >= 0.5  && 0.8 > timetime)
        {
            Redtiming = 2;
        }
        else if (timetime >= 0.8 && 1.2 > timetime)
        {
            Redtiming = 3;
        }
        else if (timetime >= 1.2 && 1.5 > timetime)
        {
            Redtiming = 2;
        }
        else if(timetime >= 1.5)
        {
            Redtiming = 0;
        }

        if (Redtiming == 0)
        {
            effect1 = Instantiate(effect1, spon.position, spon.rotation);
            Redthing.SetActive(false);
            effect1.transform.SetParent(tomove);
            Destroy(effect1, 1.5f);
        }

    }
    public void Redclick()
    {

        if (Red11 == 1)
        {
            if (Redtiming == 1)
            {
                effect1 = Instantiate(effect1, spon.position, spon.rotation);
                Redthing.SetActive(false);
                effect1.transform.SetParent(tomove);
                Destroy(effect1, 1.5f);
            }
            else if (Redtiming == 2)
            {
                effect2 = Instantiate(effect2, spon.position, spon.rotation);
                Redthing.SetActive(false);
                effect2.transform.SetParent(tomove);
                Destroy(effect2, 1.5f);
            }
            else if (Redtiming == 3)
            {
                effect3 = Instantiate(effect3, spon.position, spon.rotation);
                Redthing.SetActive(false);
                effect3.transform.SetParent(tomove);
                Destroy(effect3, 1.5f);
            }
            else if (Redtiming == 0)
            {
                effect1 = Instantiate(effect1, spon.position, spon.rotation);
                Redthing.SetActive(false);
                effect1.transform.SetParent(tomove);
                Destroy(effect1, 1.5f);
            }
        }
        else if (Redtiming == 0)
        {
            Destroy(Redthing);
            effect1 = Instantiate(effect1, spon.position, spon.rotation);
            Redthing.SetActive(false);
            effect1.transform.SetParent(tomove);
            Destroy(effect1, 1.5f);
        }
        else
        {
            effect1 = Instantiate(effect1, spon.position, spon.rotation);
            Redthing.SetActive(false);
            effect1.transform.SetParent(tomove);
            Destroy(effect1, 1.5f);
        }
    }
}
