using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;

    public float speed = 8f;

    public bool walk = true;

    public bool once = false;

    public bool sitDown = false;

    //SIT DOWN
    public GameObject sitDownUi, modeloUi;


    void Update()
    {
        if (walk == true)
        {
            float x = Input.GetAxis("Horizontal");
            float z = Input.GetAxis("Vertical");

            Vector3 move = transform.right * x + transform.forward * z;

            controller.Move(move * speed * Time.deltaTime);
        }
    }

    // silla collider
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("silla"))
        {
            sitDownUi.SetActive(true);
        }
        else if (other.CompareTag("modelo"))
        {
            modeloUi.SetActive(true);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKey(KeyCode.E))
        {
            Debug.Log("nice");
            this.transform.parent = other.transform;
            this.transform.position = new Vector3(2.2f, 1.79f, -3.37f);
            walk = false;
            sitDown = true;
            StartCoroutine(sitDownSeconds());
        }
        if (Input.GetKey(KeyCode.Q) && sitDown == true)
        {
            Debug.Log("out");
            this.transform.position = new Vector3(0.58f, 2.81f, -3.07f);
            walk = true;
            sitDown = false;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        sitDownUi.SetActive(false);
    }

    private IEnumerator sitDownSeconds()
    {
        yield return new WaitForSeconds(1f);
        once = true;
    }
}


