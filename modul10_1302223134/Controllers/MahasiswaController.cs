using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace modul10_1302223134.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MahasiswaController : ControllerBase
    {
        static List<string> courses = new List<string>
        {
            "PBO", "KPL", "UX", "Proting", "Dasjarkom", "Basdat"
        };

        public static List<Mahasiswa> dataMahasiswa = new List<Mahasiswa>
        {
            new Mahasiswa("Muhammad Dias Adani", "1302223134", courses, 2024),
            new Mahasiswa("Iksan Oktav Risandy", "1302223042", courses, 2024),
            new Mahasiswa("Fauzein Mulya Warman", "1302223127", courses, 2024),
            new Mahasiswa("Muhammad Haulul Azkiyaa", "1302223007", courses, 2024),
            new Mahasiswa("Muhammad Nur Shodiq", "1302223054", courses, 2024)
        };

        // GET: api/<MahasiswaController>
        [HttpGet]
        public IEnumerable<Mahasiswa> Get()
        {
            return dataMahasiswa;
        }

        // GET api/<MahasiswaController>/5
        [HttpGet("{id}")]
        public Mahasiswa Get(int id)
        {
            return dataMahasiswa[id];
        }

        // POST api/<MahasiswaController>
        [HttpPost]
        public void Post([FromBody] Mahasiswa mhs)
        {
            dataMahasiswa.Add(mhs);
        }

        // DELETE api/<MahasiswaController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            dataMahasiswa.RemoveAt(id);
        }
    }
}
