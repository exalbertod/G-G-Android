using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class UIManagerScript : MonoBehaviour {
    public void StartGame()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void doquit()
    {
        Debug.Log("exit");
        Application.Quit();

    }

    public void Resert()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void Pause()
    {
        if (Time.timeScale == 1)
        {
            Time.timeScale = 0;
        }
        else if (Time.timeScale == 0)
        {
            Time.timeScale = 1;
        }
    }
}
