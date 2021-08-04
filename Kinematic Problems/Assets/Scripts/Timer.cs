using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    // Start is called before the first frame update
    public Accelerator objectA;
    public Accelerator objectB;
    public static float predictedTime;


    void Start()
    {
        //wowsers
        float h = objectA.transform.position.x - objectB.transform.position.x;
        float a = objectB.acceleration - objectA.acceleration;
        float b = (2 * objectB.initialVelocity) - (2 * objectA.initialVelocity);
        float c = -2 * h;
        predictedTime = (-b + Mathf.Sqrt(b * b - 4 * a * c)) / (2 * a);
        Debug.Log(predictedTime);








        
    }
}
