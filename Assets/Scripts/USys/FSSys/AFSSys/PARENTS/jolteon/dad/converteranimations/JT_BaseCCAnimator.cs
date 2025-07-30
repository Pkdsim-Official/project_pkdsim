using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Jolteon.Dad.converteranimations.IdleTo;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Jolteon.Dad.converteranimations.SittingTo;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Jolteon.Dad.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Jolteon.Dad.converteranimations
{
	public class JolteonParentDad_ConverterAnimatorController : MonoBehaviour
	{
		private JTParentDad_SittingTo JolteonParentDadsittingto;

		private JTParentDad_WalkingTo JolteonParentDadwalkingto;

		private JTParentDad_IdleTo JolteonParentDadidleto;

		public void JTParentDad_ConverterAnimatorController()
		{
			JolteonParentDadwalkingto.JTParentDad_WalkingToController();

			JolteonParentDadidleto.JTParentDad_IdleToController();

			JolteonParentDadsittingto.JTParentDad_SittingToController();
		}
	}
}