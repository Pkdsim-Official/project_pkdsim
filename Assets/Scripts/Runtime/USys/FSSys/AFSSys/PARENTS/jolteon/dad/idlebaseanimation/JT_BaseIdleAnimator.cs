using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Jolteon.Dad.idlebaseanimation.IdleSitting;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Jolteon.Dad.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Jolteon.Dad.idlebaseanimation
{
	public class JolteonParentDad_AnimatorIdleController : MonoBehaviour
	{
		private JTParentDad_IdleStanding JTParentDad_idlestanding;

		private JTParentDad_IdleSitting JTParentDad_idlesitting;

		public void JTParentDad_IdleAnimatorController()
		{
			JTParentDad_idlestanding.JTParentDad_IdleStandingController();
			JTParentDad_idlesitting.JTParentDad_IdleSittingController();
		}
	}
}