using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public CharacterController controller;

    //velocidad
    public float speed = 20f;

    //gravedad  
    public float gravity = -9.81f;

    //Vector3 velocity;


    void Start()
    {
        //ocultar el cursor
        Cursor.lockState = CursorLockMode.Locked;
        
    }


    void Update()
    {
        //movimiento
        float horizontal = Input.GetAxisRaw("Horizontal");
        //float vertical = Input.GetAxisRaw("Vertical");
        Vector3 direction = new Vector3(-1f, gravity, horizontal).normalized;
       
       
        //velocity.y += gravity * Time.deltaTime;
        //controller.Move(velocity * Time.deltaTime);

        if( direction.magnitude >= 0.1f)
        {
            controller.Move(direction * speed * Time.deltaTime);
        }

    }


    private void OnTriggerStay(Collider other)
    {
        
    }
}
