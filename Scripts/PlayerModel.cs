using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SkyForce.Player
{
    public class PlayerModel
    {
       
        public PlayerView JetPrefab{get {return jetPrefab; }}
        
        public float ReloadTime{ get{ return reloadTime; }}
        public PlayerModel(PlayerScriptableObject jetProperties)
        {
            jetPrefab = jetProperties.JetPrefab;
            reloadTime = jetProperties.ReloadTime;
        }
    }
}
