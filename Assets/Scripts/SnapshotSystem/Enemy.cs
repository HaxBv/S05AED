using System;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int Life;
    public int Damage;
    public int Speed;


    public GameObject Target;

    void Start()
    {
        GameManager.instance.NewTurn += Avanzar;
    }

    private void Avanzar()
    {
        Vector3 Dir = Target.transform.position - this.transform.position;

        Dir.Normalize();

        this.gameObject.transform.position += Dir * Speed;




    }

    void Update()
    {
        
    }
}
