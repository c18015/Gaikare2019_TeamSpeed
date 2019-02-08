using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene_Con : MonoBehaviour {


    public void Go_Main_Scene()
    {
        //Application.LoadLevel("Debug_Scene");
        Application.LoadLevel("Main_Scene");
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

