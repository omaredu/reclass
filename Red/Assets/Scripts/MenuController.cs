using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuController : MonoBehaviour
{
    public Animator modeloAnim;
    public void Separation()
    {
        modeloAnim.SetTrigger("separate");
    }

    public void ExitMode()
    {

    }
}
