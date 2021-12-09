using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardScript : MonoBehaviour
{
    public Sprite front;
    public Sprite back;

    private bool posicionCarta = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    private void OnMouseDown()
    {
        if( !posicionCarta )
        {
            GetComponent<SpriteRenderer>().sprite = front;
            posicionCarta = true;
        }
        else
        {
            GetComponent<SpriteRenderer>().sprite = back;
            posicionCarta = false;
        }
        
        Debug.Log("Click en carta " + name);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
