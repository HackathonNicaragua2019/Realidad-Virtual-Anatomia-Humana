using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlCursor : MonoBehaviour
{
    public int TamañodelCursor = 32;
    public Texture3D cursorMano, cursorNormal;
    Texture3D cursorActivo;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
        CambiarCursor("normal");
    }
    
    public void CambiarCursor(string tipodecursor)
    {
        if (tipodecursor == "normal")
        {
            cursorActivo = cursorNormal;
        }
        if(tipodecursor == "mano")
        {
            cursorActivo = cursorMano;
        }
    }
    void OnGUI()
    {
        GUI.DrawTexture(new Rect(Input.mousePosition.x, Screen.height - Input.mousePosition.y, TamañodelCursor, TamañodelCursor), cursorActivo);
    }
}