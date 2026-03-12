using Project_Pkdsim.ANIMATOR.Parents.Lucario.Mom.idlebaseanimation.IdleSitting;
using Project_Pkdsim.ANIMATOR.Parents.Lucario.Mom.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Lucario.Mom.idlebaseanimation
{
	public class LucarioParentMom_IdleAnimatorController : MonoBehaviour 
	{
		private LUCAParentMom_IdleStanding LUCAParentMom_Idlestanding;
		
		private LUCAParentMom_IdleSitting LUCAParentMom_Idlesitting;
		
		public void	LUCAParentMom_IdleAnimatorController()
		{
			LUCAParentMom_IdleStandingAnimatorController();
			LUCAParentMom_IdleSittingAnimatorController();
		}
		private void LUCAParentMom_IdleStandingAnimatorController()
		{
			LUCAParentMom_Idlestanding.LUCAParentMom_IdleStandingController();
		}
		private void LUCAParentMom_IdleSittingAnimatorController()
		{
			LUCAParentMom_Idlesitting.LUCAParentMom_IdleSittingController();
		}
	}
}