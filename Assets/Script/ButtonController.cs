using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ButtonController : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI m_Title;

    [SerializeField]
    private Image m_Icon;

    [SerializeField]
    private string m_Text;

    [SerializeField]
    private Sprite m_Sprite;

    [SerializeField]
private Color m_Color = Color.white;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Hello World");
        m_Title.text = m_Text;
        m_Icon.sprite = m_Sprite;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeIconColor()
{
    m_Icon.color = m_Color;
}
}
