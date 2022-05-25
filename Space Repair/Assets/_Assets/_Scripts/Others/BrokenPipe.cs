using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace SpaceRepair{
    public class BrokenPipe : Interactable {
        [SerializeField] private Light pointLight;
        [SerializeField] private bool isReparied;
        [SerializeField] private GameObject fixedPipe,borkenPipe;
        private void Start(){
            StartCoroutine(EffectRoutine());
        }
        private IEnumerator EffectRoutine(){
            if(!isReparied){
                yield return new WaitForSeconds(1f);
                pointLight.gameObject.SetActive(true);
                yield return new WaitForSeconds(1f);
                pointLight.gameObject.SetActive(false);
                yield return StartCoroutine(EffectRoutine());
            }
        }
        public override void Repair(){
            fixedPipe.SetActive(true);
            borkenPipe.SetActive(false);
            isReparied = true;
            StopCoroutine(EffectRoutine());
        }
        
    }
}
