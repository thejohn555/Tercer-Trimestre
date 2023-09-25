using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{
    float velocidad;
    // Start is called before the first frame update
    void Start()
    {
        velocidad = 20;
        Destroy(this.gameObject, 2);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(transform.forward * velocidad * Time.deltaTime, Space.World);
    }
}
