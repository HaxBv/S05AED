using UnityEngine;
using Sirenix.OdinInspector;
public class CustomDoubleLinkedList : DoubleLinkedList<SnapshotNode>
{
    public Node<SnapshotNode> pointer;



    public void SaveTurn()
    {


        //base.Add(node)
        if(pointer == tail)
        {

            SnapshotNode snapshot = new SnapshotNode(GameManager.instance.player, Count);

            base.Add(snapshot);

            ResetPointer();
        }
        else
        {
            RemoveFromPosition(pointer);
            SnapshotNode snapshot = new SnapshotNode(GameManager.instance.player, Count);

            base.Add(snapshot);

            ResetPointer();
        }

        /*
         Node<T> newNode = new(value);

        //-> Cuando no hay nuingun elemento en la lista
        if (head == null)
        {
            head = newNode;
            tail = newNode;
        }
        else if(head != null )
        {
            tail.SetNext(newNode);
            newNode.SetPrev(tail);
            tail = newNode;
        }
        Count++;
         */
    }

    public void ResetPointer()
    {
        pointer = tail;
    }

    public void MoveBackwards()
    {
        if (pointer.Prev == null)
            return;
        pointer = pointer.Prev;
    }

    public void MoveForward()
    {
        if (pointer.Next == null) return;
        pointer = pointer.Next;
    }


    public void LoadTurn(Player player)
    {
        Debug.Log("Cargando el turno: " + pointer.Value.Turn);

        player.transform.position = pointer.Value.playerPosition;
        player.str = pointer.Value.str;
        player.dtx = pointer.Value.dtx;
        player.spd = pointer.Value.spd;

    }

}
