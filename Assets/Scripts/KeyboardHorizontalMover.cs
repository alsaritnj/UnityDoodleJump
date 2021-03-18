using UnityEngine;

public class KeyboardHorizontalMover : MonoBehaviour
{
    void Start()
    {
        _horizontalMovable = GetComponent<Interface.HorizontallyMovable>();
    }

    void FixedUpdate()
    {
        _horizontalMovable.MoveHorizontal(Input.GetAxis("Horizontal"));
    }


    private Interface.HorizontallyMovable _horizontalMovable;
}
