using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Remove : MonoBehaviour
{
    private void Start()
    {
        
    }

    private void Update()
    {
        if((gameflow.emptyPlateNow > transform.position.x -.4f) && (gameflow.emptyPlateNow < transform.position.x + .4f))
        {
            Destroy(gameObject);
        }
    }

}
