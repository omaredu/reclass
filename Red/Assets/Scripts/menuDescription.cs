using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menuDescription : MonoBehaviour
{
    public GameObject cpu, powerSupply, Ram, motherBoard, gpu, ssd;

    public cpuMouse cpuMouse;
    public gpuMouse gpuMouse;
    public motherBoardMouse motherBoardMouse;
    public powerSupplyMouse powerSupplyMouse;
    public ramMouse ramMouse;
    public ssdMouseOver ssdMouse;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(cpuMouse.cpuMouseOver == true)
        {
            cpu.SetActive(true);
        }

        if (gpuMouse.gpuMouseOver == true)
        {
            gpu.SetActive(true);
        }

        if (motherBoardMouse.motherBoardMosueOver == true)
        {
            motherBoard.SetActive(true);
        }

        if (powerSupplyMouse.powerSupplyMouseOver == true)
        {
            powerSupply.SetActive(true);
        }

        if (ramMouse.rammouseOver == true)
        {
            Ram.SetActive(true);
        }

        if (ssdMouse.ssdMouse == true)
        {
            ssd.SetActive(true);
        }
    }
}
