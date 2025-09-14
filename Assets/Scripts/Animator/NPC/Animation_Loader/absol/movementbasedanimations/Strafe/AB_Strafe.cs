using project_pkdsim.ANIMATOR.Npcs.Absol.movementbasedanimations.Strafing.StrafeLeft;
using project_pkdsim.ANIMATOR.Npcs.Absol.movementbasedanimations.Strafing.StrafeRight;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Npcs.Absol.movementbasedanimations.Strafing
{
	public class AB_Strafing : MonoBehaviour 
	{
		private ABStrafeLeft AB_strafeleft;
		
		private ABStrafeRight AB_straferight;

		public void AB_StrafingController()
		{
			if (AB_strafeleft == null)
			{
				AB_strafeleft = GetComponent<ABStrafeLeft>();
				Load_ABStrafeLeft();
			}
			if (AB_straferight == null)
			{
				AB_straferight = GetComponent<ABStrafeRight>();
				Load_ABStrafeRight();
			}
			

		}
		private void Load_ABStrafeRight()
		{
			AB_straferight.ABStrafeRightController();
		}
		
		private void Load_ABStrafeLeft()
		{
			AB_strafeleft.ABStrafeLeftController();
		}
	}
}