using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    public bool isOpen;
    private bool canUseDoor;

    private void Update()
    {
        if (canUseDoor)
        {
            UseDoor();
        }
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            canUseDoor = true;
            Debug.Log("Player can use a door.");
        }
    }

    private void OnTriggerExit(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            canUseDoor = false;
            Debug.Log("Player cannot use a door.");
        }
    }

    private void UseDoor()
    {
        if (Input.GetKeyDown("e"))
        {
            if (isOpen == false)
            {
                Vector3 newRotation = new Vector3(0, 90, 0);
                transform.eulerAngles = newRotation;
                isOpen = true;
                Debug.Log("Player opens a door.");
            }
            else
            {
                Vector3 newRotation = new Vector3(0, 0, 0);
                transform.eulerAngles = newRotation;
                isOpen = false;
                Debug.Log("Player closes a door.");
            }
        }
    }
}
