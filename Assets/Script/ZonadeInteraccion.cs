using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ZonadeInteraccion : MonoBehaviour
{

    public string textoInteractivo;
    public Text textoInformativo;

    public ControlCursor controlCursor;


    // Start is called before the first frame update
    void OnMouseEnter()
    {
        textoInformativo.text = textoInteractivo;
    }

    // Update is called once per frame
    void OnMouseExit()
    {
        textoInformativo.text = "";
    }
}
