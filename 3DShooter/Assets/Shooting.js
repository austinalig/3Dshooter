var projectile : Rigidbody;
var speed = 10;

function update() {
if (Input.GetButtonUp("Fire"))
{
clone = Instantiate(projectile, transform.position, transform.rotation);
 clone.velocity = transform.TransformDirection(Vector3 (0, 0, speed)); 
 Destroy(clone.gameObject, 5);
 }}