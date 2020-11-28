using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;

    public float speed = 8f;



    // menuModel
    public GameObject menuModelButtons;
    public bool menuButtonActive = false;

    //SIT DOWN
    public GameObject sitDownUi, modeloUi;

    public bool walk = true;
    public bool once = false;
    public bool sitDown = false;



    void Update()
    {
        if (walk == true && menuButtonActive == false)
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

        if (other.CompareTag("silla"))
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
        else if (other.CompareTag("modelo"))
        {
            if (Input.GetKey(KeyCode.E))
            {
                menuModelButtons.SetActive(true);
                menuButtonActive = true;
                if(menuButtonActive == true)
                {
                    modeloUi.SetActive(false);
                    Cursor.lockState = CursorLockMode.None;
                }
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("silla"))
        {
            sitDownUi.SetActive(false);
        }
        else if (other.CompareTag("modelo"))
        {
            modeloUi.SetActive(false);
        }
    }

    private IEnumerator sitDownSeconds()
    {
        yield return new WaitForSeconds(1f);
        once = true;
    }
}


