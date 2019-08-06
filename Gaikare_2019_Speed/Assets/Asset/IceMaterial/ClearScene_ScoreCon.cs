using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClearScene_ScoreCon : MonoBehaviour {

    public Text ClearTimeText;
    public GameObject[] ClearRank;

    // Use this for initialization
    void Start () {
        ClearTimeText.text = "クリアタイム：" + PlayerPrefs.GetFloat("StageClearTime").ToString("f1") + "秒";
	}
	
	// Update is called once per frame
	void Update () {

        if (PlayerPrefs.GetInt("ScoreRank") == 3) ClearRank[0].SetActive(true);
        if (PlayerPrefs.GetInt("ScoreRank") == 2) ClearRank[1].SetActive(true);
        if (PlayerPrefs.GetInt("ScoreRank") == 1) ClearRank[2].SetActive(true);
    }
}
//.ToString("f2")
