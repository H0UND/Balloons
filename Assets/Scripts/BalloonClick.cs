using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class BalloonClick : MonoBehaviour, IPointerDownHandler
{
    [SerializeField]
    private Game game;

    [SerializeField]
    private ParticleSystem _particleSystem;

    [SerializeField]
    private GameObject _splash;

    private void Start()
    {
        SetColor();

        game = FindObjectOfType<Game>();
    }

    private void SetColor()
    {
        var renderer = gameObject.GetComponent<SpriteRenderer>();
        int r = Random.Range(0, 2);
        int g = Random.Range(0, 2);
        int b = Random.Range(0, 2);

        if (r == 1 && g == 1 && b == 1)
        {
            r = 0;
        }

        if (r == 0 && g == 0 && b == 0)
        {
            r = 1;
        }


        renderer.color = new Color(r, g, b);
    }


    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log(this.gameObject.name + " Was Clicked.");
        game.AddScore();
        _splash = Instantiate(_splash, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}
