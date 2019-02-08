using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ResultController : MonoBehaviour
{

    public GameObject Image;
    public GameObject Image2;
    public GameObject Image3;
    float time;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame

    void Update()
    {

        time += Time.deltaTime;

        if ((time > 5) && (time <= 20))
        {
            Image.SetActive(false);

        }
        if ((time > 15) && (time <= 20))
        {
            Image2.SetActive(false);

        }
        if (time > 20)
        {
            Image3.SetActive(false);

        }

        Vector3 pos = transform.position;
        transform.position = pos;

        if (pos.z >= 250)
        {
            if ((time > 0) && (time <= 10))
            {
                SceneManager.LoadScene("GameClear(3stars)");
            }
            if ((time > 10) && (time <= 15))
            {
                SceneManager.LoadScene("GameClear(2stars)");
            }
            if ((time > 15) && (time <= 20))
            {
                SceneManager.LoadScene("GameClear(1star)");
            }
        }

        if (time >= 20)
        {
            SceneManager.LoadScene("GameOver");
        }

    }

    void OnTriggerEnter(Collider hit)
    {
        if (hit.CompareTag("Item"))
        {
            if ((time > 10) && (time <= 15))
            {
                Image.SetActive(true);
            }
            if ((time > 15) && (time <= 20))
            {
                Image2.SetActive(true);
            }

            time = time - 5;

        }

    }
}
