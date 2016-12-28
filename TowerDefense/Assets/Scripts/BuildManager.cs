using UnityEngine;

public class BuildManager : MonoBehaviour {
	
	public static BuildManager instance;
	public GameObject standartTurretPrefab;

	private TurretBlueprint turretToBuild;

	public GameObject missileLauncherPrefab;
	public bool CanBuild{ get { return turretToBuild != null; } }
	public bool HasMoney{ get { return Currency.Money >= turretToBuild.cost; } }

	void Awake(){
		if (instance != null) 
			return;
		
		instance = this;
	}

	public void BuildTurretOn(Nodes node){

		if (Currency.Money < turretToBuild.cost) {
			Debug.Log("Not enough money to purchase");
			return;
		}

		Currency.Money -= turretToBuild.cost;
		GameObject turret = (GameObject) Instantiate (turretToBuild.prefab, node.GetBuildPosition (), Quaternion.identity);
		node.turret = turret;

		Debug.Log ("Turret build! Money left: " + Currency.Money);
	}
		
	public void SelectTurretToBuild(TurretBlueprint turret){
		turretToBuild = turret;
	}
}
