using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


public class RocketBehaviour : MonoBehaviour
{
    Vector2 direction;
    Rigidbody2D _shipRB;
    [SerializeField]
    float power;

    bool _pressed = false;
    [SerializeField]
    MyButton _button;
    ParticleSystem _particleSystem;
    // Start is called before the first frame update
    void Start()
    {
        _shipRB = GetComponent<Rigidbody2D>();
          _particleSystem = GetComponentInChildren<ParticleSystem>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
        if(_button._keyHold)
        {
         
            _shipRB.AddForce(-transform.right * power * Time.deltaTime);
            if(!_particleSystem.isPlaying)
            {
                _particleSystem.Play();
            }
        }

    }
    public void launch()
    {
        _pressed = true;
        Debug.Log("Fire");
    }
  
}
