using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class customer : MonoBehaviour
{
    public GameObject speechBubble;
    public float textYPos;
    private void Start()
    {
        GetComponent<Rigidbody>().velocity = new Vector3(0,0);
        StartCoroutine(StopApproach());
    }

    private void Update()
    {
        if((transform.position.x > gameflow.emptyPlateNow -1) && (transform.position.x < gameflow.emptyPlateNow + 1))
        {
            Destroy(gameObject);
        }
    }

    IEnumerator StopApproach()
    {
        yield return new WaitForSeconds(6.5f);
        GetComponent<Rigidbody>().velocity = new Vector3(0,0);
        GetComponent<Animator>().Play("idle");

        if(gameObject.name.Contains("ho"))
        {
            GetComponent<Transform>().eulerAngles = new Vector3(0, 120);
            gameflow.orderValue[0] = 11001;
        }
        if(gameObject.name.Contains("fe"))
        {
            gameflow.orderValue[0] = 1100000;
        }

        gameflow.showOrder = -1;
        Debug.Log(gameflow.showOrder);
        _ = Instantiate(speechBubble, new Vector3(x: transform.position.x - 3.5f, y: transform.position.y + textYPos));

    }

    private object Instantiate(GameObject speechBubble, Vector3 vector3)
    {
        throw new NotImplementedException();
    }

}
