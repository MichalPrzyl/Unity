using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gamePause : MonoBehaviour
{
    public GameObject panelPause;
    bool GameisPaused = false;
    playerMovement pm;

    private void Start()
    {
        pm = GameObject.Find("player").GetComponent<playerMovement>();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if(GameisPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    void Resume()
    {
        Cursor.lockState = CursorLockMode.Locked;
        panelPause.GetComponent<Animator>().SetTrigger("hide");
        StartCoroutine(PanelDisable());
        GameisPaused = false;
        pm.canMove = true;
    }

    void Pause()
    {
        Cursor.lockState = CursorLockMode.None;
        panelPause.SetActive(true);
        panelPause.GetComponent<Animator>().SetTrigger("show");
        GameisPaused = true;
        pm.canMove = false;
    }

    IEnumerator PanelDisable()
    {
        yield return new WaitForSeconds(0.12f);
        panelPause.SetActive(false);
    }

}
