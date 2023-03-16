using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    public bool isOpen;

    private void Start()
    {
        //isOpen = false;
    }

    private void Update()
    {
        if (isOpen == true)
        {
            Vector3 newRotation = new Vector3(0, 90, 0);
            transform.eulerAngles = newRotation;
            Debug.Log("Door opens");
        }
        else
        {
            Vector3 newRotation = new Vector3(0, 0, 0);
            transform.eulerAngles = newRotation;
        }
    }
}
