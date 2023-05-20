using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalMovePlatform : MonoBehaviour {

    [SerializeField] private int _appLitude = 5;
    private float _frequency = 1;
    
    private void Update()
    {
        float x = transform.position.x;
        float y = Mathf.Cos(Time.time * _frequency) * _appLitude;
        float z = transform.position.z;

        transform.position = new Vector3(x, y, z);
    }

    private void OnTriggerStay(Collider other)
    {
        if (((other.gameObject.tag == "Player") && other.GetComponent<CharacterController>().isGrounded))
        {
            other.transform.parent = transform;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.transform.parent = null;
        }
    }
}
