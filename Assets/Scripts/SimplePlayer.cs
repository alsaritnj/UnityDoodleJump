using UnityEngine;

public class SimplePlayer : MonoBehaviour, Interface.Player
{
    public float HorizontalSpeed = 0.1f;

    public void MoveHorizontal(float direction)
    {
        _transform.Translate(new Vector3(direction * HorizontalSpeed, 0, 0));/* <- here in 2 and 3
                                                                              * posithion 0 couse
                                                                              * we dont need move
                                                                              * by vertical axis
                                                                              * this object */
    }
    public void Jump(float jumpForce)
    {
        // i wish to do this method without ridgidbody, bud i'm leisy
        _rigidbody2D.velocity = new Vector2(0, jumpForce);
    }

    void Start()
    {
        _transform = GetComponent<Transform>();
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }


    private Transform _transform;
    private Rigidbody2D _rigidbody2D;
}
