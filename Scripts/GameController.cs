using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject RotatePivot;
    public string mainValue;

    public void getObject(string value){
        GameObject instance = Instantiate(Resources.Load("model/"+value, typeof (GameObject))) as GameObject;
        instance.transform.parent = RotatePivot.transform;
        mainValue = value;
    }
    public void loadInfo(){
        GameObject instance_image = Instantiate(Resources.Load("images/"+mainValue, typeof(GameObject))) as GameObject;
    }
    
    public void loadSound()
    {
        AudioSource sndSource = gameObject.AddComponent<AudioSource>() as AudioSource;
        AudioClip sndClick = Resources.Load<AudioClip>("sounds/" + mainValue);
        sndSource.PlayOneShot(sndClick);
    }
}
