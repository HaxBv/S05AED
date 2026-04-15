using System;
using UnityEngine;
using Sirenix.OdinInspector;
using System.Collections.Generic;


public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public UIManager uiManager;




    public CustomDoubleLinkedList snapshotSystem = new();
    public EnemyDoubleLinkedList enemySystem = new();



    public Player player;
    public Enemy enemy;

    public Action NewTurn;

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        player.OnMove += SaveTurn;
    }
    [Button]
    public void SaveTurn()
    {
        snapshotSystem.SaveTurn();
        enemySystem.SaveTurn();
        Debug.Log("Turno Salvado:" + snapshotSystem.pointer.Value.Turn);


    }
    public void LoadTurn()
    {
        snapshotSystem.LoadTurn(player);
        enemySystem.LoadTurn(enemy);
      
    }
    [Button]
    public void NextTurn()
    {
        snapshotSystem.MoveForward();
        enemySystem.MoveForward();
        LoadTurn();
    }
    [Button]
    public void PrevTurn()
    {
        snapshotSystem.MoveBackwards();
        enemySystem.MoveBackwards();
        LoadTurn();
    }

  

}