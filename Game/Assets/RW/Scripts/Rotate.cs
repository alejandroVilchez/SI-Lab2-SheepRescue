using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    //public float y;
    public Vector3 rotationSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Rotate(0, y*Time.deltaTime,0);
        transform.Rotate(rotationSpeed * Time.deltaTime);

    }
}
