using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menuDescription : MonoBehaviour
{
    public GameObject cpu, powerSupply, Ram, motherBoard, gpu, ssd, text;

    public cpuMouse cpuMouse;
    public gpuMouse gpuMouse;
    public motherBoardMouse motherBoardMouse;
    public powerSupplyMouse powerSupplyMouse;
    public ramMouse ramMouse;
    public ssdMouseOver ssdMouse;

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(deactivateText());

        if(cpuMouse.cpuMouseOver == true)
        {
            Debug.Log("cpu");
            cpu.SetActive(true);
        }
        else
        {
            cpu.SetActive(false);
        }

        if (gpuMouse.gpuMouseOver == true)
        {
            Debug.Log("gpu");
            gpu.SetActive(true);
        }
        else
        {
            gpu.SetActive(false);
        }

        if (motherBoardMouse.motherBoardMosueOver == true)
        {
            Debug.Log("madre");
            motherBoard.SetActive(true);
        }
        else
        {
            motherBoard.SetActive(false);
        }

        if (powerSupplyMouse.powerSupplyMouseOver == true)
        {
            Debug.Log("power");
            powerSupply.SetActive(true);
        }
        else
        {
            powerSupply.SetActive(false);
        }

        if (ramMouse.rammouseOver == true)
        {
            Debug.Log("ram");
            Ram.SetActive(true);
        }
        else
        {
            Ram.SetActive(false);
        }

        if (ssdMouse.ssdMouse == true)
        {
            Debug.Log("ssd");
            ssd.SetActive(true);
        }
        else
        {
            ssd.SetActive(false);
        }
    }

    IEnumerator deactivateText()
    {
        yield return new WaitForSeconds(1.5f);
        text.SetActive(false);
    }
}
