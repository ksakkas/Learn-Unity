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
    //delta time = time in second it took to end the last frame
    transform.Translate(new Vector3.right * 5 * Time.deltaTime);
  }

}
