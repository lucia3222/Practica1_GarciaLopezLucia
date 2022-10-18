using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private CharacterController controller;
    public float speed = 4f;
    public float gravity = 4f;
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }


    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Debug.Log("x:" + x + "y:" + z);

        Vector3 movement = transform.right * x + transform.forward * z;
        movement *= Time.deltaTime * speed;
        movement += transform.up * -speed * Time.deltaTime;

        controller.Move(movement);
    }
}
