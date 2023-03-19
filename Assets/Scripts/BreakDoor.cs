using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakDoor : MonoBehaviour
{
    public bool isOpen;
    private bool canBreakDoor;
    public Rigidbody rigidBody;

    private void Update()
    {
        if (canBreakDoor)
        {
            DetachDoor();
        }
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            canBreakDoor = true;
            Debug.Log("Player can operate a door.");
        }
    }

    private void OnTriggerExit(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            canBreakDoor = false;
            Debug.Log("Player cannot operate a door.");
        }
    }

    private void DetachDoor()
    {
        if (Input.GetKeyDown("e"))
        {
            rigidBody.constraints = RigidbodyConstraints.None;
        }
    }
}
