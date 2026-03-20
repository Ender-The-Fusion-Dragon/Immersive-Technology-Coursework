using System;
using UnityEngine;

public class GameEvents : MonoBehaviour{

    public static GameEvents current;

    private void Awake(){
        current = this;
    }

    public event Action eventCradleActive;
    public event Action eventCradleDeactive;

    public void SetCradleActive(){
        Debug.Log("Event function called");
        if (eventCradleActive != null){
            eventCradleActive();
            Debug.Log("craddle active event");
        }
    }

    public void SetCradleDeactive()
    {
        if (eventCradleDeactive != null){
            eventCradleDeactive();
        }
    }
}
