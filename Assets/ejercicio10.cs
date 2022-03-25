using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicio10 : MonoBehaviour
{
    public const int HoraApertura=10;
    public const int HoraCierre=18;
    public int horaActual;
    public bool estaAbierto;
    void Start()
    {
        if (horaActual <0 || horaActual > 24) 
        {
            Debug.Log ("Ingrese una hora correcta");
        }

        else if (horaActual >= HoraApertura && horaActual < HoraCierre)
        {
            estaAbierto =true;
            Debug.Log ("Estacionamiento abierto " + horaActual);
        } 

        else 
        {
            estaAbierto=false;
            Debug.Log ("Estacionamiento abierto: " + estaAbierto);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
