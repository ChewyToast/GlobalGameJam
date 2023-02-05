using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjSpawner : MonoBehaviour
{
	public Transform	spawnPos;
	public GameObject	Down;
	public GameObject	Up;

	void	Start(){
		if (DifSelection.menuSelection <= 1)
			{InvokeRepeating("SpawnObject", 2.04f, 2.04f);}
		else if (DifSelection.menuSelection == 2)
			{InvokeRepeating("SpawnObject", 1.02f, 1.02f);}
		else if (DifSelection.menuSelection >= 3)
			{InvokeRepeating("SpawnObject", 0.54f, 0.54f);}
	}

	void	SpawnObject() {
		if( Random.Range(0, 2) == 0 )
			{GameObject spawned = Instantiate(Up, spawnPos.transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;}
		else
			{GameObject spawned = Instantiate(Down, spawnPos.transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;}
	}
}
