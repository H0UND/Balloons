using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game : MonoBehaviour
{
    [SerializeField]
    private GameObject _balloonPrefab;

    private int _score;

    [SerializeField]
    private Text _scoreText;

    void Start()
    {
        StartCoroutine(DoCheck());
    }

    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        
    }

    private IEnumerator DoCheck()
    {
        while (true)
        {
            yield return new WaitForSeconds(0.5f);
            Instantiate(_balloonPrefab);
        }
    }

    public void AddScore()
    {
        _score++;
        _scoreText.text = $"{_score}";
    }
}
