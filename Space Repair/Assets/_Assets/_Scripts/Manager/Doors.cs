using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace SpaceRepair {
    public class Doors : MonoBehaviour {
        
        
        private Animator animtor;
        private void Awake(){
            animtor = GetComponent<Animator>();
        }
        private void OnTriggerEnter(Collider coli){
            if(coli.TryGetComponent<PlayerController>(out PlayerController playerController)){
                ToggleDoors(true);
            }
        }
        public void ToggleDoors(bool value){
            animtor.SetBool("character_nearby",value);
        }
    }
}
