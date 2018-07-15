using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class FollowPatch : MonoBehaviour {

	public enum FollowType{
		MoveTowards,
		Lerp
	}

	public FollowType Type = FollowType.MoveTowards;
	public PlatformMove path;
	public float speed = 1;
	public float MaxDistance = .1f;
	public float WaitTime, countWaitTime;


	public IEnumerator<Transform> _currentPoint;

	void Start(){

		if (path == null) {
			return;
		}

		countWaitTime = WaitTime;
		_currentPoint = path.getPathEnumerator ();
		_currentPoint.MoveNext ();

		if (_currentPoint.Current == null) {
			return;
		}

		transform.position = _currentPoint.Current.position;
	}


	void Update(){
		if (_currentPoint.Current == null || _currentPoint == null)
			return;
	
		if (Type == FollowType.MoveTowards)
			transform.position = Vector3.MoveTowards (transform.position, _currentPoint.Current.position, Time.deltaTime * speed);
		else if (Type == FollowType.Lerp)
			transform.position = Vector3.Lerp (transform.position, _currentPoint.Current.position, Time.deltaTime * speed);

		var distanceSquared = (transform.position - _currentPoint.Current.position).sqrMagnitude;
		if (distanceSquared < MaxDistance * MaxDistance) {
			if((countWaitTime -= Time.deltaTime)<0){
				_currentPoint.MoveNext ();
				countWaitTime = countWaitTime;
			}
		
		 }
		
	}		




}
