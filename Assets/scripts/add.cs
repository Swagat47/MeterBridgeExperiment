using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class add : MonoBehaviour
{
    public GameObject ball;
    static int i;
    public void addelement()
    {
        Instantiate(ball, new Vector3(i * 2.0F, 0, 0), Quaternion.identity);
        i++;
    }
}
