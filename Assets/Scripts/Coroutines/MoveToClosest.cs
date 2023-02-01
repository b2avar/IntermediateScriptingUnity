using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IntermediateScripting
{
    public class MoveToClosest : MonoBehaviour
    {
        public GameObject[] targets; // Hedef objelerin dizisi
        private Transform closest; // En yakın hedef objesi

        // Update is called once per frame
        void Update()
        {
            // En yakın hedef objesini bulun
            float closestDistance = Mathf.Infinity;
            foreach (GameObject target in targets)
            {
                float distance = Vector3.Distance(transform.position, target.transform.position);
                if (distance < closestDistance)
                {
                    closestDistance = distance;
                    closest = target.transform;
                }
            }

            // En yakın objenin konumuna doğru hareket edin
            transform.position = Vector3.MoveTowards(transform.position, closest.position, Time.deltaTime);
        }
    }
}
