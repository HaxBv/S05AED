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
        GameManager.instance.player.OnMove += Avanzar;
        GameManager.instance.player.OnAttack += Avanzar;
    }

    private void Avanzar()
    {
        
        if(this == null)
        {
            return;
        }
        Vector3 Dir = Target.transform.position - this.transform.position;

        Dir.Normalize();

        this.gameObject.transform.position += Dir * Speed;




    }

    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            GameManager.instance.player.Life -= Damage;
            Debug.Log("Player Life: " + GameManager.instance.player.Life);
            if (GameManager.instance.player.Life <= 0)
            {
                Debug.Log("Player Died");
            }
        }
        if (collision.gameObject.tag == "Sword")
        {
            Life -= GameManager.instance.player.Damage;
            Debug.Log("Enemy Life: " + Life);

            if (Life <= 0)
            {
                this.gameObject.SetActive(false);
              

                GameManager.instance.player.Damage += 2;
                GameManager.instance.player.Speed += 1;
                
            }
        }
    }
}
