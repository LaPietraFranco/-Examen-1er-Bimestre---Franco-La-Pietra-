using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejerciciosevaluacion : MonoBehaviour
{
    public int unidaddeflota;
    public int cantidadtotaldedias;
    public int cantidaddediasdelluvia;
    // Start is called before the first frame update
    void Start()
    { 
        int cantidaddediassinlluvia = cantidadtotaldedias - cantidaddediasdelluvia;
        int litrocombustible = 130;
        int kilometrosdia = 90;
        int kilometroslluvia = 110;
        int litrosnecesarios = (kilometrosdia / 15) * litrocombustible;
        int litrosnecesarioslluvia = (kilometroslluvia / 15) * litrocombustible;
        int litrostotales = litrosnecesarios + litrosnecesarioslluvia * cantidadtotaldedias;
        
        if (cantidadtotaldedias < 5)
        {
            Debug.Log("la cantidad minima de dias totales debe ser 5");
        }
        else if (cantidaddediasdelluvia > cantidadtotaldedias && cantidaddediasdelluvia < 0)
        {
            Debug.Log("Error, no puede haber mas dias de lluvia que cantidad total de dias o no puede haber cantidad de dias de lluvia negativos");
        }
        else
        {
            Debug.Log("Una flota de" + unidaddeflota + "taxis trabajando durante" + cantidadtotaldedias + "dias implicará un gasto de" + litrostotales + "pesos en concepto de combustible");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
