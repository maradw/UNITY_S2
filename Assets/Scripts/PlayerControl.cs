using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    int playerLife = 10;

    public LayerMask _ground;
    //public bool isGrounded;
    public float _speedX;
    private float _horizontal;
    private float _jump;

    public float _jumpForce;

    Rigidbody2D _compRigidBody;

    public GameManager _gameManagerForLife;

    //public Transform _raycastReference;

    void Awake()
    {
        _compRigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        _horizontal = Input.GetAxisRaw("Horizontal");
        Movement();
       
        // transform.position = new Vector2(transform.position.x + _horizontal * _speedX * Time.deltaTime,0);
        //_jump = Input.GetAxisRaw("Jump");
    }
    void FixedUpdate()
    {
        _compRigidBody.velocity = new Vector2(_horizontal * _speedX, 0);
       
    }
    void Movement()
    {
        Debug.DrawLine(transform.position, transform.position + Vector3.down * 0.5f, Color.magenta);
        if (Physics2D.Raycast(transform.position, Vector2.down, 0.5f, _ground))
        {

            if (Input.GetButton("Jump"))
            {
                //_jump = Input.GetAxisRaw("Jump");
                _compRigidBody.velocity = new Vector2(_jump, _jumpForce);
                // _compRigidBody.velocity = new Vector2(_compRigidBody.velocity.x, _jumpForce);

            }
        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "littleEnemy")
        {
            _gameManagerForLife.CurrentLife(0.5f);
        }
        else if (collision.gameObject.tag == "capsuleEnemy")
        {
            _gameManagerForLife.CurrentLife(0.8f);
        }


    }
}
