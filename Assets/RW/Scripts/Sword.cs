
using UnityEngine;

public class Sword : MonoBehaviour
{
    //[SerializeField] private SwordData swordData;
    [SerializeField] private GameEvent OnSwordEvent;

    private void OnMouseDown()
    {
        OnSwordEvent.Raise();
    }
}
