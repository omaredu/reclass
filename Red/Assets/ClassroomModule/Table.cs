using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Table : MonoBehaviour
{
    GeneralGameManager gm;

    private void Start()
    {
        gm = GameObject.Find("General GameManager").GetComponent<GeneralGameManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            gm.ShowInteractivity(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            gm.ShowInteractivity(false);
        }
    }
}
