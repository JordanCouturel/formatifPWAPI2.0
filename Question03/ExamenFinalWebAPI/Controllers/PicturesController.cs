using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ExamenFinalWebAPI.Data;
using ExamenFinalWebAPI.Models;
using Microsoft.AspNetCore.Authorization;
using System.Text.RegularExpressions;

namespace ExamenFinalWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PicturesController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public PicturesController(ApplicationContext context)
        {
            _context = context;
        }

        // GET: api/Pictures
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Picture>>> GetPicture()
        {
          if (_context.Picture == null)
          {
              return NotFound();
          }
            return await _context.Picture.ToListAsync();
        }



        [HttpGet("{size}/{id}")]
        [AllowAnonymous]
        public async Task<ActionResult<Picture>> GetPicture(string size, int id)
        {
            var picture = await _context.Picture.FindAsync(id);

            if (picture == null)
            {
                return NotFound();
            }

            Match m = Regex.Match(size, "lg|sm|originale");

            if (!m.Success)
            {
                return BadRequest();
            }

            byte[] bytes = System.IO.File.ReadAllBytes(Directory.GetCurrentDirectory() + "/images/" + size + "/" + picture.FileName);

            return File(bytes, picture.MimeType);
        }
        // PUT: api/Pictures/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPicture(int id, Picture picture)
        {
            if (id != picture.Id)
            {
                return BadRequest();
            }

            _context.Entry(picture).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PictureExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        [HttpPost]
        [DisableRequestSizeLimit]
        public async Task<ActionResult<Picture>> PostPicture()
        {
            try
            {
                IFormCollection formCollection = await Request.ReadFormAsync();
                IFormFile file = formCollection.Files.GetFile("image");
                Image image = Image.Load(file.OpenReadStream());

                Picture picture = new Picture();
                picture.FileName = Guid.NewGuid().ToString() + Path.GetFileName(file.FileName);
                picture.MimeType = file.ContentType;

                image.Save(Directory.GetCurrentDirectory() + "/images/originale/" + picture.FileName);

                image.Save(Directory.GetCurrentDirectory() + "/images/sm/" + picture.FileName);
                image.Mutate(i =>
                    i.Resize(new ResizeOptions()
                    {
                        Mode = ResizeMode.Min,
                        Size = new Size() { Height = 320 }
                    })
                    );

                image.Save(Directory.GetCurrentDirectory() + "/images/lg/" + picture.FileName);
                image.Mutate(i =>
                    i.Resize(new ResizeOptions()
                    {
                        Mode = ResizeMode.Min,
                        Size = new Size() { Height = 450 }
                    })
                    );


                picture.VillaId = 1;

                _context.Picture.Add(picture);
                await _context.SaveChangesAsync();

                return picture;
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }

        // DELETE: api/Pictures/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePicture(int id)
        {
            var picture = await _context.Picture.FindAsync(id);
            if (picture == null)
            {
                return NotFound();
            }

            System.IO.File.Delete(Directory.GetCurrentDirectory() + "/images/lg/" + picture.FileName);
            System.IO.File.Delete(Directory.GetCurrentDirectory() + "/images/sm/" + picture.FileName);
            System.IO.File.Delete(Directory.GetCurrentDirectory() + "/images/originale/" + picture.FileName);

            _context.Picture.Remove(picture);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PictureExists(int id)
        {
            return (_context.Picture?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
