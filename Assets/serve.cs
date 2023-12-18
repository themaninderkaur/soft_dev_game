using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class serve : MonoBehaviour
{
    public int thisPlate;
    void Start()
    {
        
    }

    void Update()
    {
    
    }

    /*Once user is done with their meal on the plate, the user can press the mouse on
    the serve icon. If the order is the same as the meal, the console log will say
    "correct". Once correct, the plate and meal dissapear along with the customer. */

    /*NOTE: we have yet to make a way to say incorrect and make the user redo the order
    WORK IN PROGRESS*/
    private void OnMouseDown()
    {
        if(gameflow.orderValue[gameflow.plateNum] == gameflow.plateValue[gameflow.plateNum])
        {
            Debug.Log("correct" + " " + gameflow.orderTimer[gameflow.plateNum]);
        }

        gameflow.emptyPlateNow = transform.position.x;
        StartCoroutine(platereset());
    }

    /*The plate goes to normal position without the previous order on it. Whatever the order
    value was is added to the totalCash of the user.*/
    IEnumerator platereset()
    {
        yield return new WaitForSeconds(.2f);
        gameflow.emptyPlateNow = -1;
        gameflow.totalCash += gameflow.orderTimer[thisPlate] * .10f;
    }

}
