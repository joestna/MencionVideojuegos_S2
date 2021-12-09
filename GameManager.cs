using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private List<GameObject> listaCartas = new List<GameObject>();
    public GameObject cartaPrefab;

    // Start is called before the first frame update
    void Start()
    {
        int numeroDeCartasACrear = 10;
        int x = -10;
        int y = 3;

        for( int i = 0; i < numeroDeCartasACrear; i++ )
        {
            string nombreCarta = "carta";

            GameObject carta = Instantiate(cartaPrefab, new Vector3(x, y, 0), Quaternion.identity);
            carta.name = nombreCarta + (i + 1).ToString();

            listaCartas.Add( carta );

            x += 3;

            if( i == 5-1 )
            {
                x = -10;
                y = - 3;
            }
        }       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
