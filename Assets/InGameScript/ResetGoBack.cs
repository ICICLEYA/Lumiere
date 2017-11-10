using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetGoBack : MonoBehaviour {

    public void GetBack()
    {
        SceneManager.LoadScene(2);
    }
    public void Reset()
    {
        SceneManager.LoadScene(3);
    }
    public void GetBB()
    {
        SceneManager.LoadScene(1);
    }
}
