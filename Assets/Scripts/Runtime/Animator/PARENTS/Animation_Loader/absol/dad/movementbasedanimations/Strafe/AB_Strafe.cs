using Project_Pkdsim.ANIMATOR.Parents.Absol.Dad.movementbasedanimations.Strafing.StrafeLeft;
using Project_Pkdsim.ANIMATOR.Parents.Absol.Dad.movementbasedanimations.Strafing.StrafeRight;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Absol.Dad.movementbasedanimations.Strafing
{
	public class ABParent_Strafing : MonoBehaviour 
	{
		private ABStrafeLeft AB_strafeleft;
		
		private ABStrafeRight AB_straferight;

		public void ABParent_StrafingController()
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