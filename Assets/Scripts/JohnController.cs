using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JohnController : MonoBehaviour
{
    [SerializeField] private float _rotateAmount;
    [SerializeField] private Rigidbody2D _rigidbody2D;
    [SerializeField] private SurfaceEffector2D _surfaceEffector2D;
    [SerializeField] private float _normalSpeed;
    [SerializeField] private float _boostSpeed;
    
    void Update()
    {
        Rotate();
        ChangeSpeed();
    }

    private void ChangeSpeed()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            _surfaceEffector2D.speed = _boostSpeed;
        }
        else
        {
            _surfaceEffector2D.speed = _normalSpeed;
        }
    }

    private void Rotate()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            _rigidbody2D.AddTorque(_rotateAmount);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            _rigidbody2D.AddTorque(-_rotateAmount);
        }
    }
}
