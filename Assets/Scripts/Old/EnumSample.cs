using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnumSample : MonoBehaviour
{
    enum Direction {None, North, East, South, West, Error};
    void Start()
    {
        Direction myDir;
        myDir = Direction.None;

        myDir = ReverseDirection(myDir);
        if (myDir != Direction.Error)
        {
            Debug.Log($"Now direction:{myDir}");
        }
    }

    Direction ReverseDirection(Direction dir)
    {
        // if (dir == Direction.North)
        //     dir = Direction.South;
        // else if (dir == Direction.South)
        //     dir = Direction.North;
        // else if (dir == Direction.East)
        //     dir = Direction.West;
        // else if (dir == Direction.West)
        //     dir = Direction.East;

        switch (dir)
        {
            case Direction.East:
                dir = Direction.West;
                break;
            case Direction.North:
                dir = Direction.South;
                break;
            case Direction.South:
                dir = Direction.North;
                break;
            case Direction.West:
                dir = Direction.East;
                break;
            default:
                Debug.LogError($"알수없는 방향:{dir}");
                dir = Direction.Error;
                break;
        }
        return dir;
    }    
}
