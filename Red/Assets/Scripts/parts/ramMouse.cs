using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ramMouse : MonoBehaviour
{
    public bool rammouseOver = false;

    private void OnMouseOver()
    {
        rammouseOver = true;
    }

    private void OnMouseExit()
    {
        rammouseOver = false;
    }
}
