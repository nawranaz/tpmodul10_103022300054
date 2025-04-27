using Microsoft.AspNetCore.Mvc;
using tpmodul10_103022300054.Models;
using System.Collections.Generic;

namespace tpmodul10_103022300054.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MahasiswaController : ControllerBase
    {
        private static List<Mahasiswa> daftarMahasiswa = new List<Mahasiswa>
        {
            new Mahasiswa("Nawra Nazli Kirana", "103022300054"),
            new Mahasiswa("Putri Afni Azkiya", "103022300054"),
            new Mahasiswa("Fathian Alfiana Rahman", "103022300084"),
            new Mahasiswa("Dian Fardiansyah", "103022300129"),
            new Mahasiswa("M Tahta Faiz", "103022300142")
        };

        [HttpGet]
        public ActionResult<IEnumerable<Mahasiswa>> GetAll()
        {
            return daftarMahasiswa;
        }

        [HttpGet("{index}")]
        public ActionResult<Mahasiswa> GetByIndex(int index)
        {
            if (index < 0 || index >= daftarMahasiswa.Count)
                return NotFound();

            return daftarMahasiswa[index];
        }

        [HttpPost]
        public ActionResult Add([FromBody] Mahasiswa mhs)
        {
            daftarMahasiswa.Add(mhs);
            return Ok();
        }

        [HttpDelete("{index}")]
        public ActionResult Delete(int index)
        {
            if (index < 0 || index >= daftarMahasiswa.Count)
                return NotFound();

            daftarMahasiswa.RemoveAt(index);
            return Ok();
        }
    }
}
