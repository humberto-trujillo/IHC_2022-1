using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Problema2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private bool CompareTestResult(int[] result, int[] expectedResult)
    {
        for (int i = 0; i < result.Length; i++)
        {
            if (result[i] != expectedResult[i]) return false;
        }
        return true;
    }
}
