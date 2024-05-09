using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MoveThePlayer();
    }

    void MoveThePlayer()
    {
        float verticalInput = Input.GetAxis("Vertical");
        float horizontalInput = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.forward * speed * horizontalInput * Time.deltaTime);
        transform.Translate(Vector3.right * speed * verticalInput * Time.deltaTime);

        /*if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.Translate(Vector3.up * speed * Time.deltaTime);
        }
        else if (Input.GetKeyUp(KeyCode.Space))
        {
            transform.Translate(Vector3.down * speed * Time.deltaTime);
        }*/
    }
}
