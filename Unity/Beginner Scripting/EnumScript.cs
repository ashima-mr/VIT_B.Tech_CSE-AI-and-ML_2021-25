using UnityEngine;

public class EnumScript : MonoBehaviour 
{
    enum Direction { North, East, South, West };

    void Start() 
    {
        Direction myDirection = Direction.North;
        Direction reversedDirection = ReverseDirection(myDirection);
        
        Debug.Log("Original Direction: " + myDirection);
        Debug.Log("Reversed Direction: " + reversedDirection);
    }
    
    Direction ReverseDirection(Direction dir)
    {
        if (dir == Direction.North)
            dir = Direction.South;
        else if (dir == Direction.South)
            dir = Direction.North;
        else if (dir == Direction.East)
            dir = Direction.West;
        else if (dir == Direction.West)
            dir = Direction.East;

        return dir;     
    }
}

