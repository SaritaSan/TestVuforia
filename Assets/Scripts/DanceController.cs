using UnityEngine;
using UnityEngine.Events;

public class DanceController : MonoBehaviour
{
    [SerializeField]
    private UnityEvent _onSelectDance;

    [SerializeField]
    private UnityEvent _onDanceSelected;

    public void ActivateSelecteDance()
    {
        _onSelectDance?.Invoke();
    }

    public void OnSelectedDance()
    {
        _onDanceSelected?.Invoke();
    }
}
