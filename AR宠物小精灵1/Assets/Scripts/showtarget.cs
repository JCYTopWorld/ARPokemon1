using UnityEngine;
using System.Collections;

public class showtarget : MonoBehaviour
{

    public bool delete;
    public GameObject targetPrefab;
    GameObject target;
    // Use this for initialization
    void Start()
    {
    target= (GameObject)GameObject.Instantiate(targetPrefab, transform.position, transform.rotation);
    }
    void Update()
    {
        if (delete)
        {
            GameObject.Destroy(target);
        }
    }
}
