using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPlan : MonoBehaviour
{
    
     float spinSpeed;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            transform.Rotate(Vector3.back *spinSpeed);
        }
    }
}
