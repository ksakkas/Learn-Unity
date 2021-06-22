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
    float horizontalInput = Input.GetAxis("Horizontal");
    
    //w and s for move up or down
    float verticalInput = Input.GetAxis("Vertical");

    //transform.Translate(new Vector3.left * horizontalInput * _speed * Time.deltaTime);
    //transform.Translate(new Vector3.up * verticalInput * _speed * Time.deltaTime);
    // ==>
    Vecto3 direction = new Vector3(horizontalInput, verticalInput, 0);
    transform.Translate(direction * _speed * Time.deltaTime);
  }

}
