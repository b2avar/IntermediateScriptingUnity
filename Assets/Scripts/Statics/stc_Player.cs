using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IntermediateScripting
{
    public class stc_Player : MonoBehaviour
    {
        public static int playerCount = 0;

        private void Start()
        {
            playerCount++;
        }
    }
}
