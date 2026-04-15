using Sirenix.OdinInspector;
using UnityEngine;

public class RecursiveClass : MonoBehaviour
{
    void Start()
    {
        CountDown(5);
    }

    public void CountDown(int n)
    {
        if(n<=0)
        {
            Debug.Log("Inicio la partida");
            return;
        }

        Debug.Log(n);
        CountDown(n - 1);
    }
    void Update()
    {
        
    }
    [Button]
    public int Factorial(int n)
    {
        if(n == 1)
            return 1;

        return n * Factorial (n-1); 
    }

    [Button]
    public int Fibonacci(int n)
    {
        if(n == 0)
            return 0;
        if(n == 1)
            return 1;
            
            
        return Fibonacci (n-1) + Fibonacci(n-2);
    }
}
