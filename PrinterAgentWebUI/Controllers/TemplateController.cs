// PrinterAgentWebUI/Controllers/TemplateController.cs

using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PrinterAgent.Core.Models;
using PrinterAgent.Core.Services;

namespace PrinterAgentWebUI.Controllers
{
    public class TemplateController : Controller
    {
        private readonly ITemplateService _svc;
        public TemplateController(ITemplateService svc)
        {
            _svc = svc;
        }

        // ————— Razor Views —————

        // GET  /Template
        [HttpGet("/Template")]
        public IActionResult Index()
        {
            return View();  // Views/Template/Index.cshtml
        }

        // GET  /Template/Sections
        [HttpGet("/Template/Sections")]
        public IActionResult Sections()
        {
            return View();  // Views/Template/Sections.cshtml
        }

        // GET  /Template/Qr
        [HttpGet("/Template/Qr")]
        public IActionResult Qr()
        {
            return View();  // Views/Template/Qr.cshtml
        }


        // ————— JSON API Endpoints —————

        // GET   /api/template
        [HttpGet("/api/template")]
        public async Task<IActionResult> GetAll()
        {
            var all = await _svc.GetAllTemplatesAsync();
            return Ok(all);
        }

        // GET   /api/template/{id}
        [HttpGet("/api/template/{id:int}")]
        public async Task<IActionResult> Get(int id)
        {
            var tpl = await _svc.GetTemplateAsync(id);
            if (tpl == null) return NotFound();
            return Ok(tpl);
        }

        // POST  /api/template
        [HttpPost("/api/template")]
        public async Task<IActionResult> Create([FromBody] PrintTemplate tpl)
        {
            var created = await _svc.CreateTemplateAsync(tpl);
            return CreatedAtAction(nameof(Get), new { id = created.Id }, created);
        }

        // PUT   /api/template/{id}
        [HttpPut("/api/template/{id:int}")]
        public async Task<IActionResult> Update(int id, [FromBody] PrintTemplate tpl)
        {
            tpl.Id = id;
            await _svc.UpdateTemplateAsync(tpl);
            return NoContent();
        }

        // DELETE /api/template/{id}
        [HttpDelete("/api/template/{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _svc.DeleteTemplateAsync(id);
            return NoContent();
        }


        // — Sections — 

        // GET   /api/template/{id}/sections
        [HttpGet("/api/template/{id:int}/sections")]
        public async Task<IActionResult> GetSections(int id)
        {
            var secs = await _svc.GetSectionsAsync(id);
            return Ok(secs);
        }

        // POST  /api/template/{id}/sections
        [HttpPost("/api/template/{id:int}/sections")]
        public async Task<IActionResult> CreateSection(int id, [FromBody] TemplateSection section)
        {
            var created = await _svc.CreateSectionAsync(id, section);
            return Created($"/api/template/{id}/sections/{created.Id}", created);
        }

        // PUT   /api/template/sections/{sectionId}
        [HttpPut("/api/template/sections/{sectionId:int}")]
        public async Task<IActionResult> UpdateSection(int sectionId, [FromBody] TemplateSection section)
        {
            section.Id = sectionId;
            await _svc.UpdateSectionAsync(section);
            return NoContent();
        }

        // DELETE /api/template/sections/{sectionId}
        [HttpDelete("/api/template/sections/{sectionId:int}")]
        public async Task<IActionResult> DeleteSection(int sectionId)
        {
            await _svc.DeleteSectionAsync(sectionId);
            return NoContent();
        }


        // — Printer Assignments —

        // GET   /api/template/sections/{sectionId}/assignments
        [HttpGet("/api/template/sections/{sectionId:int}/assignments")]
        public async Task<IActionResult> GetAssignments(int sectionId)
        {
            var assigns = await _svc.GetAssignmentsAsync(sectionId);
            return Ok(assigns);
        }

        // POST  /api/template/sections/{sectionId}/assignments
        [HttpPost("/api/template/sections/{sectionId:int}/assignments")]
        public async Task<IActionResult> CreateAssignment(int sectionId, [FromBody] PrinterAssignment a)
        {
            var created = await _svc.CreateAssignmentAsync(sectionId, a);
            return Created($"/api/template/sections/{sectionId}/assignments/{created.Id}", created);
        }

        // DELETE /api/template/assignments/{assignmentId}
        [HttpDelete("/api/template/assignments/{assignmentId:int}")]
        public async Task<IActionResult> DeleteAssignment(int assignmentId)
        {
            await _svc.DeleteAssignmentAsync(assignmentId);
            return NoContent();
        }


        // — Invoice QR —

        // GET   /api/template/invoiceqr/{invoiceId}
        [HttpGet("/api/template/invoiceqr/{invoiceId:long}")]
        public async Task<IActionResult> GetInvoiceQr(long invoiceId)
        {
            var qr = await _svc.GetInvoiceQrAsync(invoiceId);
            if (qr == null) return NotFound();
            return Ok(qr);
        }

        // POST  /api/template/invoiceqr
        [HttpPost("/api/template/invoiceqr")]
        public async Task<IActionResult> CreateInvoiceQr([FromBody] InvoiceQR qr)
        {
            var created = await _svc.CreateInvoiceQrAsync(qr);
            return Created($"/api/template/invoiceqr/{created.InvoiceId}", created);
        }
    }
}
