using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

  void start()
  {
    transform.position = new Vector3(0, 0, 0);
  }
  
  void update()
  {
    transform.Translate(new Vector3(1, 0, 0));
  }

}
