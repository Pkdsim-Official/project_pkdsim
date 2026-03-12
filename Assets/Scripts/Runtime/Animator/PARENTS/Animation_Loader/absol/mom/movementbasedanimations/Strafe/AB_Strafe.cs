using Project_Pkdsim.ANIMATOR.Parents.Absol.Mom.movementbasedanimations.Strafing.StrafeLeft;
using Project_Pkdsim.ANIMATOR.Parents.Absol.Mom.movementbasedanimations.Strafing.StrafeRight;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Absol.Mom.movementbasedanimations.Strafing
{
	public class ABParentMom_Strafing : MonoBehaviour 
	{
		private ABParentMom_StrafeLeft ABParentMom_strafeleft;
		
		private ABParentMom_StrafeRight ABParentMom_straferight;

		public void ABParentMom_StrafingController()
		{
			if (ABParentMom_strafeleft == null)
			{
				Load_ABParentMom_StrafeLeft();
			}
			if (ABParentMom_straferight == null)
			{
				Load_ABParentMom_StrafeRight();
			}
		}
		private void Load_ABParentMom_StrafeRight()
		{
			ABParentMom_straferight.ABParentMom_StrafeRightController();
		}
		
		private void Load_ABParentMom_StrafeLeft()
		{
			ABParentMom_strafeleft.ABParentMom_StrafeLeftController();
		}
	}
}