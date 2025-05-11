using UnityEngine;
using UnityEngine.U2D.Animation;

namespace _TSS.Item
{
    [CreateAssetMenu(fileName = "Equippable File", menuName = "_TSS/Item/Equippable", order = 0)]
    public class EquippabbleItem : Item
    {
        [field: SerializeField] public SpriteLibraryAsset SpriteLibraryAsset { get; private set; }
    }
}