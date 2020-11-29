using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ssdMouseOver : MonoBehaviour
{
    public bool ssdMouse = false;

    private void OnMouseEnter()
    {
        ssdMouse = true;
    }

    private void OnMouseExit()
    {
        ssdMouse = false;
    }
}
