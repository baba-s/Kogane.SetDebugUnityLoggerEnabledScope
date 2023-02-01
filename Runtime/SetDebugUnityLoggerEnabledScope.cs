using System;
using UnityEngine;

namespace Kogane
{
    public readonly struct SetDebugUnityLoggerEnabledScope : IDisposable
    {
        private readonly bool m_oldLogEnabled;

        public SetDebugUnityLoggerEnabledScope( bool logEnabled )
        {
            m_oldLogEnabled              = Debug.unityLogger.logEnabled;
            Debug.unityLogger.logEnabled = logEnabled;
        }

        public void Dispose()
        {
            Debug.unityLogger.logEnabled = m_oldLogEnabled;
        }
    }
}