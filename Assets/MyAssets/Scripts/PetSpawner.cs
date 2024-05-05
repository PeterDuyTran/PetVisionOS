using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;

namespace PetVisionPro.Scripts
{
	public class PetSpawner : MonoBehaviour
	{
		[FormerlySerializedAs("_prefabModel")] [SerializeField]
		private List<GameObject> _prefabModels;

		private int _petIndex;
		private GameObject _currentModel;

		public int PetIndex
		{
			get => _petIndex;
			set
			{
				if (value >= _prefabModels.Count - 1)
					_petIndex = 0;
				else if (value <= 0)
					_petIndex = _prefabModels.Count - 1;
				else
				{
					_petIndex = value;
				}
			}
		}

		private void Start()
		{
			ChangePet();
		}

		public void ChangePet()
		{
			if (_currentModel)
				Destroy(_currentModel);
			_currentModel = Instantiate(_prefabModels[PetIndex++]);
			_currentModel.transform.SetParent(transform);
			_currentModel.transform.SetLocalPositionAndRotation(Vector3.zero, quaternion.identity);
		}
		
		
		public void ChangeAnim()
		{
			
		}
	}
}