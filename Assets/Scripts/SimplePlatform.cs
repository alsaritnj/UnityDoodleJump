using Interface;
using UnityEngine;

public class SimplePlatform : MonoBehaviour, Platform
{
    public float JumpBoostForce = 10;

    void Platform.ActionWithPlayer(Interface.Player player)
    {
        player.Jump(JumpBoostForce);
    }
}

