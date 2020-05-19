using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Winning : MonoBehaviour
{
    PlayerController _player;
    public GameObject _menu;

    private void Start()
    {
        _player = GameObject.Find("player").GetComponent<PlayerController>();
    }
    private void OnTriggerEnter(Collider colll)
    {
        if (colll.gameObject.name == "player")
        {
            _menu.SetActive(true);
            Debug.Log("VOCE VENCEU!!!");
            _player._isAlive = false;

        }
    }
}
