//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class MonoSingleton : MonoBehaviour
{
    // Start is called before the first frame update
    private static MonoSingleton instance;
     private void Awake() {
         if(instance = null)
         {
             instance = this;
         }
         else
         {
             Destroy(this);
         }
        
    }
}
