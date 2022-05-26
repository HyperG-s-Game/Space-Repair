using UnityEngine;
using UnityEngine.Events;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

namespace SpaceRepair {
    public class MasterController : MonoBehaviour {
        
        [Header("Events")]
        [SerializeField] private UnityEvent onGameStart;
        [SerializeField] private UnityEvent onGamePlaying,onGameEnd,onPlayerWon,onPlayerLost;



        [SerializeField] private bool isGamePlaying,isPlayerWon;


        private void Start(){
            isGamePlaying = false;
            StartCoroutine(StartGameRoutine());
        }
        private IEnumerator StartGameRoutine(){
            onGameStart?.Invoke();
            while(!isGamePlaying){
                yield return null;
            }
            yield return StartCoroutine(GamePlayingRoutien());
        }
        private IEnumerator GamePlayingRoutien(){
            onGamePlaying?.Invoke();
            while(isGamePlaying){
                yield return null;
            }
            onGameEnd?.Invoke();
            if(isPlayerWon){
                onPlayerWon?.Invoke();
            }else{
                onPlayerLost?.Invoke();
            }
        }
        
    }

}