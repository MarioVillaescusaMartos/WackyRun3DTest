using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class InputSystemKeyboard : MonoBehaviour
{ 
    public float hor{ get; private set; } //get sirve para obtener/set para asignar
    public float ver { get; private set; }
    //public bool w { get; private set; }

    public event Action OnFire1 = delegate { }; //Se crea el evento pulico para que hayan clases que se puedan enterar de el (OnFire puede ser cualquier nombre)(delegate: forma de decir que es un evento)
    public event Action OnJump = delegate { };

    private bool pause;
    bool keyPressed;

    // Update is called once per frame
    private void Update()
    {
       /* pause = PauseManager.pauseMode;

        if (!pause)
        {*/
            hor = Input.GetAxis("Horizontal");
            ver = Input.GetAxis("Vertical");
            //w = Input.GetKeyDown(KeyCode.W);

            if (Input.GetKeyDown(KeyCode.W))
            {
                OnJump(); //Cuando se pulsa la tecla "W" el personaje principal salta, y si se le pulsa una segunda vez salta otra vez en el aire
            }
            /*
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                OnPause(); //Cuando se pulsa la tecla "Esc" el juego se pausa
            }*/
        //}
    }

    public bool ReturnKey()
    {
        return keyPressed;
    }
}