using UnityEngine;
using TMPro;

public class UserDataPanel : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI username = null;
    [SerializeField] TextMeshProUGUI money = null;

    private void Start()
    {
        //username.SetText(GameManager.GetUserName());
        //money.SetText(GameManager.GetMOneyAsString());
    }
} 
