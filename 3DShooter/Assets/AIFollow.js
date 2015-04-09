var target: Transform;
var moveSpeed = 3;
var rotationSpeed = 3;
var myTransform: Transform;

function Awake()
{
	
	myTransform = transform;
	
}

function Start()
{

	target = GameObject.FindWithTag("Player").transform;

}

function Update()
{

	transform.LookAt(Vector3(target.position.x, transform.position.y, target.position.x));
	myTransform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);

}