using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrontFacing : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.LookAt(Camera.main.transform.position, -Vector3.forward);
    }

    // Update is called once per frame
    void Update()
    {
        //transform.LookAt(Camera.main.transform.position, -Vector3.forward);
        //transform.forward = new Vector3(Camera.main.transform.forward.x, transform.forward.y, Camera.main.transform.forward.z);
        transform.rotation = Camera.main.transform.rotation;
    }
}
