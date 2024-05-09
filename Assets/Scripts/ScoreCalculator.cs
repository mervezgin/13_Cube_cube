using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreCalculator : MonoBehaviour
{
    int hits = 0;

    void OnCollisionEnter(Collision collision)
    {
        if (!collision.gameObject.CompareTag("Ground") && !collision.gameObject.CompareTag("Hit"))
        {
            hits += 1;
            Debug.Log("You've bumped into a thing many times: " + hits);
        }
    }
}
