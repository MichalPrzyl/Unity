using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed;
    Animator anim;
    bool movingRight = true;
    void Start()
    {
        anim = GetComponent<Animator>();
    }


    void Update()
    {
        HandeMovement();
    }

    void HandeMovement()
    {
        float moveX = Input.GetAxis("Horizontal") * speed * 0.001f;
        float moveY = Input.GetAxis("Vertical") * speed * 0.001f;
        Vector3 movement = new Vector3(moveX, moveY, 0);
        transform.position += movement;
        if (movement == Vector3.zero)
        {
            anim.SetBool("isWalking", false);
        }
        else
        {
            anim.SetBool("isWalking", true);
        }
        if (moveX > 0)
        {
            if (!movingRight)
            {
                Vector3 currentScale = transform.localScale;
                currentScale.x *= -1;
                transform.localScale = currentScale;
                movingRight = true;
            }
        }
        if (moveX < 0)
        {
            if (movingRight)
            {
                Vector3 currentScale = transform.localScale;
                currentScale.x *= -1;
                transform.localScale = currentScale;
                movingRight = false;
            }
        }

    }
}
