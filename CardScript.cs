using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardScript : MonoBehaviour
{
    public Sprite back;

    // Start is called before the first frame update
    void Start()
    {
        GameObject objetoCarta = new GameObject();

        GetComponent<SpriteRenderer>().sprite = back;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
