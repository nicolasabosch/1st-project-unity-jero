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

       Debug.Log ("Normal");
       break;

       case int imc when (imc >= 25 && imc <=29.9):

       Debug.Log ("Sobrepeso");
       break;

       case int imc when (imc >= 30 && imc <=34.9):

       Debug.Log ("Obesidad grado 1");
       break;

       case int imc when (imc >= 35 && imc <=39.9):

       Debug.Log ("Obesidad grado 2");
       break;

       case int imc when (imc >= 40):

       Debug.Log ("Obesidad grado 3");
       break;
       }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
