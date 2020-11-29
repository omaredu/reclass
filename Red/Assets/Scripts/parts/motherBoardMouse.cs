using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class motherBoardMouse : MonoBehaviour
{
    public bool motherBoardMosueOver = false;

    private void OnMouseEnter()
    {
        motherBoardMosueOver = true;
    }

    private void OnMouseExit()
    {
        motherBoardMosueOver = false;
    }
}
