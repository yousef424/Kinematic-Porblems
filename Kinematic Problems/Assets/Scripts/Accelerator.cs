using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Accelerator : MonoBehaviour
{
    //what we are doing here is moving the object using maths, which we will be using to calculate the time needed for an object to catch up to the other.
    // Start is called before the first frame update

    public float initialVelocity;
    public float acceleration;
    float currentVelocity;

    void Start()
    {
        currentVelocity = initialVelocity;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Time.fixedTime < Timer.predictedTime)
        {
            currentVelocity += acceleration * Time.fixedDeltaTime;
            transform.Translate(Vector3.right * currentVelocity * Time.fixedDeltaTime);
        }
    }
}
