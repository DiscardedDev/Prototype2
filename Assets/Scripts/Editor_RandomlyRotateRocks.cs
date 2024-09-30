using UnityEngine;

[ExecuteInEditMode]
public class TreeController : MonoBehaviour
{
    // This Script is on parent GameObject
    // and all of the Rocks are children of this transform.

    [SerializeField] bool rotateRocks = false;


    void Update ()
    {
        if (rotateRocks)
        {
            for (int i = 0; i < transform.childCount; i++)
            {
                transform.GetChild(i).rotation = Quaternion.Euler(Vector3.up * Random.Range(0f, 360f));
            }

            rotateRocks = false;
        }
    }
}