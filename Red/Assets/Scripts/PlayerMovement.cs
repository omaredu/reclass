using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;

    public float speed = 8f;

    //SIT DOWN
    public GameObject sitDownUi;

    public GameObject silla;

    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);
    }

    // silla collider
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("silla"))
        {
            sitDownUi.SetActive(true);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKey(KeyCode.E))
        {
            Debug.Log("nice");
            this.transform.parent = other.transform;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        sitDownUi.SetActive(false);
    }
}
