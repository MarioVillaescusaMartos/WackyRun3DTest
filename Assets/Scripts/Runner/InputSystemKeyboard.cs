using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class InputSystemKeyboard : MonoBehaviour
{ 
    public float hor{ get; private set; } //get sirve para obtener/set para asignar
    public float ver { get; private set; }

    public event Action OnPause = delegate { };


    private bool pause;

    // Update is called once per frame
    private void Update()
    {
        //pause = PauseManager.pauseMode;

        if (!pause)
        {
            hor = Input.GetAxis("Horizontal");
            ver = Input.GetAxis("Vertical");

            if (Input.GetKeyDown(KeyCode.Escape))
            {
                OnPause(); //Cuando se pulsa la tecla "Esc" el juego se pausa
            }
        }
    }

}