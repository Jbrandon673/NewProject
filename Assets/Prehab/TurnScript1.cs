using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnScript1 : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    GameObject gameBoard;
    public Sprite[] images;
    bool unplayed = true;

    private void Start()
    {
        spriteRenderer.sprite = null;
    }

    private void OnMouseDown()
    {
        if (unplayed)
        {
            int index = gameBoard.GetComponent<GameScript>().PlayerTurn();
            spriteRenderer.sprite = images[index];
            unplayed = false;
        }
    }


    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        gameBoard = GameObject.Find("GameBoard");
    }
}

internal class GameScript
{
    internal int PlayerTurn()
    {
        throw new NotImplementedException();
    }
}