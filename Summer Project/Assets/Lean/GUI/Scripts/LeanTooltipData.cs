using UnityEngine;
using UnityEngine.EventSystems;
using Lean.Common;
#if UNITY_EDITOR
using UnityEditor;

namespace Lean.Gui
{
	[CanEditMultipleObjects]
	[CustomEditor(typeof(LeanTooltipData))]
	public class LeanTooltipData_Editor : LeanInspector<LeanTooltipData>
	{
		protected override void DrawInspector()
		{
			Draw("text");
		}
	}
}
#endif

namespace Lean.Gui
{
	/// <summary>This component allows you to associate text with this GameObject, allowing it to be displayed from a tooltip.</summary>
	[HelpURL(LeanGui.HelpUrlPrefix + "LeanTooltipData")]
	[AddComponentMenu(LeanGui.ComponentMenuPrefix + "Tooltip Data")]
	public class LeanTooltipData : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
	{
		/// <summary>This allows you to set the tooltip text string that is associated with this object.</summary>
		public string Text { set { text = value; } get { return text; } } [Multiline] [SerializeField] private string text;

		// Force the enable checkbox to show
		protected virtual void OnEnable()
		{
		}

		public void OnPointerEnter(PointerEventData eventData)
		{
			LeanTooltip.CurrentPointer = eventData;
			LeanTooltip.CurrentData    = this;
		}

		public void OnPointerExit(PointerEventData eventData)
		{
			if (LeanTooltip.CurrentData == this)
			{
				LeanTooltip.CurrentPointer = null;
				LeanTooltip.CurrentData    = null;
			}
		}
	}
}