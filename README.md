# Kogane Set Debug Unity Logger Enabled Scope

UnityEngine.Debug.unityLogger.enabled を設定するスコープ

## 使用例

```cs
using Kogane;
using UnityEngine;

public class Example : MonoBehaviour
{
    private void Start()
    {
        Debug.Log( "ピカチュウ" ); // 出力される

        using ( new SetDebugUnityLoggerEnabledScope( false ) )
        {
            Debug.Log( "カイリュー" ); // 出力されない
        }

        Debug.Log( "ヤドラン" ); // 出力される
    }
}
```