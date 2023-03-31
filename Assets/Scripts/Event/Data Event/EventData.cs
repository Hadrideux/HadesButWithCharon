using UnityEngine;

[CreateAssetMenu(fileName = "ItemData", menuName = "Data/ItemData")]
public class ItemData : ScriptableObject
{

    [SerializeField] private EEventName _eventName = EEventName.MutinyEvent;
    [SerializeField] private string _effect = "Apocalypse";
    [SerializeField] private float _delay = 0f;
    [SerializeField] private float _productionSoul = 0f;
    [SerializeField] private float _callRate = 0f;

    public EEventName EventLocation => _eventName;
    public string Effect => _effect;
    public float Delay => _delay;
    public float ProductionSoul => _productionSoul;

}
