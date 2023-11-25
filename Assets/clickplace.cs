using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickplace : MonoBehaviour
{
    public Transform cloneObj;
    public int foodValue;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        if(gameObject.name == "bunBottom")
        {
            Instantiate(cloneObj, new Vector3(gameflow.plateXPos, .10f), cloneObj.rotation);
        }

        if(gameObject.name == "bunTop")
        {
            Instantiate(cloneObj, new Vector3(gameflow.plateXPos, .60f), cloneObj.rotation);
        }

        if(gameObject.name == "Cheese")
        {
            Instantiate(cloneObj, new Vector3(gameflow.plateXPos, .62f), cloneObj.rotation);
        }

        if(gameObject.name == "Lettuce")
        {
            Instantiate(cloneObj, new Vector3(gameflow.plateXPos -.1f, .62f), cloneObj.rotation);
            Instantiate(cloneObj, new Vector3(gameflow.plateXPos +.1f, .62f), cloneObj.rotation);
        }

        gameflow.plateValue[gameflow.plateNum] += foodValue;
        Debug.Log(gameflow.plateValue[gameflow.plateNum] + " " + gameflow.orderValue[gameflow.plateNum]);
    }
}