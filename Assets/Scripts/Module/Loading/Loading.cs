
using UnityEngine;

public class Loading : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Object[] objects = Resources.LoadAll("Dy/Sp/Pet_atlas");
        Debug.Log(objects.Length);
        for (int i = 0; i < objects.Length; i++)
        {

        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
