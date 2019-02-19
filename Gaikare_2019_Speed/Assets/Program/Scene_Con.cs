using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene_Con : MonoBehaviour {
    public GameObject StageSelectGUI;

    public void SelectGUIon ()
    { 
        StageSelectGUI.SetActive(true);
    }

    public void SelectGUIoff()
    {
        StageSelectGUI.SetActive(false);
    }

    public void Go_Stage1()
    {
        //Application.LoadLevel("Debug_Scene");
        Application.LoadLevel("Stage1_Easy");
    }
    public void Go_Stage2()
    {
        //Application.LoadLevel("Debug_Scene");
        Application.LoadLevel("Stage2_Normal");
    }

    public void Go_Stage3()
    {
        //Application.LoadLevel("Debug_Scene");
        Application.LoadLevel("Stage3_Hard");
    }
    public void Back_Title_Scene()
    {
        Application.LoadLevel("Title");
        
    }

    public void Go_Clear_Scene()
    {
        Application.LoadLevel("Clear");

    }

    public void Go_Failure_Scene()
    {
        Application.LoadLevel("Failure");

    }

    public void GameEnd()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#elif UNITY_WEBPLAYER
		Application.OpenURL("http://www.yahoo.co.jp/");
#else
		Application.Quit();
#endif
    }
}

