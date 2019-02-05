using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene_Con : MonoBehaviour {


    public void Go_Main_Scene()
    {
        Application.LoadLevel("Debug_Scene");
        //Application.LoadLevel("Main");
    }

    public void Back_Title_Scene()
    {
        Application.LoadLevel("Title");
        
    }

    public void Go_Result_Scene()
    {
        Application.LoadLevel("Result_Scene");

    }

    public void GameEnd()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#elif UNITY_WEBPLAYER
		Application.Quit();
#endif
    }
}
