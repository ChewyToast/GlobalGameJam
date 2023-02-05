using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RootSpawn : MonoBehaviour
{
	public Transform	spawnPos;
	public GameObject	toSpawn;

	void	Start(){
		if (DifSelection.menuSelection <= 1)
			{InvokeRepeating("SpawnObject", 0.68f, 0.68f);}
		else if (DifSelection.menuSelection == 2)
			{InvokeRepeating("SpawnObject", 0.34f, 0.34f);}
		else if (DifSelection.menuSelection >= 3)
			{InvokeRepeating("SpawnObject", 0.18f, 0.18f);}
	}

	void	SpawnObject() {
		GameObject spawned = Instantiate(toSpawn, spawnPos.transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;
	}
}
