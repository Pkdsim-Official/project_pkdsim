using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Sylveon.Dad.converteranimations.IdleTo;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Sylveon.Dad.converteranimations.SittingTo;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Sylveon.Dad.converteranimations.WalkingTo;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Sylveon.Dad.converteranimations
{
	public class SylveonParentDad_ConverterAnimatorController : MonoBehaviour
	{
		private SYLParentDad_SittingTo Sylveon_sittingto;

		private SYLParentDad_WalkingTo Sylveon_walkingto;

		private SYLParentDad_IdleTo Sylveon_idleto;

		public void SYLParentDad_ConverterAnimatorController()
		{
			Sylveon_walkingto.SYLParentDad_WalkingToController();

			Sylveon_idleto.SYLParentDad_IdleToController();

			Sylveon_sittingto.SYLParentDad_SittingToController();
		}
	}
}