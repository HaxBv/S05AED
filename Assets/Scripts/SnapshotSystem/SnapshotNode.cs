using UnityEngine;

public class SnapshotNode 
{

    public int Turn;

    public Vector3 playerPosition;
    public Vector3 playerRotation;
    public int str;
    public int dtx;
    public int spd;



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
        str = player.str;
        dtx = player.dtx;
        spd = player.spd;
    }
    public SnapshotNode(Enemy enemy, int turn)
    {

        Turn = turn;

        playerPosition = enemy.transform.position;
        playerRotation = enemy.transform.rotation.eulerAngles;
        Life = enemy.Life;
        Damage = enemy.Damage;
        Speed = enemy.Speed;
    }
    
}
