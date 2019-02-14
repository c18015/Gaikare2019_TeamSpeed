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

    private void FixedUpdate()
    {
        time += Time.deltaTime;
        if ((time > 10) && (time < 20))
        {
            Image.SetActive(false);
        }
        if ((time > 15) && (time < 20))
        {
            Image2.SetActive(false);
        }
        if (time > 20)
        {
            Image3.SetActive(false);
        }
        if (time < 10)
        {
            Image.SetActive(true);
        }
        if (time < 15)
        {
            Image2.SetActive(true);
        }

    }
    void OnTriggerEnter(Collider hit)
    {
        if (hit.CompareTag("Item"))
        {
            time = time - 2.23f;
        }
    }

}
