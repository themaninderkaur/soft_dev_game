using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickPlace : MonoBehaviour
{
    /*clickplace.cs main objective is to move the ingredients when pressed on top of one another to 
    allow the user to create the customer orders. clonObj allows new items from each ingredient to 
    be made, while foodValue counts the amount of (total) meals created*/
    public Transform cloneObj;
    public int foodValue;

    private void Start()
    {
        
    }

    private void Update()
    {
        
    }

    /*When the mouse is pressed: on the bottom bun, top bun, cheese, or lettuce icon, then the item is
    cloned from the icon and moved to the position of the plate. The game grabs the data from the foodValue
    to be able to tell if the customer's order was fulfilled.*/
    private void OnMouseDown()
    {
        if(gameObject.name == "bunBottom")
        {
            Instantiate(cloneObj, new Vector2(gameflow.plateXPos, .10f), cloneObj.rotation);
        }

        if(gameObject.name == "bunTop")
        {
            Instantiate(cloneObj, new Vector2(gameflow.plateXPos, .60f), cloneObj.rotation);
        }

        if(gameObject.name == "Cheese")
        {
            Instantiate(cloneObj, new Vector2(gameflow.plateXPos, .62f), cloneObj.rotation);
        }

        if(gameObject.name == "Lettuce")
        {
            Instantiate(cloneObj, new Vector2(gameflow.plateXPos -.1f, .62f), cloneObj.rotation);
            Instantiate(cloneObj, new Vector2(gameflow.plateXPos +.1f, .62f), cloneObj.rotation);
        }

        gameflow.plateValue[gameflow.plateNum] += foodValue;
        Debug.Log(gameflow.plateValue[gameflow.plateNum] + " " + gameflow.orderValue[gameflow.plateNum]);
    }
}
