using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Startanimation : MonoBehaviour {

    public Renderer Star1;
    public Renderer Star2;
    public Renderer Star3;
    public Renderer Star4;

    public Renderer starset;
    public Renderer star2set;
    public Renderer star3set;

    public float Star1speed = 2f;
    public float Star2speed = 1f;
    public float Star3speed = 2.2f;
    public float Star4speed = 2.5f;

    public float time = 0f;


    public int ttt1;
    // Use this for initialization
    void Awake() {


    }

    // Update is called once per frame


    void Update()
    {
        time += Time.deltaTime;


        Star1.material.color = new Color(Star1.material.color.r, Star1.material.color.g, Star1.material.color.b, 1 + Mathf.Sin(time * Star1speed));
        Star2.material.color = new Color(Star2.material.color.r, Star2.material.color.g, Star2.material.color.b, 1 + Mathf.Sin(time * Star2speed));
        Star3.material.color = new Color(Star3.material.color.r, Star3.material.color.g, Star3.material.color.b, 1 + Mathf.Sin(time * Star3speed));
        Star4.material.color = new Color(Star4.material.color.r, Star4.material.color.g, Star4.material.color.b, 1 + Mathf.Sin(time * Star4speed));
        starset.material.color = new Color(starset.material.color.r, starset.material.color.g, starset.material.color.b, 1 +Mathf.Cos(time * Star2speed));
        star2set.material.color = new Color(star2set.material.color.r, star2set.material.color.g, star2set.material.color.b, 1 + Mathf.Cos(time * Star2speed));
        star3set.material.color = new Color(star3set.material.color.r, star3set.material.color.g, star3set.material.color.b, 1 + Mathf.Cos(time * Star2speed));


    }
}
