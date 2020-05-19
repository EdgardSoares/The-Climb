using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class points : MonoBehaviour
{
    PlayerController _player;

    public Text _PointsText;

    void Start()
    {
        _player = GameObject.Find("player").GetComponent<PlayerController>();
    }

    
   void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "player")
        {
            _player._points += 1;
            Destroy(this.gameObject);
        }
    }
}
