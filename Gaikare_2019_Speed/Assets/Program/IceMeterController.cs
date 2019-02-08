using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IceMeterController : MonoBehaviour
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
    void FixedUpdate()
    {

        time += Time.deltaTime;

        if (time > 10)
        {
            Image.SetActive(false);

        }
        if (time > 20)
        {
            Image2.SetActive(false);

        }
        if (time > 30)
        {
            Image3.SetActive(false);

        }
    }

    void OnTriggerEnter(Collider hit)
    {
        if (hit.CompareTag("Item"))
        {
            if (time < 20)
            {
                Image.SetActive(true);
            }
            if (time < 30)
            {
                Image2.SetActive(true);
            }

            time = time - 10;

        }
    }
}
