using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuController : MonoBehaviour
{
    public Animator modeloAnim;

    //menuButtons
    public MouseHandler mouse;
    public PlayerMovement player;


    public void Separation()
    {
        modeloAnim.SetTrigger("separate");
    }

    public void ExitMode()
    {
        Cursor.lockState = CursorLockMode.Locked;
        mouse.mouseSensitivity = 200f;
        player.menuButtonActive = false;
        player.menuModelButtons.SetActive(false);
    }
}
