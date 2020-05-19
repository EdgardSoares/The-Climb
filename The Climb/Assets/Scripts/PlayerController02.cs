using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController02 : MonoBehaviour
{
    public Rigidbody _rb;
    public float _speed;
    public float _jumpSpeed;
    public float _gravity;
    private float __moveHorizontal;
    private float _moveVertical;
    Vector3 _movement;
    CharacterController _char;

    public GameObject _player;



    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
        _char = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMove();
    }

    void PlayerMove()
    {
            _movement = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));
            _rb.AddForce(_movement * _speed);
        if (Input.GetButton("Jump"))
            _movement.y = _jumpSpeed;

       
    }
}
