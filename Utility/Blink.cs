using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blink : MonoBehaviour
{
    public GameObject _sprite;
    public GameObject _sprite2;
    public GameObject _sprite3;
    public GameObject _sprite4;

    [SerializeField] private float _blinkTimer = 0f;
    
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        _blinkTimer++;

        if (_blinkTimer >= 20f)
        {
            
            _sprite.SetActive(false);
            _sprite2.SetActive(false);
            _sprite3.SetActive(false);
            _sprite4.SetActive(false);
            
        }
        else
        {
            _sprite.SetActive(true);
            _sprite2.SetActive(true);
            _sprite3.SetActive(true);
            _sprite4.SetActive(true);
        }

        if(_blinkTimer >= 30f)
        {
            _blinkTimer = 0f;
            _sprite.SetActive(true);
            _sprite2.SetActive(true);
            _sprite3.SetActive(true);
            _sprite4.SetActive(true);
        }
    }
}
