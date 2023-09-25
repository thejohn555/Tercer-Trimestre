using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animacion : MonoBehaviour
{
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("1"))
        {
            animator.Play("WAIT01", 0, 0f);
        }
        if (Input.GetKeyDown("2"))
        {
            animator.Play("WAIT02", 0, 0.5f);
        }
        if (Input.GetKeyDown("3"))
        {
            animator.SetTrigger("WAIT03");
        }
        if (Input.GetKeyDown("4"))
        {
            animator.SetBool("Lose", true);
        }
        if (Input.GetKeyUp("4"))
        {
            animator.SetBool("Lose",false);
        }
    }
}
