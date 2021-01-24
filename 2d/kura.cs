using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kura : MonoBehaviour
{
    public float delay_between;
    float x1 = 21;
    float x2 = 32;
    float y1 = 6.6f;
    float y2 = 11;
    float timer;
    public float speed;
    Vector3 EndPosition;

    void Start()
    {

    }


    void Update()
    {
        timer += Time.deltaTime;
        if (timer > delay_between)
        {
            EndPosition = new Vector3(Random.Range(x1, x2), Random.Range(y1, y2), 0);

            StartCoroutine(Move(EndPosition, speed));
            timer = 0;
        }
        if (transform.position.x - EndPosition.x < 0)
        {
            //patrz w prawo
            Vector3 currentScale = transform.localScale;
            currentScale.x = -0.5f;
            transform.localScale = currentScale;
        }
        if (transform.position.x - EndPosition.x > 0)
        {
            Vector3 currentScale = transform.localScale;
            currentScale.x = 0.5f;
            transform.localScale = currentScale;
        }
    }

    IEnumerator Move(Vector3 destination, float speed)
    {

        while (transform.position != destination)
        {
            transform.position = Vector3.MoveTowards(transform.position, destination, speed * Time.deltaTime);
            yield return null;
        }

    }
}
