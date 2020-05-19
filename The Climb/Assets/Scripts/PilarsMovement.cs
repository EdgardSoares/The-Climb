using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PilarsMovement : MonoBehaviour
{

    public float _speed = 3;
    private PlayerController _player;


    // Start is called before the first frame update
    void Start()
    {
        _player = GameObject.Find("player").GetComponent<PlayerController>();
    }

    // Update is called once per frame

    //Script para movimentar as plaformas no eixo Y para cima, caso o jogador estiver vivo
    //Quando as plaformas chegarem na posicao 80 no eixo Y, o objeto sera destruido
    void Update()
    {
        if (_player._isAlive == true)
        {
            Vector3 pos = transform.position;
            pos.y = pos.y + _speed * Time.deltaTime;
            transform.position = pos;

            if (transform.position.y >= 80)
            {
                GameObject.Destroy(gameObject);
            }
        }
            
    }

}
