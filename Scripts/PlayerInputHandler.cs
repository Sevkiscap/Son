using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SkyForce.Player
{
    public class PlayerInputHandler : MonoBehaviour
    {
        void Update()
        {
           
            if (Input.GetMouseButton(0))
            {
                    Vector3 position = Camera.main.ScreenToWorldPoint(Input.mousePosition).SetZ(0);
                    PlayerService.Instance.SetFighterJetTo(position);
            }
         
        }
    }
}
