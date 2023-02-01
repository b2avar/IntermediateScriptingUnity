using System.Collections;
using UnityEngine;

namespace IntermediateScripting
{
    public class PropertiesAndCoroutines : MonoBehaviour
    {
        public float smoothing = 7f;
        public Vector3 Target
        {
            get { return _target; }
            set
            {
                _target = value;

                StopCoroutine("Movement");
                StartCoroutine("Movement", _target);
            }
        }
        
        private Vector3 _target;
        
        IEnumerator Movement (Vector3 target)
        {
            while(Vector3.Distance(transform.position, target) > 0.05f)
            {
                transform.position = Vector3.Lerp(transform.position, target, smoothing * Time.deltaTime);

                yield return null;
            }
        }
    }
}
