using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace SpaceRepair {
    public class LevelManager : MonoBehaviour {
        
        [SerializeField] private LevelRules levelRules;

        


        public static LevelManager current;
        private void Awake(){
            current = this;
        }
        public void OnKeyFound(){
            levelRules.ReduceKeyCounts();
        }
        public void OnDamageReparing(){
            levelRules.OnDamageReparied();
        }



        public bool IsLevelComplete(){
            return levelRules.IsCompletedTheLevel();
        }

        
    }

}