using Sirenix.OdinInspector;
using System;
using System.Collections;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int Life;
    public int Damage;
    public int Speed;

    public GameObject AttackEffect;

    public Action OnMove;
    public Action OnAttack;

    void Start()
    {
        
    }

    void Update()
    {
        /*if (Input.GetKey(KeyCode.W))
        {
            this.gameObject.transform.position += new Vector3(this.gameObject.transform.position.x + spd, 0, 0);
            OnMove?.Invoke();
            
        }
        if (Input.GetKey(KeyCode.A))
        {
            this.gameObject.transform.position += new Vector3(0, 0, this.gameObject.transform.position.z - spd);
            OnMove?.Invoke();
           
        }
        if (Input.GetKey(KeyCode.S))
        {

            this.gameObject.transform.position += new Vector3(this.gameObject.transform.position.x - spd, 0, 0);
            OnMove?.Invoke();
           
        }
        if (Input.GetKey(KeyCode.D))
        {
            this.gameObject.transform.position += new Vector3(0, 0, this.gameObject.transform.position.z + spd);
            OnMove?.Invoke();
            
        }*/
    }

    public void Attack()
    {
        OnAttack?.Invoke();
    }
    
    [Button]
    public void Adelante()
    {

        this.gameObject.transform.position = new Vector3(this.gameObject.transform.position.x - Speed, this.gameObject.transform.position.y, this.gameObject.transform.position.z);
        this.gameObject.transform.rotation = Quaternion.Euler(this.gameObject.transform.rotation.eulerAngles.x, 0, this.gameObject.transform.rotation.eulerAngles.z);
  
        OnMove?.Invoke();
    }
    [Button]
    public void Atras()
    {

        this.gameObject.transform.position = new Vector3(this.gameObject.transform.position.x + Speed, this.gameObject.transform.position.y, this.gameObject.transform.position.z);
        this.gameObject.transform.rotation = Quaternion.Euler(this.gameObject.transform.rotation.eulerAngles.x, 180, this.gameObject.transform.rotation.eulerAngles.z);
      

    
        OnMove?.Invoke();
    }
    [Button]
    public void Izquierda()
    {

        this.gameObject.transform.position = new Vector3(this.gameObject.transform.position.x, this.gameObject.transform.position.y, this.gameObject.transform.position.z - Speed);
        this.gameObject.transform.rotation = Quaternion.Euler(this.gameObject.transform.rotation.eulerAngles.x, -90, this.gameObject.transform.rotation.eulerAngles.z);
        OnMove?.Invoke();
    }

    [Button]
    public void Derecha()
    {

        this.gameObject.transform.position = new Vector3(this.gameObject.transform.position.x, this.gameObject.transform.position.y, this.gameObject.transform.position.z + Speed);
        this.gameObject.transform.rotation = Quaternion.Euler(this.gameObject.transform.rotation.eulerAngles.x, 90, this.gameObject.transform.rotation.eulerAngles.z);
 
        OnMove?.Invoke();
    }

}
