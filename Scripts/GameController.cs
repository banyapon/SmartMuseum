using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject RotatePivot, main_canvas;
    public string mainValue,newValue;

    public void getObject(string value)
    {
        newValue = value;
        if(newValue != mainValue)
        {

            Debug.Log(mainValue);
            GameObject oldModel;
            oldModel = GameObject.Find(mainValue+ "(Clone)");
            Destroy(oldModel);
        }
        GameObject instance = Instantiate(Resources.Load("model/" + value, typeof(GameObject))) as GameObject;
        instance.transform.parent = RotatePivot.transform;
        mainValue = value;
    }

    public void loadInfo()
    {
        GameObject instance_image = Instantiate(Resources.Load("images/" + mainValue, typeof(GameObject))) as GameObject;
        instance_image.transform.parent = main_canvas.transform;
    }

    public void loadSound()
    {
        AudioSource sndSource = gameObject.AddComponent<AudioSource>() as AudioSource;
        AudioClip sndClick = Resources.Load<AudioClip>("sounds/" + mainValue);
        sndSource.PlayOneShot(sndClick);
    }
}
