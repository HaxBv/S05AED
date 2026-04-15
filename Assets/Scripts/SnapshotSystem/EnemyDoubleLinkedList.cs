using UnityEngine;

public class EnemyDoubleLinkedList : DoubleLinkedList<SnapshotNode>
{
    public Node<SnapshotNode> pointer;

    public void SaveTurn()
    {
        //base.Add(value);

        if (pointer == tail)
        {
            SnapshotNode snapshot = new SnapshotNode(GameManager.instance.enemy, Count);
            base.Add(snapshot);
            ResetPointer();
        }
        else
        {
            RemoveFromPosition(pointer);
            SnapshotNode snapshot = new SnapshotNode(GameManager.instance.enemy, Count);
            base.Add(snapshot);
            ResetPointer();
        }


    }

    public void ResetPointer()
    {
        pointer = tail;
    }


    public void MoveBackwards()
    {
        if (pointer.Prev == null) return;

        pointer = pointer.Prev;
    }
    public void MoveForward()
    {
        if (pointer.Next == null) return;

        pointer = pointer.Next;
    }

    public void LoadTurn(Enemy enemy)
    {
        Debug.Log("Cargando el turno: " + pointer.Value.Turn);
        enemy.transform.position = pointer.Value.playerPosition;
        enemy.transform.eulerAngles = pointer.Value.playerRotation;
        enemy.Life = pointer.Value.Life;
        enemy.Damage = pointer.Value.Damage;
        enemy.Speed = pointer.Value.Speed;

    }

}
