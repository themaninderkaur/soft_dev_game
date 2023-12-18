using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menucreate : MonoBehaviour
{

    /*The valaues and objects that will be used in menucreate. The cloneObj will create a duplicate 
    of any menu item, while the foodValue will document how much food will allow new customers*/
    public GameObject cloneObj;
    public int foodValue;

    void Start()
    {
        
    }

    void Update()
    {

    }

    /* When the mouse is pressed, whatever menu item is pressed in added onto the foodValue int. 
    A certian amount for foodValue will allow not only a new customer, but will also allow the 
    customer abject to move into the field of vision in front of the screen*/
    private void OnMouseDown()
    {
        gameflow.createdMenuItem += foodValue;

        // 
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
            Instantiate(cloneObj, new Vector2(0, -8), cloneObj.transform.rotation);
        }else
        {
            Instantiate(cloneObj, new Vector2(0, -12.5f), cloneObj.transform.rotation);
        }
    }

}
