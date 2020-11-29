using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cpuMouse : MonoBehaviour
{
    public bool cpuMouseOver = false;

    private void OnMouseOver()
    {
        cpuMouseOver = true;
    }

    private void OnMouseExit()
    {
        cpuMouseOver = false;
    }
}
