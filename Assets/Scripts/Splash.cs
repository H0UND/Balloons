using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Splash : MonoBehaviour
{
    [SerializeField]
    private SpriteRenderer _spriteRenderer;

    [SerializeField]
    private Sprite _sprite1;

    [SerializeField]
    private Sprite _sprite2;

    [SerializeField]
    private Sprite _sprite3;

    [SerializeField]
    private Sprite _sprite4;

    [SerializeField]
    private Sprite _sprite5;

    private SpriteType _spriteType;

    void Start()
    {
        _spriteType = (SpriteType)Random.Range(0, 4);

        switch (_spriteType)
        {
            case SpriteType.Pow:
                _spriteRenderer.sprite = _sprite1;
                break;
            case SpriteType.Poof:
                _spriteRenderer.sprite = _sprite2;
                break;
            case SpriteType.Boom:
                _spriteRenderer.sprite = _sprite3;
                break;
            case SpriteType.Wow:
                _spriteRenderer.sprite = _sprite4;
                break;
            case SpriteType.Zap:
                _spriteRenderer.sprite = _sprite5;
                break;
            default:
                break;
        }
    }

    private enum SpriteType
    {
        Pow,
        Poof,
        Boom,
        Wow,
        Zap
    }
}


