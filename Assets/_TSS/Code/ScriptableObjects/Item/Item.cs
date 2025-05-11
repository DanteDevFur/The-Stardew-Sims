using UnityEngine;

namespace _TSS.Item
{
    [CreateAssetMenu(fileName = "ItemFile", menuName = "_TSS/Item/Item", order = 0)]
    public class Item : ScriptableObject
    {
        [field: SerializeField] public string Name { get; private set; }
        [field: SerializeField] public Sprite Icon { get; private set; }
        [field: SerializeField] public int Price { get; private set; }
        
        [field: TextArea]
        [field: SerializeField] public string Description { get; private set; }
    }
}