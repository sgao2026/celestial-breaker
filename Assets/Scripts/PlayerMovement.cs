using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D _rigidbody2D;
    private float _xSpeed;
    private float _ySpeed;
    private string _inputX = "Horizontal";
    private string _inputY = "Vertical";

    public float speed = 3;

    private void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();

    }

    private void Update()
    {
        _xSpeed = Input.GetAxis(_inputX);
        _ySpeed = Input.GetAxis(_inputY);

        _rigidbody2D.velocity = new Vector2(_xSpeed, _ySpeed) * speed;
    }
}
