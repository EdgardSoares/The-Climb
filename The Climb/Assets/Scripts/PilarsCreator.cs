using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PilarsCreator : MonoBehaviour
{

    public GameObject _pipeBase;
    public float _timeToCreate = 3f;
    public float _clock = 0f;
    PlayerController _player;
    public float _range = 2;
    // Start is called before the first frame update
    void Start()
    {
        _player = GameObject.Find("player").GetComponent<PlayerController>();
    }

    // Update is called once per frame

    // Sera criado em posicoes random as plaformas que irao subir, caso o jogador estiver vivo.

    void Update()
    {
        if (_player._isAlive == true)
        {
            _clock += Time.deltaTime;
            if(_clock >= _timeToCreate)
            {
                _clock = 0;

                Vector3 pos = transform.position;
                pos.x = pos.x + Random.Range(-_range, _range);
                pos.z = pos.z + Random.Range(-_range, _range);
                GameObject.Instantiate(_pipeBase, pos, Quaternion.identity);
            }
        }

        
    }
}
