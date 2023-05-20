using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HearthManager : MonoBehaviour
{
    [SerializeField] private PlayerController _player;
    private bool _isRespawning;
    [SerializeField] private Vector3 _respawnPoint;
    private float respawnLength;

    public void HurtPlayer()
    {
        Respawn();
    }

    public void Respawn()
    {
        if (!_isRespawning)
        {
            StartCoroutine("RespawnCo");
        }
    }

    public IEnumerator RespawnCo()
    {
        _isRespawning = true;
        _player.gameObject.SetActive(false);
        _player.transform.parent = null;

        yield return new WaitForSeconds(respawnLength);

        _isRespawning = false;
        _player.transform.position = _respawnPoint;
        _player.gameObject.SetActive(true);
    }

    public void SetSpawnPoint(Vector3 newPosition)
    {
        _respawnPoint = newPosition;
    }
	
}
