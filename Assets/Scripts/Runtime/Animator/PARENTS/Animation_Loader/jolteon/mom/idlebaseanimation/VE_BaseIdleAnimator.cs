using Project_Pkdsim.ANIMATOR.Parents.Jolteon.Mom.idlebaseanimation.IdleSitting;
using Project_Pkdsim.ANIMATOR.Parents.Jolteon.Mom.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Jolteon.Mom.idlebaseanimation
{
	public class JolteonParentMom_IdleAnimatorController : MonoBehaviour 
	{
		private JTParentMom_IdleStanding JTParentMom_Idlestanding;
		
		private JTParentMom_IdleSitting JTParentMom_Idlesitting;
		
		public void	JTParentMom_IdleAnimatorController()
		{
			JTParentMom_IdleStandingAnimatorController();
			JTParentMom_IdleSittingAnimatorController();
		}
		private void JTParentMom_IdleStandingAnimatorController()
		{
			JTParentMom_Idlestanding.JTParentMom_IdleStandingController();
		}
		private void JTParentMom_IdleSittingAnimatorController()
		{
			JTParentMom_Idlesitting.JTParentMom_IdleSittingController();
		}
	}
}