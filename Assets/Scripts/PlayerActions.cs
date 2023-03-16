using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerActions : MonoBehaviour
{
    public GameObject door;
    private bool canOperateDoor;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (canOperateDoor)
        {
            OperateDoor();
        }
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Door")
        {
            canOperateDoor = true;
            Debug.Log("Player can operate a door.");
        }
    }

    private void OnTriggerExit(Collider collision)
    {
        if (collision.gameObject.tag == "Door")
        {
            canOperateDoor = false;
            Debug.Log("Player cannot operate a door.");
        }
    }

    private void OperateDoor()
    {

        /*if (Input.GetKeyDown("e"))
        {
            if (door.GetComponent<OpenDoor>().isOpen == false)
            {
                door.GetComponent<OpenDoor>().isOpen = true;
                Debug.Log("Player opens a door.");
            }
            else
            {
                door.GetComponent<OpenDoor>().isOpen = false;
                Debug.Log("Player closes a door.");
            }
        }*/

        if (Input.GetKeyDown("e"))
        {

        }
    }
}
