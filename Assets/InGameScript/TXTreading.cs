using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using System.IO;
using System.Linq;

public class TXTreading : MonoBehaviour {

   /* string filepath = "Assets/Formusictxt/example.txt";
    string[] filelines = File.ReadAllLines("filepath");*/

    public void WriteData(string strData)
    {

        /*FileInfo theSourceFile = null;
        StreamReader reader = null;

        theSourceFile = new FileInfo(Application.dataPath + "Formusictxt/example.txt");
        if (theSourceFile != null && theSourceFile.Exists)
            reader = theSourceFile.OpenText();

        if (reader == null)
        {
            Debug.Log("puzzles.txt not found or not readable");
        }
        else
        {
            // Read each line from the file
            while ((filepath = reader.ReadLine()) != null )
            {
                Debug.Log("-->" + "example.txt");
            }
        }
        */

        /*TextAsset puzdata = (TextAsset)Resources.Load("example", typeof(TextAsset));
        // puzdata.text is a string containing the whole file. To read it line-by-line:
        reader = new StringReader(puzdata.text);
        if (reader == null)
        {
            Debug.Log("puzzles.txt not found or not readable");
        }
        else
        {
            // Read each line from the file
            while ((filepath = reader.ReadLine()) != null )
      Debug.Log("-->" + filepath);
        }*/


    }

    void ParseFile()
    {
        string text = File.ReadAllText("/example.txt");

        char[] separators = { ',', ';', '|' };
        string[] strValues = text.Split(separators);

        List<int> intValues = new List<int>();
        foreach (string str in strValues)
        {
            int val = 0;
            if (int.TryParse(str, out val))
            {
                intValues.Add(val);
            }
        }
        
    }
}
