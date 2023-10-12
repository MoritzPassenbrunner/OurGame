using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PlayerController : MonoBehaviour
{
    public Player Player { get; set; }

    public abstract void Move();
}

public class Player1Controller : PlayerController
{
    public override void Move()
    {
        throw new System.NotImplementedException();
    }

    public void FixedUpdate() 
    {

    }

}
public class Player2Controller : PlayerController
{
    public override void Move()
    {
        throw new System.NotImplementedException();
    }
}
public enum Move
{
    Up,
    Down,
    Left,
    Right,
}

