using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace SpaceRepair {
    public enum KeyType{
        Red,Blue,Yellow
    }
    public class Key : Interactable{
        [SerializeField]  private KeyType keyType;

        private void Awake(){
            GetComponent<Rigidbody>().AddForce(transform.up * 0.4f,ForceMode.Impulse);
            GetComponent<Rigidbody>().AddTorque(transform.right * 0.4f,ForceMode.Impulse);
        }
        public override void Interact(){
            gameObject.SetActive(false);
            LevelManager.current.OnKeyFound();
        }
        
    }

}