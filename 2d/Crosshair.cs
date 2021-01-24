using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crosshair : MonoBehaviour
{
    public Texture2D crosshairTexture;
    public Vector2 hotSpot;
    public CursorMode cursorMode = CursorMode.Auto;
    void Start()
    {
        hotSpot = new Vector2(crosshairTexture.width / 2, crosshairTexture.height / 2);
        Cursor.SetCursor(crosshairTexture, hotSpot, cursorMode);
    }

}
