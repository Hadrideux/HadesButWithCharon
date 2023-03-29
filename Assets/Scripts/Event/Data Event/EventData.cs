using UnityEngine;

[CreateAssetMenu(fileName = "ItemData", menuName = "Data/ItemData")]
public class ItemData : ScriptableObject
{

    [SerializeField] private EEventLocation _eventLocation = EEventLocation.EARTH;
    [SerializeField] private string _effect = "Apocalypse";
    [SerializeField] private float _delay = 0f;
    [SerializeField] private float _productionSoul = 0f;

    public EEventLocation EventLocation => _eventLocation;
    public string Effect => _effect;
    public float Delay => _delay;
    public float ProductionSoul => _productionSoul;

}
