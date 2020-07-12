using UnityAtoms.BaseAtoms;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{

    [SerializeField]
    private IntReference m_maxHealth = null;

    [SerializeField]
    private IntReference m_currentHealth = null;

    [SerializeField]
    private Slider m_slider = null;

    [SerializeField]
    private Image m_fill = null;

    private void Start()
    {
        Refresh();
    }

    public void Refresh()
    {
        m_slider.value = (float)m_currentHealth / (float)m_maxHealth;
        m_fill.color = Color.Lerp(Color.red, Color.green, m_slider.value);
    }

}
