using UnityAtoms.BaseAtoms;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    [SerializeField]
    private GameObjectVariable m_playerVariable = null;

    private void Start()
    {
        m_playerVariable.Value = GameObject.FindGameObjectWithTag("Player");
    }

}
