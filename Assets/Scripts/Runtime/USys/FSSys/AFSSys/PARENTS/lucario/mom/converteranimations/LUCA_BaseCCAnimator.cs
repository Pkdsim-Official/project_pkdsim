using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Lucario.Mom.converteranimations.IdleTo;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Lucario.Mom.converteranimations.SittingTo;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Lucario.Mom.converteranimations.WalkingTo;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Lucario.Mom.converteranimations
{
	public class LucarioParentMom_ConverterAnimatorController : MonoBehaviour
	{
		private LUCAParentMom_SittingTo LucarioParentMomSittingto;

		private LUCAParentMom_WalkingTo LucarioParentMomWalkingto;

		private LUCAParentMom_IdleTo LucarioParentMomIdleto;

		public void LUCAParentMom_ConverterAnimatorController()
		{
			LucarioParentMomWalkingto.LUCAParentMom_WalkingToController();

			LucarioParentMomIdleto.LUCAParentMom_IdleToController();

			LucarioParentMomSittingto.LUCAParentMom_SittingToController();
		}
	}
}