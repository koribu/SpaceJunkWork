using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyButton : MonoBehaviour
{
   // public bool _keyDown = false;
    public bool _keyHold = false;
    public bool _release = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(_release)
            _release = false;
        if(Input.GetMouseButton(0))
        {
            if(Vector2.Distance(transform.position,  Camera.main.ScreenToWorldPoint(Input.mousePosition)) <=  transform.localScale.x/2)
            {
                
               // bool _keyDown = true;
                 _keyHold = true;
                 _release = false;
            }
            else
            {
              //  bool _keyDown = false;
                 _keyHold = false;
                 _release = false;
            }
        }
        else if(_keyHold)
        {
             _keyHold = false;
             _release = true;
        }
        

            
    }
}
