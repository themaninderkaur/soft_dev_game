using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class serve : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        if(gameflow.orderValue == gameflow.plateValue){
            Debug.Log("correct");
        }
    }
}