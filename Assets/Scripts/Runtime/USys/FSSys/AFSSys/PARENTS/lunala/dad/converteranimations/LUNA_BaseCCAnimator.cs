using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Lunala.converteranimations.IdleTo;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Lunala.converteranimations.SittingTo;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Lunala.converteranimations.WalkingTo;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Lunala.converteranimations
{
	public class LunalaConverterAnimatorController : MonoBehaviour 
	{
		private LUNASittingTo Lunalasittingto;
		
		private LUNAWalkingTo Lunalawalkingto;
		
		private LUNAIdleTo Lunalaidleto;

		public void LUNAConverterAnimatorController()
		{
			Lunalawalkingto.LUNAWalkingToController();

			Lunalaidleto.LUNA_IdleToController();
			
			Lunalasittingto.LUNASittingToController();	
		}
	}
}