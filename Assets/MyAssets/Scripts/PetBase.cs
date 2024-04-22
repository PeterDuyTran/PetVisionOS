using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Serialization;

namespace PetVisionPro.Scripts
{
	public class PetBase : MonoBehaviour, ITouchObjectFunctions, IPetActions
	{
		[FormerlySerializedAs("_prefabModel")] [SerializeField] private List<GameObject> _prefabModels;
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

		[ContextMenu("Change Pet")]
		public void ChangePet()
		{
			if (_currentModel)
				Destroy(_currentModel);
			_currentModel = Instantiate(_prefabModels[PetIndex++]);
			_currentModel.transform.SetParent(transform);
			_currentModel.transform.SetLocalPositionAndRotation(Vector3.zero, quaternion.identity);
		}

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

		public void Eating()
		{
			throw new System.NotImplementedException();
		}

		public void Dancing()
		{
			throw new System.NotImplementedException();
		}

		public void Playing()
		{
			throw new System.NotImplementedException();
		}
	}
}