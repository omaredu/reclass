using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerSupplyMouse : MonoBehaviour
{
    public bool powerSupplyMouseOver = false;

    private void OnMouseOver()
    {
        powerSupplyMouseOver = true;
    }

    private void OnMouseExit()
    {
        powerSupplyMouseOver = false;
    }
}
