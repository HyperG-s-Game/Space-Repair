using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace SpaceRepair {
    public class PlayerController : MonoBehaviour {
        [SerializeField] private float moveSpeed,rotationSpeed;
        [SerializeField] private bool rotateLeft;

        [SerializeField] private ParticleSystem thursterEffect;
        private Rigidbody rb;
        private bool startThurster;
        private void Awake(){
            rb = GetComponent<Rigidbody>();
        }
        private void Update(){
            if(Input.GetMouseButtonDown(0)){
                thursterEffect.Play();
            }
            else if(Input.GetMouseButton(0)){
                // thursterEffect.Play();
                startThurster = true;
            }
            else if(Input.GetMouseButtonUp(0)){
                thursterEffect.Stop();
                rotateLeft = !rotateLeft;
                startThurster = false;
            }
            
        }
        private void FixedUpdate(){
            
            if(startThurster){
                rb.AddForce(transform.up * moveSpeed,ForceMode.Impulse);
                
            }else{
                if(rotateLeft){
                    rb.AddTorque(transform.right * -rotationSpeed,ForceMode.VelocityChange);

                }else{
                    rb.AddTorque(transform.right * rotationSpeed,ForceMode.VelocityChange);
                }
            }
        }
        
    }

}