using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clamping : MonoBehaviour
{
    
    public float minXPos, maxXPos;
    public float minYPos, maxYPos;
    public float minZPos, maxZPos;
    public bool Xclamp, Yclamp, Zclamp;

    void Start()
    {

    }

    void FixedUpdate()
    {
        if(Xclamp)
        {
            transform.localPosition = new Vector3(Mathf.Clamp(transform.localPosition.x, minXPos, maxXPos), transform.localPosition.y, transform.localPosition.z);
        }
        if(Yclamp)
        {
            transform.localPosition = new Vector3(transform.localPosition.x, Mathf.Clamp(transform.localPosition.y, minYPos, maxYPos), transform.localPosition.z);
        }
        if(Zclamp)
        {
            transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y, Mathf.Clamp(transform.localPosition.z, minZPos, maxZPos));
        }
    }
}
