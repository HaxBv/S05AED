using UnityEngine;

public class SnapshotNode 
{
    public int Turn;

    public Vector3 playerPosition;
    public Vector3 playerRotation;
    public Transform Player;


    public float str;
    public float dtx;
    public float spd;

    public SnapshotNode(Player player, int turn)
    {
        playerPosition = player.transform.position;

        str = player.str;
        dtx = player.dtx;
        spd = player.spd;
        Turn = turn;
    }
}
