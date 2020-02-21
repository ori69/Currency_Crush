using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameBoard : MonoBehaviour
{
    public Sprite[] pieces;
    public RectTransform gameBoard;

    [Header("Prefabs")]
    public GameObject TilePiece;

    int amount_of_currency_types = 6; // ilosc roznych currency
    int width = 12; //inicjalizacja wartosci szerokosci planszy
    int height = 12; //inicjalizacja wartosci wysokosci planszy
    Tile[,] Board; //inicjalizacja matrycy elementów
    // Start is called before the first frame update
    void Start()
    {
        InitializeBoard();
        InstantiateBoard();
    }
    void InitializeBoard() 
    {
        Board = new Tile[width, height];
        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {

                Board[x, y] = new Tile(0, new Point(x, y));
                
            }        
        }
    }

    void InstantiateBoard()
    {
        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {

                int currency_type = Board[x, y].currency_type;
                GameObject t = Instantiate(TilePiece, gameBoard);
                RectTransform rect = t.GetComponent<RectTransform>();
                rect.anchoredPosition = new Vector2(-181 + (33 * x), 182 - (33 * y));

            }
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}

[System.Serializable]
public class Tile
{ 
    public int currency_type;//0 - x -> ta wartosc odpowiada za rodzaj currency
    public Point index;
    public Tile(int v, Point i)
    {
        currency_type = v;
        index = i;
    }
}