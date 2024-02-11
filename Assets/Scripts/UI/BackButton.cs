using UnityEngine;
using UnityEngine.UI;

public class BackButton : MonoBehaviour
{

    [SerializeField] Button backButton = null;

    private void Start()
    {
        backButton.onClick.AddListener(handleBackButtonPressed);
    }

    private void OnDestroy()
    {
        backButton.onClick.RemoveListener(handleBackButtonPressed);
    }

    private void handleBackButtonPressed()
    {
        Events.BackButtonPressed?.Invoke();
    }
}
