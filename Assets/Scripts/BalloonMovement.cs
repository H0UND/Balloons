using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonMovement : MonoBehaviour
{
    [SerializeField]
    private float _speed = 7;

    private Vector2 Position
    {
        get
        {
            return gameObject.transform.localPosition;
        }
        set
        {
            gameObject.transform.localPosition = value;
        }
    }

    void Start()
    {
        _speed = Random.Range(5,10);
        var x = Random.Range(-2f, 2f);
        Position = new Vector2(Position.x + x, Position.y);
    }

    private void FixedUpdate()
    {
        Position = new Vector2(Position.x, Position.y + _speed * Time.deltaTime);
        if (Position.y >= 10f)
        {
            Destroy(gameObject);
        }
    }
}
