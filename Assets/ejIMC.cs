using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejIMC : MonoBehaviour
{
 
 public int imc;
 
    void Start()
    {
       switch (imc)
       {

       case int imc when (imc >= 18.5 && imc <=24.9):

       Debug.Log ("");
       break;
       }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
