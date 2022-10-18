using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public PlayerController player;
    public float mouseSense = 10000f;
    private float yRotation = 0f;
    public float ymax=50f;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSense * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSense * Time.deltaTime;
        Debug.Log("Mouse x:" + mouseX + "Mouse y:" + mouseY);
        //y rot
        yRotation -= mouseY;
       
        transform.localRotation = Quaternion.Lerp(transform.localRotation, Quaternion.Euler(yRotation, 0, 0), 1f);
        
        if (yRotation >= ymax)
        {
           transform.transform.localRotation = Quaternion.Lerp(transform.localRotation, Quaternion.Euler(ymax , 0, 0), 1f);
        }
        
       
        
            //x rot
        player.transform.Rotate(Vector3.up * mouseX);
    }
}
