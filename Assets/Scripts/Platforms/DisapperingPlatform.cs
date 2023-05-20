using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisapperingPlatform : MonoBehaviour
{
    [SerializeField] private float _disapperingTime;
    private float _currentTime;

    private void Update()
    {
        _currentTime += Time.deltaTime;

        if (_currentTime >= _disapperingTime)
        {
            _currentTime = 0;

            if (gameObject.GetComponent<Renderer>().enabled == true)
            {
                gameObject.GetComponent<Renderer>().enabled = false;
                gameObject.GetComponent<BoxCollider>().enabled = false;
            }

            else
            {
                gameObject.GetComponent<Renderer>().enabled = true;
                gameObject.GetComponent<BoxCollider>().enabled = true;
            }
        }
    }

}
