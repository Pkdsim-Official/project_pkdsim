using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Sylveon.Dad.idlebaseanimation.IdleSitting;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Sylveon.Dad.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Sylveon.Dad.idlebaseanimation
{
	public class SylveonParentDad_IdleAnimatorController : MonoBehaviour
	{
		private SYLParentDad_IdleStanding SYLParentDad_idlestanding;

		private SYLParentDad_IdleSitting SYLParentDad_idlesitting;

		public void SYLParentDad_IdleAnimatorController()
		{
			SYLParentDad_idlestanding.SYLParentDad_IdleStandingController();
			SYLParentDad_idlesitting.SYLParentDad_IdleSittingController();
		}
	}
}