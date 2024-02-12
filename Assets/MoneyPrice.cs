using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyPrice : MonoBehaviour
{
    public float priceObject = 5f;
    int objectNum;
    [SerializeField] Mesh cubeC;
    [SerializeField] Mesh coneC;
    [SerializeField] Mesh sphereS;
    [SerializeField] Mesh cylinderC;
    [SerializeField] Mesh capsuleC;

    [SerializeField] Material mat1;
    [SerializeField] Material mat2;
    // Start is called before the first frame update
    void Start()
    {
        objectNum = (int)Random.Range(1, 5);

        switch (objectNum)
        {
            case 1:
                priceObject = 10f;
                GetComponent<MeshFilter>().mesh = cubeC;
                break;
            case 2:
                priceObject = 20f;
                GetComponent<MeshFilter>().mesh = sphereS;
                break;
            case 3:
                priceObject = 5f;
                GetComponent<MeshFilter>().mesh = cylinderC;
                break;
            case 4:
                priceObject = 50f;
                GetComponent<MeshFilter>().mesh = capsuleC;
                break;
            case 5:
                priceObject = 5f;
                GetComponent<MeshFilter>().mesh = cubeC;
                break;

        }
        GetComponent<MeshRenderer>().material = (Random.Range(0, 10) % 2 == 0) ? mat1 : mat2;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
