using Project_Pkdsim.ANIMATOR.Parents.Noivern.Mom.idlebaseanimation.IdleSitting;
using Project_Pkdsim.ANIMATOR.Parents.Noivern.Mom.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Noivern.Mom.idlebaseanimation
{
	public class NoivernParentMom_IdleAnimatorController : MonoBehaviour 
	{
		private NOIParentMom_IdleStanding NOIParentMom_Idlestanding;
		
		private NOIParentMom_IdleSitting NOIParentMom_Idlesitting;
		
		public void	NOIParentMom_IdleAnimatorController()
		{
			NOIParentMom_IdleStandingAnimatorController();
			NOIParentMom_IdleSittingAnimatorController();
		}
		private void NOIParentMom_IdleStandingAnimatorController()
		{
			NOIParentMom_Idlestanding.NOIParentMom_IdleStandingController();
		}
		private void NOIParentMom_IdleSittingAnimatorController()
		{
			NOIParentMom_Idlesitting.NOIParentMom_IdleSittingController();
		}
	}
}