using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float rotationSpeed = 5f;
    public Transform turret;
    public Transform Gun;

    public GameObject Bullet;
    private Vector2 movementInput;
    private Vector2 rotationInput;

    private void Start()
    {
       var playerInput = GetComponent<PlayerInput>(); 
    }

    // Update is called once per frame
    void Update()
    {
        //move
        var direction = new Vector3(movementInput.x, 0, movementInput.y);
        transform.position += direction * (moveSpeed * Time.deltaTime);

        //rotate turret
        float rotation = rotationInput.x * rotationSpeed * Time.deltaTime;
        turret.Rotate(Vector3.up, rotation);

    }

   

    public void OnMove(InputAction.CallbackContext value)
    {
        movementInput = value.ReadValue<Vector2>();
    }

     public void OnLook(InputAction.CallbackContext value)
    {
       rotationInput = value.ReadValue<Vector2>();
    }

    public void Onshoot(InputAction.CallbackContext value)
    {
        Instantiate(Bullet, Gun.position, turret.rotation);
    }
}
//