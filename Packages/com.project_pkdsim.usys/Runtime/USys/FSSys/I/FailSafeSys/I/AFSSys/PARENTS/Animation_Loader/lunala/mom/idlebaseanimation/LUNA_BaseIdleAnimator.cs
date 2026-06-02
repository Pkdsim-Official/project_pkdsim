using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Lunala.Mom.idlebaseanimation.IdleSitting;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Lunala.Mom.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Lunala.Mom.idlebaseanimation
{
	public class LunalaParentMom_IdleAnimatorController : MonoBehaviour 
	{
		private LUNAParentMom_IdleStanding Lunalaidlestanding;
		
		private LUNAParentMom_IdleSitting Lunalaidlesitting;
		
		public void	LUNAParentDadMom_IdleAnimatorController()
		{
			LUNAParentMom_IdleStandingAnimatorController();
			LUNAParentMom_IdleSittingAnimatorController();
		}
		private void LUNAParentMom_IdleStandingAnimatorController()
		{
			Lunalaidlestanding.LUNAParentMom_IdleStandingController();
		}
		private void LUNAParentMom_IdleSittingAnimatorController()
		{
			Lunalaidlesitting.LUNAParentMom_IdleSittingController();
		}
	}
}