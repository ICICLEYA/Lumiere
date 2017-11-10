using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bebig : MonoBehaviour {

    public GameObject notenote;
    public float past;
	// Update is called once per frame
	void Update () {
        past += (Mathf.Floor((Time.deltaTime * 0.75f) * 100) * 1 / 100);

        notenote.transform.localScale = new Vector2(past, past);


    }
}
