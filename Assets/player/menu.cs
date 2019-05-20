using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour {

    //int ballno;
    private void Start()
    {
       // ballno=PlayerPrefs.GetInt("ballno");
    }

    public  void PlayGame() {
        SceneManager.LoadScene("main");
    }

    public void ballselect()
    {
        SceneManager.LoadScene("gameplayerselection");
    }
}
