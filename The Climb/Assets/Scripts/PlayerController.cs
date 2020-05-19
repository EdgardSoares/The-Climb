using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    CharacterController _characterController;
    public float _speed;
    public float _jumpSpeed;
    public float _gravity;
    public bool _isAlive = true;
    public int _points;
    public Text _CounterPoints;

    points _pointsCount;

    AudioSource _jumpSound;

    private Vector3 _moveDirection = Vector3.zero;
    // Start is called before the first frame update
    void Start()
    {
        _characterController = GetComponent<CharacterController>();
        _jumpSound = GetComponent<AudioSource>();
                   
        
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        ControllerPlayer();
        _CounterPoints.text = _points.ToString();

    }

    void ControllerPlayer()
    {
        if (_characterController.isGrounded && _isAlive == true)
        {
            _moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));
            _moveDirection *= _speed;
            if (Input.GetButton("Jump"))
            {
                _moveDirection.y = _jumpSpeed;
                _jumpSound.Play();
               
            }

        } 
        
        _moveDirection.y -= _gravity * Time.deltaTime;
        _characterController.Move(_moveDirection * Time.deltaTime);
    }


  
}
