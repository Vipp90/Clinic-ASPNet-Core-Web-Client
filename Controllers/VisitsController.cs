using Clinic_Web.Models;
using Clinic_Web.Models.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Strona.Areas.Identity.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clinic_Web.Controllers
{
    [Authorize(Roles = "Admin, Patient")]
    public class VisitsController : Controller
    {
        private readonly Database_controller _context;
        private readonly UserManager<Patient_account> _userManager;

        public VisitsController(Database_controller context, UserManager<Patient_account> userManager)
        {
            _context = context;
            _userManager = userManager;
        }


        // GET: Visits
        public async Task<IActionResult> Index()
        {
            var user = await _userManager.GetUserAsync(User);

            var database_controller = _context.Visits.Where(c => c.patient.Pesel == user.Pesel).Include(v => v.doctor).Include(v => v.patient);
            return View(await database_controller.ToListAsync());
        }

        // GET: Visits/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var visit = await _context.Visits
                .Include(v => v.doctor)
                .Include(v => v.patient)
                .FirstOrDefaultAsync(m => m.VisitId == id);
            if (visit == null)
            {
                return NotFound();
            }

            return View(visit);
        }

        // GET: Visits/Create
        public IActionResult Create()
        {
            var items = new List<string> {
             "111",
             "222",
             "333"
                               };
            long id = 1;
            Doctor doctor1 = new Doctor();
            doctor1 = _context.Doctors.Find(id);





            //    items =    doctor1.get_free_visit_day_example();
            ViewData["DoctorId"] = new SelectList(_context.Doctors, "DoctorId", "Surname");

            ViewData["PatientId"] = new SelectList(_context.Patients, "PatientId", "Surname");

            // ViewData["hour"] = new SelectList(items);

            // new SelectList(_context.Visits, "VisitId", "date");


            // List<string> DropDownList1 = new List<string>();
            // DropDownList1.
            //DropDownList1.DataBind();




            return View();
        }

        [HttpGet]
        public List<DateTime> Updatedata(long x, DateTime data)
        {
            var items = new List<DateTime>();
            Doctor doctor = new Doctor();
            doctor = _context.Doctors.Find(x); ;
            Visit visit = new Visit();
            visit.doctor = doctor;

            //  var result = _context.Visits.ToList().Where(y => y.DoctorId == x);
            //  doctor.Scheduled_visits = result;
            items = doctor.get_free_visit_day(data);
            // items = doctor.get_free_visit_day(data);
            return items;
        }

        // GET: Stock

        public ActionResult get_visits(int a)

        {

            Doctor doctor1 = new Doctor();
            doctor1 = _context.Doctors.Find(a);

            var items = new List<string>() { };



            // items = doctor1.get_free_visit_day_example();
            ViewData["DoctorId"] = new SelectList(_context.Doctors, "DoctorId", "Surname");

            ViewData["PatientId"] = new SelectList(_context.Patients, "PatientId", "Surname");
            ViewData["visit"] = new SelectList(items);
            return View();

        }

        // POST: Visits/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("VisitId,PatientId,DoctorId,date,hour")] Visit visit)
        {
            if (ModelState.IsValid)
            {
                Doctor doctor = _context.Doctors.Find(visit.DoctorId);

                // doctor.get_free_visit_day(visit.date);
                // List<string> lista =  doctor.get_free_visit_day(visit.date);

                //  visit.doctor.Scheduled_visits.ToList().Add(visit);
                //visit.patient.Scheduled_visits.ToList().Add(visit);
                _context.Add(visit);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));


            }
            ViewData["DoctorId"] = new SelectList(_context.Doctors, "DoctorId", "DoctorId", visit.DoctorId);
            ViewData["PatientId"] = new SelectList(_context.Patients, "PatientId", "PatientId", visit.PatientId);
            return View(visit);
        }

        // GET: Visits/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var visit = await _context.Visits.FindAsync(id);
            if (visit == null)
            {
                return NotFound();
            }
            ViewData["DoctorId"] = new SelectList(_context.Doctors, "DoctorId", "DoctorId", visit.DoctorId);
            ViewData["PatientId"] = new SelectList(_context.Patients, "PatientId", "PatientId", visit.PatientId);
            return View(visit);
        }

        // POST: Visits/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("VisitId,PatientId,DoctorId,date")] Visit visit)
        {
            if (id != visit.VisitId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(visit);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VisitExists(visit.VisitId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["DoctorId"] = new SelectList(_context.Doctors, "DoctorId", "DoctorId", visit.DoctorId);
            ViewData["PatientId"] = new SelectList(_context.Patients, "PatientId", "PatientId", visit.PatientId);
            return View(visit);
        }

        // GET: Visits/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var visit = await _context.Visits
                .Include(v => v.doctor)
                .Include(v => v.patient)
                .FirstOrDefaultAsync(m => m.VisitId == id);
            if (visit == null)
            {
                return NotFound();
            }

            return View(visit);
        }

        // POST: Visits/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var visit = await _context.Visits.FindAsync(id);
            _context.Visits.Remove(visit);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VisitExists(long id)
        {
            return _context.Visits.Any(e => e.VisitId == id);
        }
    }
}
