using UnityEngine;

public class PlayerControllerDemo : MonoBehaviour
{
    [SerializeField] private GameRuntime gameRuntime;

    private void Start()
    {
        IDebugService debugLeBug = gameRuntime.ServiceLocator.GetService<IDebugService>();
        debugLeBug.PrintHelloWorld();
    }
}