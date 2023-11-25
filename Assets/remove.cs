using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class remove : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        if((gameflow.emptyPlateNow > transform.position.x -.4f) && (gameflow.emptyPlateNow < transform.position.x + .4f))
        {
            Destroy(gameObject);
        }
    }

}