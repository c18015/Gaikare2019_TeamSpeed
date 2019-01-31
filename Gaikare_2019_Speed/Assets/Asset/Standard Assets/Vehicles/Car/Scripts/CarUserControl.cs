using System;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

namespace UnityStandardAssets.Vehicles.Car
{
    [RequireComponent(typeof (CarController))]
    public class CarUserControl : MonoBehaviour
    {
        private CarController m_Car; // the car controller we want to use


        private void Awake()
        {
            // get the car controller
            m_Car = GetComponent<CarController>();
        }


        private void FixedUpdate()
        {
            // pass the input to the car!
            //float h = CrossPlatformInputManager.GetAxis("Horizontal");
            float v = 1f; // CrossPlatformInputManager.GetAxis("Vertical");
            float h = Input.acceleration.x;
            //float v = Input.acceleration.y;

            if (h >= 0.2f)
            {
                h = 0.1f;
            }

            if (h <= -0.2f)
            {
                h = -0.1f;
            }


#if !MOBILE_INPUT
            float handbrake = CrossPlatformInputManager.GetAxis("Jump");
            m_Car.Move(h, v, v, handbrake);
#else
            m_Car.Move(h * 1.5f, v, v, 0f);
#endif
        }
    }
}
