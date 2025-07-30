using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Vaporeon.Dad.converteranimations.WalkingTo;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Vaporeon.Dad.converteranimations.SittingTo;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Vaporeon.Dad.converteranimations.IdleTo;
using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Vaporeon.Dad.converteranimations
{
	public class VaporeonParentDad_ConverterAnimatorController : MonoBehaviour
	{
		private VPParentDad_SittingTo VaporeonParentDad_sittingto;

		private VPParentDad_WalkingTo VaporeonParentDad_walkingto;

		private VPParentDad_IdleTo VaporeonParentDad_idleto;

		public void VPParentDad_ConverterAnimatorController()
		{
			VaporeonParentDad_walkingto.VPParentDad_WalkingToController();

			VaporeonParentDad_idleto.VPParentDad_IdleToController();

			VaporeonParentDad_sittingto.VPParentDad_SittingToController();
		}
	}
}