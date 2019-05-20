using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;
using UnityEngine.SceneManagement;
using System;

public class selectionballscript : MonoBehaviour {

    public GameObject[] balls;
    public GameObject player;
    int count = 0;
 

	void Start () {
        balls[count].SetActive(true);
        
    }
	
	// Update is called once per frame
	void Update () {
        player = GameObject.FindGameObjectWithTag("Player");
        player.transform.Rotate(0, 2, 0);
	}

    public void nextball() {
        if (count < 16)
        {
            balls[count].SetActive(false);
            count = count + 1;
            balls[count].SetActive(true);
        }
    }

    public void previousball()
    {
        if (count > 1)
        {
            balls[count].SetActive(false);
            count = count - 1;
            balls[count].SetActive(true);
        }

    }
    public void setball() {
        if (Advertisement.IsReady())
        {
            Advertisement.Show();
        }

        PlayerPrefs.SetInt("ballno", count);
        SceneManager.LoadScene("gamecontrollerer");
    }
}
