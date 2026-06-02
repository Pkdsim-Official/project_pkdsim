using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Lunala.Dad.idlebaseanimation.IdleSitting;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Lunala.Dad.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Lunala.Dad.idlebaseanimation
{
	public class LunalaParentDad_IdleAnimatorController : MonoBehaviour 
	{
		private LUNAParentDad_IdleStanding Lunalaidlestanding;
		
		private LUNAParentDad_IdleSitting Lunalaidlesitting;
		
		public void	LUNAParentDad_IdleAnimatorController()
		{
			LUNAParentDad_IdleStandingAnimatorController();
			LUNAParentDad_IdleSittingAnimatorController();
		}
		private void LUNAParentDad_IdleStandingAnimatorController()
		{
			Lunalaidlestanding.LUNAParentDad_IdleStandingController();
		}
		private void LUNAParentDad_IdleSittingAnimatorController()
		{
			Lunalaidlesitting.LUNAParentDad_IdleSittingController();
		}
	}
}