using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetHeroAttackRange : MonoBehaviour
{
    
	// функция возвращает ближайший объект из массива, относительно указанной позиции
	static GameObject NearTarget(Vector3 position, Collider[] array) 
	{
		Collider current = null;
		float dist = Mathf.Infinity;

		foreach(Collider coll in array)
		{
			float curDist = Vector3.Distance(position, coll.transform.position);

			if(curDist < dist)
			{
				current = coll;
				dist = curDist;
			}
		}

		return (current != null) ? current.gameObject : null;
	}

	// point - точка контакта
	// radius - радиус поражения
	// layerMask - номер слоя, с которым будет взаимодействие
	// damage - наносимый урон
	// allTargets - должны-ли получить урон все цели, попавшие в зону поражения
	public static void Action(Vector3 point, float radius, int layerMask, int damage, bool allTargets)
	{
		Collider[] colliders = Physics.OverlapSphere(point, radius, 1 << layerMask);

		if(!allTargets)
		{
			GameObject obj = NearTarget(point, colliders);
			if(obj != null && obj.GetComponent<Health>() && obj.tag != "Player")
			{
				obj.GetComponent<Health>().GetDamage(damage);
			}
			return;
		}

		foreach(Collider hit in colliders) 
		{
			if(hit.GetComponent<Health>() && hit.gameObject.tag != "Player")
			{
				hit.GetComponent<Health>().GetDamage(damage);
			}
		}
	}
}
