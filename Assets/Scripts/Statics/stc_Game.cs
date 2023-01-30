using UnityEngine;

namespace IntermediateScripting
{
    public class stc_Game : MonoBehaviour
    {
        private void Start()
        {
            stc_Enemy _enemy1 = new stc_Enemy();
            stc_Enemy _enemy2 = new stc_Enemy();
            stc_Enemy _enemy3 = new stc_Enemy();
            
            int x = stc_Enemy.enemyCount;
            Debug.Log("EnemyCount : " + x);
        }
    }
}
