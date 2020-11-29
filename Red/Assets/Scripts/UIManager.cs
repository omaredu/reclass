using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Mirror;

public class UIManager : NetworkBehaviour
{
    [SerializeField]
    GameObject interactText;

    [SerializeField]
    GameObject pauseUI;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetInteractTextActive(bool setActive)
    {
        interactText.SetActive(setActive);
    }

    public void SetPauseUI(bool setActive)
    {
        pauseUI.SetActive(setActive);
    }
}
