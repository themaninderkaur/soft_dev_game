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
        StartCoroutine(cookTime());
    }

    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        GetComponent<Transform>().position = new Vector3(0, .66f);
        gameflow.plateValue += foodValue;
        stillcooking = "n";
    }

    IEnumerator cookTimer()
    {
        yield return new WaitForSeconds(10);
        foodValue = 1000;
        if(stillcooking == "y"){
            meatMat.material.colar = new Color(.3f, .3f, .3f);
        }
    }
}