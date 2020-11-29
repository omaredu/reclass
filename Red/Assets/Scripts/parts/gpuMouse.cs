using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gpuMouse : MonoBehaviour
{
    public bool gpuMouseOver = false;

    private void OnMouseEnter()
    {
        gpuMouseOver = true;
    }

    private void OnMouseExit()
    {
        gpuMouseOver = false;
    }
}
