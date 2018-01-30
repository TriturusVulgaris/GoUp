using UnityEngine;
#if UNITY_EDITOR
using System.Diagnostics;
#endif

public class DualBehaviour : MonoBehaviour
{
    #region Public Members

    #endregion

    #region Public void

    #endregion

    #region System

    protected virtual void Awake()
    {
        Init();
    }

    protected virtual void Reset()
    {
        Init();
    }

    #endregion

    #region Class Methods

    private void Init()
    {
        if(m_transform == null)
            m_transform = GetComponent<Transform>();
    }

    #endregion

    #region Tools Debug and Utility

    #if UNITY_EDITOR
    protected Stopwatch m_watch = Stopwatch.StartNew();
    #endif

    #endregion

    #region Private and Protected Members

    [SerializeField]
    protected Transform m_transform;

    #endregion
}