using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menucreate : MonoBehaviour
{
    public GameObject clobeObj;
    public int foodValue;

    void Start()
    {
        
    }

    void Update()
    {

    }

    private void OnMouseDown()
    {
        gameflow.createdMenuItem += foodValue;

        if(foodValue == 1000)
        {
            Debug.Log("Man unlocked");
            gameflow.customers[0] = 1;
        }
        if(foodValue == 100000)
        {
            gameflow.customers[1] = 1;
        }

        if(gameObject.name != "10000")
        {
            Instantiate(cloneObj, new Vector3(0, -8), cloneObj.transform.rotation);
        }else
        {
            Instantiate(cloneObj, new Vector3(0, -12.5f), cloneObj.transform.rotation);
        }
    }

}