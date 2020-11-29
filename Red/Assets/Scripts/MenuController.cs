using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuController : MonoBehaviour
{
    public Animator modeloAnim;

    //menuButtons
    public MouseHandler mouse;
    public PlayerMovement player;


    //descripcion
    public GameObject description;
    public menuDescription menuDescription;


    public void Separation()
    {
        modeloAnim.SetTrigger("separate");
        description.SetActive(true);
    }

    public void ExitMode()
    {
        Cursor.lockState = CursorLockMode.Locked;
        mouse.mouseSensitivity = 200f;

        player.menuButtonActive = false;
        player.menuModelButtons.SetActive(false);
        player.modeloUi.SetActive(true);

        description.SetActive(false);

        modeloAnim.SetTrigger("backToIddle");
        modeloAnim.SetTrigger("iddle");

        menuDescription.text.SetActive(true);
        
    }

    public void ExitAplication()
    {
        Application.Quit();
    }

    public void resumeApplication()
    {
        mouse.mouseSensitivity = 200f;
        player.pauseMenu.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        player.isPaused = false;
    }
}
