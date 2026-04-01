using UnityEngine;

public class DisolveControl : MonoBehaviour
{

    public Material disolveMaterial;
    public bool disolve = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(disolve)
        {
            disolveMaterial.SetFloat("_Disolve", 0.5f);
            disolve = false;
        }
        

    }
}
