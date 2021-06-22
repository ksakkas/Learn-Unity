using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
  //public float speed = 3.5f;
  
  //for see private variable in unity
  [SerializeField]
  
  //private variable = _ for easy
  private float _speed = 3.5f;
  
  void start()
  {
    transform.position = new Vector3(0, 0, 0);
  }
  
  void update()
  {
    transform.Translate(new Vector3.left * _speed * Time.deltaTime);
  }

}
