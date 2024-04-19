using UnityEngine;

namespace PetVisionPro.Scripts
{
	public class PetBase : MonoBehaviour, ITouchObjectFunctions
	{
		public GameObject GetMainObject()
		{
			return gameObject;
		}

		public void StartSelect()
		{
			throw new System.NotImplementedException();
		}

		public void Move()
		{
			throw new System.NotImplementedException();
		}

		public void EndSelect(bool WithCancel)
		{
			throw new System.NotImplementedException();
		}
	}
}