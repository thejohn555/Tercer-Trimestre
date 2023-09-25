using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerUsos : MonoBehaviour
{
    public float vidaJugador;

    public GameObject enemigoTarget;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            vidaJugador -= 1;
        }
        if (vidaJugador<= 0)
        {
            GameManager.dameReferencia.JugadorMuerto();
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            enemigoTarget.GetComponent<Enemigo>().DanoEnemigo();
            
        }
    }
}
