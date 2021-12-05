using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragMove : MonoBehaviour
{
    float konumx;
    private void Start()
    {
        konumx = 0f;
    }
    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKey("right"))
        {
            if (konumx < 2.3f)
            {
                konumx = konumx + 0.03f;
                this.transform.position = new Vector3(konumx, transform.position.y, transform.position.z);
                //  transform.position = new Vector3(Mathf.Clamp(transform.position.x,-2,2), transform.position.y, transform.position.z);
            }
        }
        if (Input.GetKey("left"))
        {
            if (konumx > -2.3f)
            {
                konumx = konumx - 0.03f;
                this.transform.position = new Vector3(konumx, transform.position.y, transform.position.z);
                //  transform.position = new Vector3(Mathf.Clamp(transform.position.x,-2,2), transform.position.y, transform.position.z);
            }
        }
    }
}
