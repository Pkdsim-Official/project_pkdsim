using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Vespiquen.Dad.converteranimations.IdleTo;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Vespiquen.Dad.converteranimations.SittingTo;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Vespiquen.Dad.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Vespiquen.Dad.converteranimations
{
	public class VespiquenParentDad_ConverterAnimatorController : MonoBehaviour
	{
		private VEParentDad_SittingTo VespiquenParentDadsittingto;

		private VEParentDad_WalkingTo VespiquenParentDadwalkingto;

		private VEParentDad_IdleTo VespiquenParentDadidleto;

		public void VEParentDad_ConverterAnimatorController()
		{
			VespiquenParentDadwalkingto.VEParentDad_WalkingToController();

			VespiquenParentDadidleto.VEParentDad_IdleToController();

			VespiquenParentDadsittingto.VEParentDad_SittingToController();
		}
	}
}