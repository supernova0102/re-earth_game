using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class panelUiControl : MonoBehaviour
{
    public bool turninfoisShowen;
    public GameObject turninfo;
    public float screenHeightHalf; 
    public float screenWidthHalf;
    // Start is called before the first frame update
    void Start()
    {
        turninfoisShowen = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    
    public void turnInfo()
    {
        screenHeightHalf = Camera.main.orthographicSize;
        screenWidthHalf = screenHeightHalf * Camera.main.aspect;
        Vector3 pos = turninfo.transform.localPosition;
        if(turninfoisShowen){
            Debug.Log("turnInfo hide");
            turninfoisShowen = false;
            pos.x=760;
            pos.y=0;
        }
        else{
            Debug.Log("turnInfo show");
            turninfoisShowen = true;
            pos.x=510;
            pos.y=0;
        }
        turninfo.transform.localPosition = pos;
    }
}
