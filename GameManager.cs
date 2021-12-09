using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// Juego de cartas MEMORY
public class GameManager : MonoBehaviour
{
    public GameObject cartaPrefab;

    private List<GameObject> listaCartas = new List<GameObject>();

    public List<Sprite> listaCartasFrontales = new List<Sprite>();
    public List<int> cartasYaUtilizadas = new List<int>();

    int cartaRepetida;
    int randomFrontal;
    int cartaContada = 0;

    string nombreCarta = "carta";

    void Start()
    {
        int numeroDeCartasACrear = 10;
        int x = -10;
        int y = 3;
        

        for ( int i = 0; i < numeroDeCartasACrear; i++ )
        {

            // Evitar que la carta se repita mas de 1 vez
            // El primer algoritmo era mas sencillo porque el numero alatorio era solo de 0 a 5 teniendo en cuenta que eran 10 cartas
            // Algoritmo mejorado que coge 5 cartas aleatorias de entre una baraja de 10 (numero aleatorio 0 al 9) y las genera dos veces en posiciones aletorias en el tablero
            do
            {
                cartaRepetida = 0;
                randomFrontal = Random.Range(0, 10); //IMPORTANTE el ultimo numero no se cuenta en el rango ( el rango real es 0-9 )
                Debug.Log("Prueba" + randomFrontal);


                for (int j = 0; j < cartasYaUtilizadas.Count; j++)
                {
                    if (randomFrontal == cartasYaUtilizadas[j])
                    {
                        cartaRepetida++;
                    }

                }

            } while (cartaRepetida != 0 && cartaContada < 5 || cartaRepetida != 1 && cartaContada >= 5);

            cartasYaUtilizadas.Add(randomFrontal);


            // Instanciar la carta en el tablero
            GameObject carta = Instantiate(cartaPrefab, new Vector3(x, y, 0), Quaternion.identity);

            CardScript cartaScript = carta.GetComponent<CardScript>();

            cartaScript.front = listaCartasFrontales[randomFrontal];
          
            carta.name = nombreCarta + (i + 1).ToString();

            listaCartas.Add( carta );

            x += 3;

            if( i == 5-1 )
            {
                x = -10;
                y = - 3;
            }

            cartaContada++;
        }       
    }

    void Update()
    {
        
    }
}
