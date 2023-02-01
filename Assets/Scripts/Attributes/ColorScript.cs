using UnityEngine;

namespace IntermediateScripting
{
    [ExecuteInEditMode]
    public class ColorScript : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            gameObject.GetComponent<Material>().color = Color.red;
        }
    }
}
