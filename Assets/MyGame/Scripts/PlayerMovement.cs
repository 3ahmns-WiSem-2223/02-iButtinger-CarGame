using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float accelerationF = 5.0f;
    public float turnF = 0.5f;

    float accelerationI = 0;
    float steeringI = 0;

    float roationAngle = 0;

    public Rigidbody2D rigidbody2d;

    private void Update()
    {
        Vector2 inputVector = Vector2.zero;

        inputVector.x = Input.GetAxis("Horizontal");
        inputVector.y = Input.GetAxis("Vertical");

        SetInputVector(inputVector);

        SpeedUp();
    }

    private void FixedUpdate()
    {
        ApplyEngineForce();

        ApplySteeringForce();
    }

    void ApplyEngineForce()
    {
        Vector2 engineForceVec = transform.up * accelerationI * accelerationF;

        rigidbody2d.AddForce(engineForceVec, ForceMode2D.Force);
    }

    void ApplySteeringForce()
    {
        roationAngle -= steeringI * turnF;

        rigidbody2d.MoveRotation(roationAngle);
    }

    public void SetInputVector(Vector2 inputVector)
    {
        steeringI = inputVector.x;
        accelerationI = inputVector.y;
    }

    private void SpeedUp()
    {
        if (Input.GetKeyDown("e"))
        {
            accelerationF = 30f;
            turnF = 5f;
        }

        if (Input.GetKeyUp("e"))
        {
            accelerationF = 5.0f;
            turnF = 0.5f;
        }
    }
}
