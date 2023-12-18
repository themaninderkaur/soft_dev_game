using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cookmove : MonoBehaviour
{
    /*cookmove.cs main objective is to allow the user to cook and 
    be able to move the patty (one of the menu items within the burger) to
    the plate with the rest of the burger items. foodValue starts at 0 
    since the patty is not cooked and not added to the rest of the
    burger yet. The patty is always stillCooking untiol the time is up*/
    private int foodValue = 0;
    private MeshRenderer meatMat;
    private string stillcooking = "y";

    /*before the program begins, the code first starts this part
    which is always void Start. In this void Start, we grab the meatMat
    (the place where the patty is located and put every time), and we 
    start the timer for the patty that's cooking.*/
    void Start()
    {
        meatMat = GetComponent<MeshRenderer>();
        StartCoroutine(cookTimer());
    }

    void Update()
    {
        
    }

    /*When the mouse is pressed: the patty will be moved off the grill, and 
    the value will say that the aptty is no longer cooking, thus the timer stops.*/
    private void OnMouseDown()
    {
        GetComponent<Transform>().position = new Vector2(gameflow.plateXPos, .66f);
        gameflow.plateValue[gameflow.plateNum] += foodValue;
        stillcooking = "n";
    }

    /*The timer will continue as long as the stillCooking is equal to y.
    As it cooks, teh color will slowly start to become more "cooked like"*/
    IEnumerator cookTimer()
    {
        yield return new WaitForSeconds(10);
        foodValue = 1000;
        if(stillcooking == "y")
        {
            meatMat.material.color = new Color(.3f, .3f, .3f);
        }
    }
}
