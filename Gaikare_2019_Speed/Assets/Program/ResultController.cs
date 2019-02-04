using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ResultController : MonoBehaviour {

    float time;


	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame

    void Update ()
    {
        time += Time.deltaTime;

    Vector3 pos = transform.position;
        transform.position = pos;

        if (pos.z >= 180)
        {
            if (time < 10)
            {
                SceneManager.LoadScene("GameClear(3stars)");
            }
            if (time >= 10)
            {
                SceneManager.LoadScene("GameClear(2stars)");
            }
            if (time >= 15)
            {
                SceneManager.LoadScene("GameClear(1star)");
            }

        }

        if (pos.z < 180)
        {
            if (time >= 20)
            {
                SceneManager.LoadScene("GameOver");
            }

        }
        
    }


}
