using UnityEngine;
using System.Collections;
using System.Collections.Generic;
namespace SpaceRepair {
    public class PlayerCollsion : MonoBehaviour {
        


        private void OnTriggerEnter(Collider coli){
            if(coli.TryGetComponent<IReparable>(out IReparable reparable)){
                reparable.Interact();
            }
        }
        
    }

}