using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class earthSpinner : MonoBehaviour
{
    public float degPerSec;
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up*Time.deltaTime*degPerSec);
    }
}
