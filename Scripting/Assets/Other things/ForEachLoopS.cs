using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForEachLoopS : MonoBehaviour
{

    public List<GameObject> powerUpList;
    public List<GameObject> cubeList;
    public List<GameObject> sphereList;
    public List<GameObject> capsuleList;

    public void CheckData()
    {

        foreach (GameObject item in powerUpList)
        {
            switch (item.name)
            {
                case "Cube":
                    cubeList.Add(item);
                    break;
                case "Sphere":
                    cubeList.Add(item);
                    break;
                case "Capsule":
                    cubeList.Add(item);
                    break;

            }
        }
    }
}
            
