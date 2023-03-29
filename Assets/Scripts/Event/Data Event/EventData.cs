using UnityEngine;

[CreateAssetMenu(fileName = "ItemData", menuName = "Data/ItemData")]
public class ItemData : ScriptableObject
{

    [SerializeField] private EEventLocation _eventLocation = EEventLocation.EARTH;
    [SerializeField] private float _delay = 0f;
    [SerializeField] private float _effect = 0f;

    public EEventLocation EventLocation => _eventLocation;
    public float Delay => _delay;
    public float Effect => _effect;

}
