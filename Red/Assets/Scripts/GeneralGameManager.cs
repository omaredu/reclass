using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneralGameManager : MonoBehaviour
{
    [SerializeField]
    bool isPaused;

    [SerializeField]
    UIManager uim;

    public void ShowInteractivity(bool interactivity)
    {
        uim.SetInteractTextActive(interactivity);
    }
}
