using UnityEngine;

public class CradleTrigger : MonoBehaviour{
    private void OnTriggerEnter(Collider other){
        
        if(other.tag == "craddleBall"){
            GameEvents.current.SetCradleActive();
        }
    }

    private void OnTriggerExit(Collider other){

        if (other.tag == "craddleBall"){
            GameEvents.current.SetCradleDeactive();
        }
    }
}
