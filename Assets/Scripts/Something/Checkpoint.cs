using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    [SerializeField] private Renderer _renderer;
    [SerializeField] private Material _checkpointOn;
    [SerializeField] private Material _checkpointOff;

    private HearthManager _hearthManager;

    private void Start()
    {
        _renderer = GetComponent<Renderer>();
        _hearthManager = FindObjectOfType<HearthManager>();
    }

    private void CheckpointOn()
    {
        Checkpoint[] checkpoints = FindObjectsOfType<Checkpoint>();

        foreach (var Checkpoint in checkpoints)
        {
            Checkpoint.CheckpointOff();
        }

        _renderer.material = _checkpointOn;
    }

    private void CheckpointOff()
    {
        _renderer.material = _checkpointOff;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            CheckpointOn();
            _hearthManager.SetSpawnPoint(transform.position);
        }
    }



}
