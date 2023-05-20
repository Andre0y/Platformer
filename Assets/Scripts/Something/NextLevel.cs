using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class NextLevel : MonoBehaviour
{
    private MenuManager _menuManager;

    private void Start()
    {
        _menuManager = FindObjectOfType<MenuManager>();
    }

    private void OnTriggerEnter(Collider collider)
	{
		if (collider.gameObject.tag == "Player")
		{
            _menuManager.NextLevel();
		}
	}
}
	
