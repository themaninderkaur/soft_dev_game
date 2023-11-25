using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cookmove : MonoBehaviour
{
    private int foodValue = 0;
    private MeshRenderer meatMat;
    private string stillcooking = "y";

    void Start()
    {
        meatMat = GetComponent<MeshRenderer>();
        StartCoroutine(cookTimer());
    }

    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        GetComponent<Transform>().position = new Vector3(gameflow.plateXPos, .66f);
        gameflow.plateValue[gameflow.plateNum] += foodValue;
        stillcooking = "n";
    }

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