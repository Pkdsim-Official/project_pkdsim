using project_pkdsim.ANIMATOR.Parents.Jolteon.Dad.converteranimations.IdleTo;
using project_pkdsim.ANIMATOR.Parents.Jolteon.Dad.converteranimations.SittingTo;
using project_pkdsim.ANIMATOR.Parents.Jolteon.Dad.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Jolteon.Dad.converteranimations
{
	public class JolteonParent_ConverterAnimatorController : MonoBehaviour 
	{
		private JT_SittingTo JolteonParent_sittingto;
		
		private JT_WalkingTo JolteonParent_walkingto;
		
		private JT_IdleTo JolteonParent_idleto;

		private void JT_Base_IdleAnimatorController()
		{
			JolteonParent_walkingto.JT_WalkingToController();

			JolteonParent_idleto.JT_IdleToController();
			
			JolteonParent_sittingto.JT_SittingToController();	
		}
	}
}