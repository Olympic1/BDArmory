//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18449
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using UnityEngine;
namespace BDArmory
{
	public class TGPCamRotator : MonoBehaviour 
	{

		void OnPreRender()
		{
			if(TargetingCamera.Instance)
			{
				TargetingCamera.Instance.UpdateCamRotation(transform);
			}
		}
	}
}

