using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class farmer1 : MonoBehaviour
{
    public GameObject cloud;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            StartCoroutine(showMessage());
        }
    }

    IEnumerator showMessage()
    {
        cloud.SetActive(true);
        yield return new WaitForSeconds(4);
        cloud.SetActive(false);
    }
}
