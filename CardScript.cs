using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardScript : MonoBehaviour
{
    SpriteRenderer imagen;

    public Sprite front;
    public Sprite back;

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
