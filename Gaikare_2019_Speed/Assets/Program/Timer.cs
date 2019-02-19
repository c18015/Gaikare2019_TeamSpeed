using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

    public float countTime;
    public GameObject[] IceMeter;


    // Use this for initialization   PlayerPrefs.SetInt("ScoreRank", 3);
    void Start () {

    }
	
	// Update is called once per frame
	void Update () {

        float T1 = 0 + Time.deltaTime;
        countTime = countTime - T1;

        if (countTime > 31) countTime = 30;
        if (countTime < 0) countTime = 0;


        //GetComponent<Text>().text = "残り時間:" + countTime.ToString("F0");


        if (countTime > 20f) PlayerPrefs.SetInt("ScoreRank", 3);
        if (countTime < 20f)
        {
            IceMeter[0].SetActive(false);
            PlayerPrefs.SetInt("ScoreRank", 2);

        }
        else
        {
            IceMeter[0].SetActive(true);
        }
        if (countTime < 10f)
        {
            IceMeter[1].SetActive(false);
            PlayerPrefs.SetInt("ScoreRank", 1);

        }
        else
        {
            IceMeter[1].SetActive(true);
        }
        if (countTime == 0f)
        {
            IceMeter[2].SetActive(false);
            Invoke("GameOverTP", 2f);
        }
        else
        {
            IceMeter[2].SetActive(true);
        }

        
        

    }

    public void PlusTime(int amount)
    {
        countTime += amount;
    }

        void GameOverTP()
    {
        Application.LoadLevel("GameOver");
    }
}
