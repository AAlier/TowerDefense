using UnityEngine;
using UnityEngine.EventSystems;

public class Nodes : MonoBehaviour {
	public Color hoverColor;
	public Color notEnoughMoneyColor;

	public Vector3 positionOffset;

	[Header("Optional")]
	public GameObject turret;

	BuildManager buildManager;
	private Renderer rend;
	private Color startColor;

	void Start(){
		rend = GetComponent<Renderer> ();
		startColor = rend.material.color;

		buildManager = BuildManager.instance;
	}

	void OnMouseDown(){

		if (EventSystem.current.IsPointerOverGameObject ())
			return;
		
		if (!buildManager.CanBuild)
			return;

		if (turret != null) {
			return;
		}

		buildManager.BuildTurretOn (this);
	}

	public Vector3 GetBuildPosition(){
		return transform.position + positionOffset;
	}

	void OnMouseEnter(){

		if (EventSystem.current.IsPointerOverGameObject ())
			return;

		if (!buildManager.CanBuild)
			return;
		if (buildManager.HasMoney) {
			rend.material.color = hoverColor;
		} else {
			rend.material.color = notEnoughMoneyColor;
		}
	}

	void OnMouseExit(){
		rend.material.color = startColor;
	}
}
