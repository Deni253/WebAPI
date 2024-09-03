using Microsoft.AspNetCore.Mvc;

namespace Introduction.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DogController : ControllerBase
    {

        static List<Dog> dogs = new List<Dog>();    

        [HttpPost]
        [Route("create")]
        public IActionResult PostNewDog(Dog dog)
        {
            if (!ModelState.IsValid)
                return BadRequest("Invalid data.");
            {
                dogs.Add(dog);
            }
            return Ok(dogs);
        }

        [HttpDelete]
        [Route("del/{id}")]
        public IActionResult DeleteDog(int id)
        {
            if (!ModelState.IsValid || id < 0)
                return BadRequest("Invalid data.");
            {
                foreach (Dog dog in dogs.ToList()) if (dog.Id == id)
                    {
                        dogs.Remove(dog);                          
                    }
            }
            return Ok(dogs);
        }

        [HttpDelete]
        [Route("deleteall")]
        public IActionResult DeleteDogs()
        {
            if (!ModelState.IsValid)
                return BadRequest("Invalid data.");
            {
                foreach (Dog dog in dogs.ToList())
                    {
                        dogs.Remove(dog);
                    }
            }
            return Ok(dogs);
        }

        [HttpGet]
        [Route("get/all")]

        public IEnumerable<Dog> GetDogs()
        {
            return dogs;
        }

        [HttpPut]
        [Route("update/train/{id}")]
        public IActionResult UpdateDog(int id)
        {
            if (!ModelState.IsValid)
                return BadRequest("Invalid data.");
            {
                foreach(Dog dog in dogs) if (dog.Id == id)
                {
                        dog.IsTrained=true;
                }   
            }
            return Ok(dogs);
        }
    }
}
