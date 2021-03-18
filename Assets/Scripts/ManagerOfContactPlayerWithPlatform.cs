using UnityEngine;

public class ManagerOfContactPlayerWithPlatform : MonoBehaviour
{
    void Start()
    {
        _player = GetComponent<Interface.Player>();
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        _platform = other.GetComponent<Interface.Platform>();
        if (_platform != null)
            _platform.ActionWithPlayer(_player);
        
    }

    private Interface.Player _player;
    private Interface.Platform _platform;
}
