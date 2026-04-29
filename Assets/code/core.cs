using NUnit.Framework.Constraints;
using UnityEngine;

public class core : MonoBehaviour
{
    public int _a;
    void Start()
    {
       switch (_a)
        {
            case 0:
                {
                    Debug.Log(0);
                    break;
                }
            case 1:
                {
                    Debug.Log(1);
                    break;
                }
        }
    }
}