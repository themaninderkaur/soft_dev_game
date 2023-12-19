using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class menuflow : MonoBehaviour
{
    /*Work in prgress - Supposed to flow the menu and control it.*/

    public static string[] menuMealValue = {"",""};
    public TextMeshPro []mealNameText;
    
    void Start()
    {
        
    }

    void Update()
    {
        mealNameText[0].text = menuMealValue[0];
    }

}
