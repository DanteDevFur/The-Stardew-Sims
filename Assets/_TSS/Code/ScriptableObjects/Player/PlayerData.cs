using UnityEngine;

namespace _TSS.Player
{
    [CreateAssetMenu(fileName = "PlayerDataFile", menuName = "_TSS/Player Data", order = 0)]
    public class PlayerData : ScriptableObject
    {
        [field: Range(0.25f, 25)]
        [field: SerializeField] public float Speed = 1;
    }
}