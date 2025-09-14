using project_pkdsim.ANIMATOR.Parents.Lucario.Mom.converteranimations.IdleTo;
using project_pkdsim.ANIMATOR.Parents.Lucario.Mom.converteranimations.SittingTo;
using project_pkdsim.ANIMATOR.Parents.Lucario.Mom.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Lucario.Mom.converteranimations
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