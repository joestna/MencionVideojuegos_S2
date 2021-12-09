using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardScript : MonoBehaviour
{
    public Sprite front;
    public Sprite back;

    // Start is called before the first frame update
    void Start()
    {

    }
    
    // Click encima de la carta ( el GameObject tiene que tener un BoxColider )
    // Dudas de como funciona, si creamos la funcion y no la estamos asignando ni llamando a nada como puede funcionar?
    private void OnMouseDown()
    {
        Debug.Log("Click en carta " + name);
    }

    // Update is called once per frame
    void Update()
    {
        
    }