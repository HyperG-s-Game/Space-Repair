using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace SpaceRepair {
    [CreateAssetMenu(fileName = "New Level Rules",menuName = "ScriptableObjects/Level Rules")]
    public class LevelRules : ScriptableObject{

        public LevelRulesSaveData saveData;


        public void ReduceKeyCounts(){
            if(saveData.keyCounts > 0){
                saveData.keyCounts--;
            }
        }
        public void OnDamageReparied(){
            if(saveData.hasRepairedAllTheDamages > 0){
                saveData.hasRepairedAllTheDamages--;
            }
        }
        public int GetCurrentKeyCounts(){
            return saveData.keyCounts;
        }
        public int GetHasRepariedAllTheDamages(){
            return saveData.hasRepairedAllTheDamages;
        }
        
        public bool IsCompletedTheLevel(){
            if(saveData.keyCounts <= 0 && saveData.hasRepairedAllTheDamages <= 0 && !saveData.isCompleted){
                saveData.isCompleted = true;
                return true;
            }
            return false;
        }
        
    }
    [System.Serializable]
    public class LevelRulesSaveData{
        public int keyCounts;
        public int hasRepairedAllTheDamages;
        public bool isCompleted;
    }

}