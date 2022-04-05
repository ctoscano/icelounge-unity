using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private Transform rb;
    public float speed = 10;
    private float movementX;
    private float movementY;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Transform>(); 
        
    }

    private void OnMove(InputValue movementValue)
    {
        Vector2 movementVector = movementValue.Get<Vector2>();

        movementX = movementVector.x;
        movementY = movementVector.y;
    }

    private void FixedUpdate() {
        gameObject.transform.Translate(0.0f, 0.0f, movementY/10);
        gameObject.transform.Rotate(0.0f,movementX/10,0.0f);

    }
}
