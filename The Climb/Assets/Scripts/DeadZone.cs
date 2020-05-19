using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadZone : MonoBehaviour
{

    PlayerController _player;
    public GameObject _menu;

    AudioSource _deadSound;
    AudioSource _soundtrack;


    private void Start()
    {
        _player = GameObject.Find("player").GetComponent<PlayerController>();
        _deadSound = GetComponents<AudioSource>()[0];
        _soundtrack = GetComponents<AudioSource>()[1];
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "player")
        {
            _player._isAlive = false;
            _menu.SetActive(true);
            _deadSound.Play();
            _soundtrack.Stop();


          
        }
    }
}
