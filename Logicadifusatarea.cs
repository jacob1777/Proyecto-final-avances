using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Logicadifusatarea : MonoBehaviour
[new Header("Gráfica para evaluar la Salud")]
    public AnimationCurve muerto;
    public AnimationCurve herido;
    public AnimationCurve sano;
    public AnimationCurve vivo;

    float muetoValue = 0f;
    float heridoValue = 0f;
    float sanoValue = 0f;
    float vivoValue = 0f;


    //Variable temporal, se debe poner en el script del agente
    public int puntosSalud = 100;

    //El metodo evalua los puntos de motivacion del agente
    public void EvaluarSalud()
    {
        muetoValue = muerto.Evaluate(puntosSalud);
        heridoValue = herido.Evaluate(puntosSalud);
        sanoValue = sano.Evaluate(puntosSalud);
        vivoValue = vivo.Evaluate(puntosSalud);

        if(vivoValue > sanoValue)
        {
            Debug.Log("estoy intacto");
        }
	else if(sanoValue > vivoValue 
            && heridoValue < sanoValue)
        {
            Debug.Log("estoy bien");
        }
        else if(muertoValue > heridoMotivadoValue)
        {
            Debug.Log("no estoy bien");
        }
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            EvaluarSalud();
            puntosSalud -= Random.Range(5, 16);
        }
    }

