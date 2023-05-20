using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour 
{
	[SerializeField] private Text _coinsText;
	[SerializeField] private AudioSource _collectCoinSound;
    [SerializeField] private AudioSource _backgroundSound;
    [SerializeField] private AudioSource _damageSound;
    [SerializeField] private AudioSource _jumpSound;

    public int _currentGold;

    private void Awake()
    {
        _currentGold = PlayerPrefs.GetInt("coins");
        
        if (PlayerPrefs.GetInt("coins") <= 0)
        {
            _currentGold = 0;
        }
    }

    private void Start()
    {
        _coinsText.text = "Coins:" + _currentGold;
        _backgroundSound.Play();
    }

    private void Update()
    {
        if (Input.GetKeyDown("escape"))
        {
            Application.Quit();
        }  
    }

    public void AddGold(int goldToAdd)
    {
        _currentGold += goldToAdd;
        _coinsText.text = "Coins:" + _currentGold;
    }

    public void PlayCollectCoinSound()
    {
        _collectCoinSound.Play();
    }

    public void PlayDamageSound()
    {
        _damageSound.Play();
    }

    public void PlayJumpSound()
    {
        _jumpSound.Play();
    }
}
