namespace TheStonefox.Test.Prefabrilous.Prefabs.Debogz
{
    using UnityEngine;

    public class Deboginator : MonoBehaviour
    {
        Prefabronifier p = new Prefabronifier();

        protected virtual void OnEnable()
        {
            Debug.Log(p.Prefabrone());
        }
    }
}
