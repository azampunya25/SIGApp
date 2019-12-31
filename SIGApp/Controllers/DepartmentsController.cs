﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DataContextLayer.DataContext;
using DataContextLayer.Models;
using DataContextLayer.Entity;

namespace SIGApp.Controllers
{
    public class DepartmentsController : Controller
    {
        //private readonly EFDataContext _context;
        EFDataContext _context = new EFDataContext();
        //public DepartmentsController(EFDataContext context)
        //{
        //    _context = context;
        //}

        // GET: Departments
        [HttpGet]
        public IActionResult Index()
        {
            List<Department> data = this._context.Departments.ToList();
            if (!data.Any())
            {
                return NotFound();
            }
            return View(data);
        }

        [HttpGet]
        public async Task<IActionResult> GetDepartement()
        {
            VoyageResult result = new VoyageResult();          
            result.status = "S";
            result.data = await _context.Departments.ToListAsync();
            if (!result.data.Any())
            {
                return NotFound(result);
            }
            return Ok(result);
        }

        //public IActionResult Create()
        //{
        //    return View();
        //}

        //// GET: Departments/Details/5
        //public async Task<IActionResult> Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var department = await _context.Departments
        //        .FirstOrDefaultAsync(m => m.DepartmentId == id);
        //    if (department == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(department);
        //}

        //// GET: Departments/Create
        //public IActionResult Create()
        //{
        //    return View();
        //}

        //// POST: Departments/Create
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create([Bind("DepartmentId,DepartmentCode,DepartmentName,Description")] Department department)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _context.Add(department);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(department);
        //}

        //// GET: Departments/Edit/5
        //public async Task<IActionResult> Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var department = await _context.Departments.FindAsync(id);
        //    if (department == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(department);
        //}

        //// POST: Departments/Edit/5
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(int id, [Bind("DepartmentId,DepartmentCode,DepartmentName,Description")] Department department)
        //{
        //    if (id != department.DepartmentId)
        //    {
        //        return NotFound();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            _context.Update(department);
        //            await _context.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!DepartmentExists(department.DepartmentId))
        //            {
        //                return NotFound();
        //            }
        //            else
        //            {
        //                throw;
        //            }
        //        }
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(department);
        //}

        //// GET: Departments/Delete/5
        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var department = await _context.Departments
        //        .FirstOrDefaultAsync(m => m.DepartmentId == id);
        //    if (department == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(department);
        //}

        //// POST: Departments/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    var department = await _context.Departments.FindAsync(id);
        //    _context.Departments.Remove(department);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        //private bool DepartmentExists(int id)
        //{
        //    return _context.Departments.Any(e => e.DepartmentId == id);
        //}
    }
}
