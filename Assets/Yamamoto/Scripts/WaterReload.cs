using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterReload : MonoBehaviour
{
   RectTransform rt;
   public bool Reload;

    [SerializeField]
    private Shot Shot;

	void Start () {
		//bar1のRectTransformコンポーネントをキャッシュ
		rt = GetComponent<RectTransform>();
	}

	void Update (){
		//クリック中且つ、PlayerScriptのisGroundedがtrueである時ゲージを増やす
		if (Reload == false) {
			//sizeDeltaでゲージの大きさを制御
			//左端から、毎フレーム1ずつ増やす
			rt.sizeDelta = new Vector2 (rt.sizeDelta.x + 0.5f, 15.0f);
			//ゲージの横幅が150を超えたら止まる
        }
			if (rt.sizeDelta.x >= 149) {
				Reload = true;
                Shot.ReWater();

			}
		
		
	}
    public void ReloadReset()
    {
    rt.sizeDelta = new Vector2 (0.0f, 15.0f);
    Reload = false;
    }
}
