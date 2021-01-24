using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public float speed;
    
    Vector3 newPos;
    bool canMove = true;
    void Start()
    {
        
    }

    
    void Update()
    {
       
        if(Input.GetKey(KeyCode.D) && canMove)
        {
            newPos = new Vector3(transform.position.x + 1, transform.position.y, 0);
            StartCoroutine(Move(newPos, speed));

        }


        if (Input.GetKey(KeyCode.A) && canMove)
        {
            newPos = new Vector3(transform.position.x - 1, transform.position.y, 0);
            StartCoroutine(Move(newPos, speed));
        }
        if (Input.GetKey(KeyCode.W) && canMove)
        {
            newPos = new Vector3(transform.position.x, transform.position.y + 1, 0);
            StartCoroutine(Move(newPos, speed));
        }
        if (Input.GetKey(KeyCode.S) && canMove)
        {
            newPos = new Vector3(transform.position.x, transform.position.y - 1, 0);
            StartCoroutine(Move(newPos, speed));
        }
    }

    IEnumerator Move(Vector3 destination, float speed)
    {
        canMove = false;
        while(transform.position != destination)
        {
            transform.position = Vector3.MoveTowards(transform.position, destination, speed * Time.deltaTime);
            yield return 0;
        }
        canMove = true;
    }

  
}
