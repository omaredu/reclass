using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuController : MonoBehaviour
{
    public Animator modeloAnim, skeletonAnim;

    //menuButtons
    public MouseHandler mouse;
    public PlayerMovement player;


    //descripcion
    public GameObject description;
    public menuDescription menuDescription;

    //chosemenu
    public bool computerOn = true;
    public bool skeletonOn = false;
    public GameObject computer, skeleton;

    


    public void Separation()
    {
        modeloAnim.SetTrigger("separate");
        description.SetActive(true);
    }

    public void SeparationSkeleton()
    {
        skeletonAnim.SetTrigger("separate");
    }

    public void ExitSkeletonMode()
    {
        Cursor.lockState = CursorLockMode.Locked;
        mouse.mouseSensitivity = 200f;

        player.skeletonMenuActive = false;
        player.skeletonMenuButtons.SetActive(false);
        player.modeloUi.SetActive(true);

        skeletonAnim.SetTrigger("backToIddle");
        skeletonAnim.SetTrigger("iddle");
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

    public void ExitChooseMode()
    {
        Cursor.lockState = CursorLockMode.Locked;
        mouse.mouseSensitivity = 200f;

        player.chooseMenu.SetActive(false);
        player.modeloUi.SetActive(true);
        player.chooseMenuActive = false;

    }

    public void CreateComputer()
    {
        if(computerOn == false)
        {
            if(skeletonOn == true)
            {
                skeleton.SetActive(false);
            }
            computerOn = true;
            computer.SetActive(true);
            
            skeletonOn = false;
        }
    }

    public void CreateSkeleton()
    {
        if(computerOn == true)
        {
            computer.SetActive(false);
            skeleton.SetActive(true);
            computerOn = false;
            skeletonOn = true;
        }
    }
}
