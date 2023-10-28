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
        if(gameObject.name == "bunButtom")
        {
        Instantiate(cloneObj, new Vector3(0, .10f), cloneObj.rotation);
        }

        if(gameObject.name == "bunTop")
        {
        Instantiate(cloneObj, new Vector3(0, .60f), cloneObj.rotation);
        }

        if(gameObject.name == "Cheese"){
        Instantiate(cloneObj, new Vector3(0, .62f), cloneObj.rotation);
        }

        if(gameObject.name == "Lettuc")
        {
        Instantiate(cloneObj, new Vector3(-.1f, .62f), cloneObj.rotation);
        Instantiate(cloneObj, new Vector3(.1f, .62f), cloneObj.rotation);
        }

        gameflow.plateValue += foodValue;
        Debug.Log(gameflow.plateValue + " " + gameflow.orderValue);
    }
}
