using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseWindows : MonoBehaviour
{
    public void closeWindow(){
        Destroy(this.gameObject);
    }
}
