﻿using System;
using UnityEngine;

namespace BDArmory
{
	public struct RadarDisplayData
	{
		public Vessel vessel;
		public Vector2 pingPosition;
		public bool locked;
		public ModuleRadar detectedByRadar;
		public TargetSignatureData targetData;
		public float signalPersistTime;
	}
}

