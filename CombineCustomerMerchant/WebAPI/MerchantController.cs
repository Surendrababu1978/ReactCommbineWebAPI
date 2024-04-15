using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using CombineCustomerMerchant.Data;

namespace CombineCustomerMerchant.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MerchantsController : ControllerBase
    {
        private readonly CommerceContext _context;

        public MerchantsController(CommerceContext context)
        {
            _context = context;
        }

        // GET: api/Merchants
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Merchant>>> GetMerchants()
        {
            return await _context.Merchants.ToListAsync();
        }

        // GET: api/Merchants/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Merchant>> GetMerchant(int id)
        {
            var merchant = await _context.Merchants.FindAsync(id);

            if (merchant == null)
            {
                return NotFound();
            }

            return merchant;
        }

        // POST: api/Merchants
        [HttpPost]
        public async Task<ActionResult<Merchant>> PostMerchant(Merchant merchant)
        {
            _context.Merchants.Add(merchant);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetMerchant), new { id = merchant.MerChantId }, merchant);
        }

        // PUT: api/Merchants/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMerchant(int id, Merchant merchant)
        {
            if (id != merchant.MerChantId)
            {
                return BadRequest();
            }

            _context.Entry(merchant).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MerchantExists(id))
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

        // DELETE: api/Merchants/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMerchant(int id)
        {
            var merchant = await _context.Merchants.FindAsync(id);
            if (merchant == null)
            {
                return NotFound();
            }

            _context.Merchants.Remove(merchant);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MerchantExists(int id)
        {
            return _context.Merchants.Any(e => e.MerChantId == id);
        }
    }
}