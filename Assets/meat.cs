using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meat : MonoBehaviour
{

    /*Meat.cs is to insatntiate the patty. The cloneObj
    clones the icon of the patty and moves it to the grill.*/
    public Transform cloneObj;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    /*If the icon pressed is the patty cutlet, 
    the object is created on the grill. */
    private void OnMouseDown()
    {
        if(gameObject.name == "Cutlet")
        {
            Instantiate(cloneObj, new Vector2(-3, -.1f), cloneObj.rotation);
        }
    }
}
