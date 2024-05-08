using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Movement : MonoBehaviour
{
    [SerializeField] private Vector3 rotation;
    [SerializeField]public float rotationSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            rotation = Vector3.down;

        }
        else if (Input.GetKey(KeyCode.D))
        {
            rotation = Vector3.up;

        }

        transform.Rotate(rotation * rotationSpeed * Time.deltaTime);
    }
}
