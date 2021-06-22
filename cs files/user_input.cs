using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

  [SerializeField]
  private float _speed = 3.5f;
  
  void start()
  {
    transform.position = new Vector3(0, 0, 0);
  }
  
  void update()
  {
    //Move with a and d keys 
  
    float horizontalInput = Input.GetAxis("Horizontal");

    transform.Translate(new Vector3.left * horizontalInput * _speed * Time.deltaTime);
  }

}
