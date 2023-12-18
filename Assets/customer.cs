using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class customer : MonoBehaviour
{

    /*The customer.cs controls the movement and unlocks the
    customers as the game progresses with achievement. The
    speech buble will show the customer order, the text will be 
    put based on a Y position as the movement of where the customers
    are changes around due to the X.*/
    public GameObject speechBubble;
    public float textYPos;

    /*Before the programs starts, the game creates a customer*/
    private void Start()
    {
        GetComponent<Rigidbody>().velocity = new Vector2(0,0);
        StartCoroutine(StopApproach());
    }

    /*As the game progresses, if the customer's needs are met
    teh customer object is destroyed (disapears from teh gamn=e)*/
    private void Update()
    {
        if((transform.position.x > gameflow.emptyPlateNow -1) && (transform.position.x < gameflow.emptyPlateNow + 1))
        {
            Destroy(gameObject);
        }
    }

    /*After the customer approaches the food truck, the customer stops their approach.
    They will stay there till they dissapear. If the customer is a man (homme), the first order
    within the order array will be produced and the user will have to give that order.
    If the customer is a woman (femme), the order will be a different order value. The
    two customers will order different things. After they approuch, the speech bubble with
    their order will also appear.*/
    IEnumerator StopApproach()
    {
        yield return new WaitForSeconds(6.5f);
        GetComponent<Rigidbody>().velocity = new Vector2(0,0);
        GetComponent<Animator>().Play("idle");

        if(gameObject.name.Contains("ho"))
        {
            GetComponent<Transform>().Angle = new Vector2(0, 120);
            gameflow.orderValue[0] = 11001;
        }
        if(gameObject.name.Contains("fe"))
        {
            gameflow.orderValue[0] = 1100000;
        }

        gameflow.showOrder = -1;
        Debug.Log(gameflow.showOrder);
        _ = Instantiate(speechBubble, new Vector2(x: transform.position.x - 3.5f, y: transform.position.y + textYPos));

    }

    /*Instantiates all the objects: customers and speechbubbles*/
    private object Instantiate(GameObject speechBubble, Vector2 vector2)
    {
        throw new NotImplementedException();
    }

}
