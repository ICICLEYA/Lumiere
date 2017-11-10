using System.Collections;
using LitJson;
using System.Collections.Generic;
using UnityEngine;

public class VarTXTreading : MonoBehaviour
{
    public float timin;
    public TextAsset jsonDate;
    public int noteCount = -1;
    public List<string> time = new List<string>();
    public List<string> xcoord = new List<string>();
    public List<string> ycoord = new List<string>();
    public GameObject Thenote;
    public Transform popo;
    // Use this for initialization
    void Awake()
    {
        timin = timin * 100;
        Mathf.Floor(timin);
        timin = timin * 1/100;
    }

    // Update is called once per frame

    void ParseNote()
    {
        LitJson.JsonData getData = LitJson.JsonMapper.ToObject(jsonDate.text);
        noteCount = getData["note"].Count;
        for (int i = 0; i < getData["note"].Count; i++)
        {
            string x = getData["note"][i]["Xda"].ToString();
            string y = getData["note"][i]["Yda"].ToString();
            string t = getData["note"][i]["time"].ToString();

            Debug.Log("X : " + x);
            time.Add(t);
            xcoord.Add(x);
            ycoord.Add(y);


        }
    }

    void Update()
    {
        LitJson.JsonData getData = LitJson.JsonMapper.ToObject(jsonDate.text);
        
        timin += timin + Time.deltaTime * 1/2;
        
        Debug.Log(timin);
        for (int a = 0; a < getData["note"].Count; a++)
        {

            popo.transform.position = new Vector3(float.Parse(xcoord[a]), float.Parse(ycoord[a]),0);

            if (timin == float.Parse(time[a]))
            {
                Thenote = Instantiate(Thenote, popo.position, popo.rotation);
            }
        }
        
    }
}
