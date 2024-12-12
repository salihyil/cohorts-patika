using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Pratik_Cilgin_Muzisyenler.Models;

namespace Pratik_Cilgin_Muzisyenler.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class MusiciansController : ControllerBase
    {
        private static readonly List<Musicians> _musicians = [
            new() {Id = 1, Name = "Ahmet Çalgı", Profession = "Ünlü Çalgı Çalar", FunFeature = "Her zaman yanlış nota çalar, ama çok eğlenceli."},
            new() {Id = 2, Name = "Zeynep Melodi", Profession = "Popüler Melodi Yazarı", FunFeature = "Şarkıları yanlış anlaşılır ama çok popüler."},
            new() {Id = 3, Name = "Cemil Akor", Profession = "Çılgın Akorist", FunFeature = "Akorları sık değiştirir, ama şaşırtıcı derecede yetenekli."},
            new() {Id = 4, Name = "Fatma Nota", Profession = "Sürpriz Nota Üreticisi", FunFeature = "Nota üretirken sürekli sürprizler hazırlar."},
            new() {Id = 5, Name = "Hasan Ritim", Profession = "Ritim Canavarı", FunFeature = "Her ritmi kendi tarzında yapar, hiç uymaz ama komiktir."},
            new() {Id = 6, Name = "Elif Armoni", Profession = "Armoni Ustası", FunFeature = "Armonilerini bazen yanlış çalar, ama çok yaratıcıdır."},
            new() {Id = 7, Name = "Ali Perde", Profession = "Perde Uygulayıcı", FunFeature = "Her perdeyi farklı şekilde çalar, her zaman sürprizlIdir."},
            new() {Id = 8, Name = "Ayşe Rezonans", Profession = "Rezonans Uzmanı", FunFeature = "Rezonans konusunda uzman, ama bazen çok gurultu çıkarır."},
            new() {Id = 9, Name = "Murat Ton", Profession = "Tonlama Meraklısı", FunFeature = "Tonlamalarındaki farklılıklar bazen komik, ama oldukça ilginç."},
            new() {Id = 10, Name = "Selin Akor", Profession = "Akor Sihirbazı", FunFeature = "Akorları değiştirdiğinde bazen sihirli bir hava yaratır."}
        ];

        // GET: /Musicians
        /// <summary>
        /// Gets all musicians
        /// </summary>
        /// <returns>List of all musicians</returns>
        /// <response code="200">Returns the list of musicians</response>
        [HttpGet(Name = "GetMusicians")]
        public ActionResult<IEnumerable<Musicians>> Get()
        {
            return Ok(_musicians);
        }

        // GET: /Musicians/{id}
        /// <summary>
        /// Gets a specific musician by id
        /// </summary>
        /// <param name="id">The ID of the musician</param>
        /// <returns>The musician with the specified ID</returns>
        /// <response code="200">Returns the requested musician</response>
        /// <response code="404">If the musician is not found</response>
        [HttpGet("{id}")]
        public ActionResult<Musicians> Get(int id)
        {
            var musician = _musicians.FirstOrDefault(m => m.Id == id);
            if (musician == null)
                return NotFound();

            return Ok(musician);
        }

        // GET: /Musicians/search?name={name}
        /// <summary>
        /// Searches musicians by name
        /// </summary>
        /// <param name="name">Name to search for</param>
        /// <returns>List of musicians matching the search criteria</returns>
        /// <response code="200">Returns the matching musicians</response>
        /// <response code="400">If the name parameter is empty</response>
        [HttpGet("search")]
        public ActionResult<IEnumerable<Musicians>> Search([FromQuery] string name)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var musicians = _musicians.Where(m => m.Name.Contains(name, StringComparison.OrdinalIgnoreCase)).ToList();
            return Ok(musicians);
        }

        // POST: /Musicians
        /// <summary>
        /// Creates a new musician
        /// </summary>
        /// <param name="musician">The musician to create</param>
        /// <returns>The created musician</returns>
        /// <response code="201">Returns the newly created musician</response>
        /// <response code="400">If the musician is null or invalid</response>
        /// <response code="409">If a musician with the same ID already exists</response>
        [HttpPost]
        public ActionResult<Musicians> Create([FromBody] Musicians musician)
        {
            if (musician == null)
                return BadRequest();

            if (_musicians.Any(m => m.Id == musician.Id))
                return Conflict("A musician with this ID already exists");

            var newId = _musicians.Count + 1;
            musician.Id = newId;

            _musicians.Add(musician);
            return CreatedAtAction(nameof(Get), new { id = musician.Id }, musician);
        }

        // PUT: /Musicians/{id}
        /// <summary>
        /// Updates a musician
        /// </summary>
        /// <param name="id">The ID of the musician to update</param>
        /// <param name="musician">The updated musician information</param>
        /// <returns>No content</returns>
        /// <response code="204">If the musician was successfully updated</response>
        /// <response code="400">If the musician is null or ID mismatch</response>
        /// <response code="404">If the musician is not found</response>
        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] Musicians musician)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var existingMusician = _musicians.FirstOrDefault(m => m.Id == id);
            if (existingMusician == null)
                return NotFound();

            existingMusician.Name = musician.Name;
            existingMusician.Profession = musician.Profession;
            existingMusician.FunFeature = musician.FunFeature;
            return NoContent();
        }

        // PATCH: /Musicians/{id}/profession
        /// <summary>
        /// Updates a musician's profession
        /// </summary>
        /// <param name="id">The ID of the musician</param>
        /// <param name="operations">The list of JSON patch operations</param>
        /// <returns>No content</returns>
        /// <response code="204">If the profession was successfully updated</response>
        /// <response code="400">If the new profession is empty</response>
        /// <response code="404">If the musician is not found</response>
        [HttpPatch("{id}/profession")]
        public ActionResult UpdateProfession(int id, [FromBody] List<JsonPatchOperation> operations)
        {
            var musician = _musicians.FirstOrDefault(m => m.Id == id);
            if (musician == null)
                return NotFound($"Musician with id {id} not found");

            var patchDoc = new JsonPatchDocument<Musicians>();
            operations.Where(op => string.Equals(op.Path.TrimStart('/'), "profession", StringComparison.OrdinalIgnoreCase))
                     .ToList()
                     .ForEach(op => patchDoc.Replace(m => m.Profession, op.Value));

            patchDoc.ApplyTo(musician, ModelState);

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return NoContent();
        }

        // DELETE: /Musicians/{id}
        /// <summary>
        /// Deletes a musician
        /// </summary>
        /// <param name="id">The ID of the musician to delete</param>
        /// <returns>No content</returns>
        /// <response code="204">If the musician was successfully deleted</response>
        /// <response code="404">If the musician is not found</response>
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var musician = _musicians.FirstOrDefault(m => m.Id == id);
            if (musician == null)
                return NotFound();

            _musicians.Remove(musician);
            return NoContent();
        }
    }
}
