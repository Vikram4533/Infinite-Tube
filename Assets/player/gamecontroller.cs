using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class gamecontroller : MonoBehaviour {

    int checkadd=1;
    public string placementId = "rewardedVideo";

    public Text score;
    public static int count = 0;
    int beforecount;
    int vik;

    public GameObject scoreobject;
    public Text yourscore;
    public Text highscore;
    public GameObject gameover;
    public GameObject pause;
    public GameObject adbutton;

    public GameObject p1;
    public GameObject p2;
    public GameObject p3;
    public GameObject p4;
    public GameObject p5;
    public GameObject p6;
    public GameObject p7;
    public GameObject p8;
    public GameObject p9;
    public GameObject p10;

    public GameObject p11;
    public GameObject p12;
    public GameObject p13;
    public GameObject p14;
    public GameObject p15;
    public GameObject p16;

    [SerializeField]
    public GameObject[] balls;

    int ballno;
    int presentscore;

    public GameObject player;
    float dist=0;
    float widthh=0;
    private void Start()
    {
       
        ballno = PlayerPrefs.GetInt("ballno",0);
        Instantiate(balls[ballno]);
        player = GameObject.FindGameObjectWithTag("Player");
        player.AddComponent<check>();
        vik = PlayerPrefs.GetInt("HIGHSCORE", 0);
        highscore.text = "HIGH SCORE :" + vik.ToString();
    }


    private void FixedUpdate()
    {

        if (player)
        {
            score.text = (count / 10).ToString();
            if (player.transform.position.z - dist > 10000)
            {
                widthh = player.transform.position.z + 10;
                int k = Random.Range(0, 16);
                switch (k)
                {
                    case 0:
                        Instantiate(p1, new Vector3(0, 0, widthh), Quaternion.Euler(new Vector3(0, 0, Random.Range(0, 360))));
                        break;
                    case 1:
                        Instantiate(p2, new Vector3(0, 0, widthh), Quaternion.Euler(new Vector3(0, 0, Random.Range(0, 360))));
                        break;
                    case 2:
                        Instantiate(p3, new Vector3(0, 0, widthh), Quaternion.Euler(new Vector3(0, 0, Random.Range(0, 360))));
                        break;
                    case 3:
                        Instantiate(p4, new Vector3(0, 0, widthh), Quaternion.Euler(new Vector3(0, 0, Random.Range(0, 360))));
                        break;
                    case 4:
                        Instantiate(p5, new Vector3(0, 0, widthh), Quaternion.Euler(new Vector3(0, 0, Random.Range(0, 360))));
                        break;
                    case 5:
                        Instantiate(p6, new Vector3(0, 0, widthh), Quaternion.Euler(new Vector3(0, 0, Random.Range(0, 360))));
                        break;
                    case 6:
                        Instantiate(p7, new Vector3(0, 0, widthh), Quaternion.Euler(new Vector3(0, 0, Random.Range(0, 360))));
                        break;
                    case 7:
                        Instantiate(p8, new Vector3(0, 0, widthh), Quaternion.Euler(new Vector3(0, 0, Random.Range(0, 360))));
                        break;
                    case 8:
                        Instantiate(p9, new Vector3(0, 0, widthh), Quaternion.Euler(new Vector3(0, 0, Random.Range(0, 360))));
                        break;
                    case 9:
                        Instantiate(p10, new Vector3(0, 0, widthh), Quaternion.Euler(new Vector3(0, 0, Random.Range(0, 360))));
                        break;
                    case 10:
                        Instantiate(p11, new Vector3(0, 0, widthh), Quaternion.Euler(new Vector3(0, 0, Random.Range(0, 360))));
                        break;
                    case 11:
                        Instantiate(p12, new Vector3(0, 0, widthh), Quaternion.Euler(new Vector3(0, 0, Random.Range(0, 360))));
                        break;
                    case 12:
                        Instantiate(p13, new Vector3(0, 0, widthh), Quaternion.Euler(new Vector3(0, 0, Random.Range(0, 360))));
                        break;
                    case 13:
                        Instantiate(p14, new Vector3(0, 0, widthh), Quaternion.Euler(new Vector3(0, 0, Random.Range(0, 360))));
                        break;
                    case 14:
                        Instantiate(p15, new Vector3(0, 0, widthh), Quaternion.Euler(new Vector3(0, 0, Random.Range(0, 360))));
                        break;
                    case 15:
                        Instantiate(p16, new Vector3(0, 0, widthh), Quaternion.Euler(new Vector3(0, 0, Random.Range(0, 360))));
                        break;
                }
                dist = player.transform.position.z;
            }
            count = count + 1;
        }

        else {
            pause.SetActive(false);
            scoreobject.SetActive(false);
            int number = count / 10;
            if (number > vik)
            {
                PlayerPrefs.SetInt("HIGHSCORE", number);
                highscore.text = "HIGH SCORE :" + number.ToString();
                yourscore.text = "YOUR SCORE : " + number.ToString();
            }
            else
            {
                yourscore.text = "YOUR SCORE : " + score.text;
            }
            GameObject[] obs = GameObject.FindGameObjectsWithTag("obstacle");
            for (int i = 0; i < obs.Length; i++)
            {
                Destroy(obs[i]);
            }
            if (checkadd==1) {
                if (Advertisement.IsReady("rewardedVideo"))
                {
                    adbutton.SetActive(true);
                }

                else
                {
                    adbutton.SetActive(false);
                }
                gameover.SetActive(true); ;
                beforecount = count;
               
            }
            }
    }
    




    public GameObject pausepanel;
    
    public void pausegame()
    {
        pausepanel.SetActive(true);
        Time.timeScale = 0f;
    }

    public void play()
    {

        pausepanel.SetActive(false);
        Time.timeScale = 1f;

    }

    public void playbigg()
    {
        Time.timeScale = 1f;
        count = 0;
        pausepanel.SetActive(false);
        SceneManager.LoadScene("gamecontrollerer");
    }
    public void quitgg()
    {
        Application.Quit();
    }


    public void ShowAd ()
    {
       ShowOptions options = new ShowOptions();
        options.resultCallback = HandleShowResult;

        Advertisement.Show(placementId, options);
    }

    void HandleShowResult (ShowResult result)
    {
        if(result == ShowResult.Finished) {
            count  = beforecount;
            checkadd = 0;
            SceneManager.LoadScene("main");

        }
        else if(result == ShowResult.Skipped) {
            SceneManager.LoadScene("gamecontrollerer");

        }
        else if(result == ShowResult.Failed) {
            SceneManager.LoadScene("gamecontrollerer");
        }
    }

}
    


