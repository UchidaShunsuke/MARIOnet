using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Animator anim = null;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        float horizontalKey = Input.GetAxis("Horizontal");

        if (horizontalKey > 0)
        {
            transform.localScale = new Vector3(1, 1, 1);
            anim.SetBool("run", true);
        }
        else if (horizontalKey < 0)
        {
            transform.localScale = new Vector3(-1, 1, 1);
            anim.SetBool("run", true);
        }
        else
        {
            anim.SetBool("run", false);
        }
    }
}