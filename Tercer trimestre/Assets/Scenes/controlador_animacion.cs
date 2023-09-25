using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlador_animacion : MonoBehaviour
{
    CharacterController controller;
    Animator animator;
    bool run;
    float movX;
    float movZ;
    Vector3 movimiento;
    int Velocidad;
    float altura;

    // Start is called before the first frame update
    void Start()
    {
        controller = gameObject.GetComponent<CharacterController>();
        animator = gameObject.GetComponent<Animator>();
        run = false;
    }

    // Update is called once per frame
    void Update()
    {
        movX = Input.GetAxis("Vertical");
        movZ = Input.GetAxis("Horizontal");
        animator.SetFloat("InputV", movZ);
        animator.SetFloat("InputH", movX);

        movimiento = new Vector3(movX * Velocidad * Time.deltaTime, altura * Time.deltaTime, movZ * Velocidad * Time.deltaTime);

        transform.Translate(movimiento , Space.World);

    }

}
