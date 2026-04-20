using UnityEngine;

public class SnapshotNode 
{

    public int Turn;

    public Vector3 playerPosition;
    public Vector3 playerRotation;
    public int life;
    public int damage;
    public int speed;



    public Vector3 EnemyPosition;
    public Vector3 EnemyRotation;
    public int Life;
    public int Damage;
    public int Speed;


    public SnapshotNode(Player player , int turn)
    {
        Turn = turn;

        playerPosition = player.transform.position;
        playerRotation = player.transform.rotation.eulerAngles;
        life = player.Life;
        damage = player.Damage;
        speed = player.Speed;
    }
    public SnapshotNode(Enemy enemy, int turn)
    {

        Turn = turn;

        EnemyPosition = enemy.transform.position;
        EnemyRotation = enemy.transform.rotation.eulerAngles;
        Life = enemy.Life;
        Damage = enemy.Damage;
        Speed = enemy.Speed;
    }
    
}
