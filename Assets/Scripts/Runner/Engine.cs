using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Engine : MonoBehaviour
{
    [SerializeField]
    private float speed;


    private InputSystemKeyboard _inputSystem;
    private Rigidbody _rb;

    private void Awake()
    {
        _inputSystem = GetComponent<InputSystemKeyboard>();
        _rb = GetComponent<Rigidbody>();
    }


    // Update is called once per frame
    void Update()
    {
        _rb.velocity = new Vector3(_inputSystem.hor * speed, 0, 0);
    }
}