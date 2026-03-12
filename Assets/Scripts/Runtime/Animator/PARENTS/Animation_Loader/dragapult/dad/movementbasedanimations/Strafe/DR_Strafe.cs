using Project_Pkdsim.ANIMATOR.Parents.Dragapult.movementbasedanimations.Strafing.StrafeLeft;
using Project_Pkdsim.ANIMATOR.Parents.Dragapult.movementbasedanimations.Strafing.StrafeRight;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Dragapult.movementbasedanimations.Strafing
{
	public class DRParent_Strafing : MonoBehaviour 
	{
		private DR_StrafeLeft DR_strafeleft;
		
		private DR_StrafeRight DR_straferight;

		public void DRParent_StrafingController()
		{
			if (DR_strafeleft == null)
			{
				Load_DR_StrafeLeft();
			}
			if (DR_straferight == null)
			{
				Load_DR_StrafeRight();
			}
			

		}
		private void Load_DR_StrafeRight()
		{
			DR_straferight.DR_StrafeRightController();
		}
		
		private void Load_DR_StrafeLeft()
		{
			DR_strafeleft.DR_StrafeLeftController();
		}
	}
}