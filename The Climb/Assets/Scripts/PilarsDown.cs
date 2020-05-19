
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PilarsDown : MonoBehaviour
{
    public bool _isFalling = false;
    public float _downSpeed = 0;
    public float _clock = 0f;
    public float _contador = 5f;

    AudioSource _dangerSound;

    GameObject _Platform;


    private void Start()
    {
        _dangerSound = GetComponent<AudioSource>();
    }

    //Ao colidir com um game object com o nome de player, iria setar na variavel _isFalling como verdadeiro, chamando o metodo. e depois de 05 segundos o objeto Plataforma sera destuindo.
    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.name == "player")
        {
            _isFalling = true;
           Destroy(gameObject, 5);
         
        }
            
    }

    void Update()
    {
        //Contador para contar quantos segundos o player pode ficar na plataforma antes de ser destuida.
        _clock += Time.deltaTime;
        if (_clock >= _contador)
        {
            _clock = 0f;
            IsFalling();
            
        }
        
    }

    //Metodo para fazer com que a Plataforma caia no eixo Y
    void IsFalling()
    {
        if (_isFalling)
        {
            _downSpeed += Time.deltaTime / 50; //Velocidade que a plataforma ira cair.
            transform.position = new Vector3(transform.position.x, transform.position.y - _downSpeed, transform.position.z);
        }
    }

    //Trocar a cor da plataforma para que o player consiga saber a hora de pular para prox plataforma
    void ChangeColor()
    {
        if(_clock == 3)
        {
            gameObject.GetComponent<MeshRenderer>().material.SetColor("platforms", Color.yellow);
        }
    }


}
