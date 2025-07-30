using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Jolteon.Mom.idlebaseanimation.IdleSitting;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Jolteon.Mom.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Jolteon.Mom.idlebaseanimation
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