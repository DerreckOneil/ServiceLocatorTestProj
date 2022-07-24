using UnityEngine;


[CreateAssetMenu]
public class DebugService : ScriptableObject, IDebugService
{
    public void PrintHelloWorld()
    {
        Debug.Log("Hello world");
    }
}