using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerAttack : MonoBehaviour
{
    public float delayAttack;
    float timer;
    public GameObject targetToAttack;
    int i = 0;
    void Start()
    {

    }


    void Update()
    {
        if(Input.GetMouseButtonDown(1))
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
            if(hit.collider != null && hit.collider.CompareTag("Attackable"))
            {
                if(targetToAttack == hit.collider.gameObject)
                {
                    targetToAttack = null;
                }
                else
                {
                targetToAttack = hit.collider.gameObject;
                }
            }
        }


        timer += Time.deltaTime;
        if (timer > delayAttack)
        {
            if (targetToAttack != null)
            {
                StartCoroutine(Attack(targetToAttack));
                timer = 0;
            }
        }
    }

    IEnumerator Attack(GameObject target)
    {
        Debug.Log("ZAATAKOWANO" + i);
        i++;
        yield return 0;
    }
}
