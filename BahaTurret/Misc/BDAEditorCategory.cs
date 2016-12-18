using System;
using System.Linq;
using System.Linq.Expressions;
//using System.Core;
using System.Collections.Generic;
using UnityEngine;
using KSP.UI.Screens;

namespace BahaTurret
{
	[KSPAddon(KSPAddon.Startup.MainMenu, true)]
	public class BDAEditorCategory : MonoBehaviour
	{
		private static readonly List<AvailablePart> availableParts = new List<AvailablePart>();

		void Awake()
		{
			GameEvents.onGUIEditorToolbarReady.Add(BDAWeaponsCategory);

			//availableParts.Clear();
			//availableParts.AddRange(PartLoader.LoadedPartsList.BDAParts());

		}

		void BDAWeaponsCategory()
		{
			const string FILTER_CATEGORY = "Filter by Function";
			const string CUSTOM_CATEGORY_NAME = "BDA Weapons";

			availableParts.Clear();
			availableParts.AddRange(PartLoader.LoadedPartsList.BDAParts());

			Texture2D iconTex = GameDatabase.Instance.GetTexture("BDArmory/Textures/icon", false);

			RUI.Icons.Selectable.Icon icon = new RUI.Icons.Selectable.Icon("BDArmory", iconTex, iconTex, false);

			PartCategorizer.Category filter = PartCategorizer.Instance.filters.Find(f => f.button.categoryName == FILTER_CATEGORY);
			PartCategorizer.AddCustomSubcategoryFilter(filter, CUSTOM_CATEGORY_NAME, icon, p => availableParts.Contains(p));

			KSP.UI.UIRadioButton button = filter.button.activeButton;
			//button.SetFalse(button, RUIToggleButtonTyped.ClickType.FORCED);
			//button.SetTrue(button, RUIToggleButtonTyped.ClickType.FORCED, false);
		}



	}
}

