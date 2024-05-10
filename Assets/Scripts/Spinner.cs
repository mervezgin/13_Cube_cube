using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] float yAngle;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, yAngle, 0); 
    }
}
