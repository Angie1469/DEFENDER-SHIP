using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorNavesEnemigas : MonoBehaviour
{
    public GameObject naveEnemigaPrefab;
    public float tiempoEntreGeneraciones = 2f;
    public float rangoXMin = -20f; // Nueva variable para el rango X m�nimo
    public float rangoXMax = -5f;  // Nueva variable para el rango X m�ximo
    public float rangoYMin = 12f;  // Nueva variable para el rango Y m�nimo
    public float rangoYMax = 15f;  // Nueva variable para el rango Y m�ximo

    // Start is called before the first frame update
    private void Start()
    {
        InvokeRepeating("GenerarNave", 0f, tiempoEntreGeneraciones);
    }

    // Update is called once per frame
    void GenerarNave()
    {
        float posX = Random.Range(rangoXMin, rangoXMax);
        float posY = Random.Range(rangoYMin, rangoYMax);

        Vector2 posicionGeneracion = new Vector2(posX, posY);
        Instantiate(naveEnemigaPrefab, posicionGeneracion, Quaternion.identity);
    }
}