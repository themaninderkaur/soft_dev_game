using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Remove : MonoBehaviour
{
    private void Start()
    {
        
    }

    /*remove the plate's contents if the user wantys to restart on their plate/meal*/
    private void Update()
    {
        if((gameflow.emptyPlateNow > transform.position.x -.4f) && (gameflow.emptyPlateNow < transform.position.x + .4f))
        {
            Destroy(gameObject);
        }
    }

}
