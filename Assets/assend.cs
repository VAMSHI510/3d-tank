//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class assend : MonoBehaviour
{
    // Start is called before the first frame update
  int [] a = new int[4] {4,8,9,2};
  int [] b = new int[4] {0, 1,5,3};
  int [] c = new int[4] {6,0,1,4};
  private void Start() {
  //if(a[4] > b[4])
  //{
      for(int i =0;i<4;i++)
      {
          int temp;
          temp=a[i];
          a[i]=b[i];
          a[i]=temp;

      //Debug.Log(a[i]);
        Debug.Log(b[i]);
      
     /* for(int j=0;j<4;j++)
      {
          Debug.Log(b[j]);
      }*/
 // }
 /*if(b[i]>c[i])
  {
      Debug.Log(b[i]);
  }
  if(c[i]>a[i])
  {
      Debug.Log(c[i]);
  }*/
  /*switch(i)
  {
      case 1:
          if(b[i]>c[i])
          Debug.Log(b[i]);
          //goto(i);
          break;
      case 2:
          if(c[i]>a[i])
          Debug.Log(c[i]);
          break;
  }*/
 }
}
}

