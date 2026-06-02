using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Dragapult.Dad.movementbasedanimations.Turning.TurnLeft;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Dragapult.Dad.movementbasedanimations.Turning.TurnRight;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Dragapult.Dad.movementbasedanimations.Turning
{
	public class DRParentDad_Parent_Turning : MonoBehaviour	
	{
		private DRParentDad_Parent_TurnLeft DRParentDad_Parent_TurnLeft;
		private DRParentDad_Parent_TurnRight DRParentDad_Parent_TurnRight;

		public void DRParentDad_Parent_TurningController()
		{
			if (DRParentDad_Parent_TurnLeft == null)
			{
				Load_DRParentDad_Parent_TurnLeft();
			}
			if (DRParentDad_Parent_TurnRight == null)
			{
				Load_DRParentDad_Parent_TurnRight();
			}
		}

		private void Load_DRParentDad_Parent_TurnRight()
		{
			DRParentDad_Parent_TurnRight.DRParentDad_Parent_TurnRightController();
		}
		
		private void Load_DRParentDad_Parent_TurnLeft()
		{
			DRParentDad_Parent_TurnLeft.DRParentDad_Parent_TurnLeftController();
		}
	}
}