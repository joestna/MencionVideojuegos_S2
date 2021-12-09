using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardScript : MonoBehaviour
{
    SpriteRenderer imagen;

    public Sprite front;
    public Sprite back;
    public string nombre;
    public int valor;

    public GameManager gameManager;

    private bool frontCard = false;

    void Start()
    {
        imagen = GetComponent<SpriteRenderer>();        
    }

    private void OnMouseDown()
    {
        if( !frontCard)
        {
            imagen.sprite = front;
            frontCard = true;
            gameManager.ClickOnCard(nombre, valor);
        }
        else
        {
            imagen.sprite = back;
            frontCard = false;
        }
    }

    void Update()
    {
        
    }
}
