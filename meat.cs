using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meat : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        if(gameObject.name == "Cutlet"){
            Instantiate(cloneObj, new Vector3(-3,.1f), cloneObj.rotation);
        }
    }
}
