using Sirenix.OdinInspector;
using System;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int str;
    public int dtx;
    public int spd;

    public Action OnMove;

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
    [Button]
    public void Adelante()
    {

        this.gameObject.transform.position = new Vector3(this.gameObject.transform.position.x - spd, this.gameObject.transform.position.y, this.gameObject.transform.position.z);
        OnMove?.Invoke();
    }
    [Button]
    public void Atras()
    {

        this.gameObject.transform.position = new Vector3(this.gameObject.transform.position.x + spd, this.gameObject.transform.position.y, this.gameObject.transform.position.z);
        OnMove?.Invoke();
    }
    [Button]
    public void Izquierda()
    {

        this.gameObject.transform.position = new Vector3(this.gameObject.transform.position.x, this.gameObject.transform.position.y, this.gameObject.transform.position.z - spd);
        OnMove?.Invoke();
    }

    [Button]
    public void Derecha()
    {

        this.gameObject.transform.position = new Vector3(this.gameObject.transform.position.x, this.gameObject.transform.position.y, this.gameObject.transform.position.z + spd);
        OnMove?.Invoke();
    }

}
