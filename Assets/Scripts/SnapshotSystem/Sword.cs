using System;
using UnityEngine;

public class Sword : MonoBehaviour
{
    public Animator Animator;
    public Player player;
    void Start()
    {
        player.OnAttack += SetAttackAnimation;

    }

    private void SetAttackAnimation()
    {
        Animator.SetTrigger("Attack");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
