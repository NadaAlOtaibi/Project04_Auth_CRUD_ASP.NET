﻿using DarkWhiteCodeExhibition.Data;
using DarkWhiteCodeExhibition.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DarkWhiteCodeExhibition.Controllers
{
    public class TableController : Controller
    {

        private readonly ApplicationDbContext _db;
        public TableController(ApplicationDbContext context)
        {
            _db = context;
        }

        public IActionResult Index()
        {

            var TableModel = _db.TableModel.ToList();
            ViewData["TableModel"] = TableModel;
            return View(TableModel);

         

        }

        // GET: ArtPieces

        // GET: ArtPieces/Details/5
        public IActionResult Details(int? id)
        {
            var Table = _db.TableModel.ToList().Find(product => product.Id == id);
            if (id == null || Table == null)
            {
                return View("_NotFound");
            }
            ViewData["TableModel"] = Table;
            return View(Table);


        }
        // GET: ArtPieces/Create
        [Authorize]

        public IActionResult Create()
        {
            return View();
        }

        // POST: ArtPieces/Create
     
        [HttpPost]


        public IActionResult Create([Bind("Id,Name,DesignerName,Price,Image")] TableModel TableModel)
        {
            if (ModelState.IsValid)
            {
                _db.TableModel.Add(TableModel);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(TableModel);
        }

        // GET: ArtPieces/Edit/5
        [Authorize]

        public IActionResult Edit(int? id)
        {
            var Table = _db.TableModel.ToList().Find(p => p.Id == id);
            if (id == null || Table == null)
            {
                return View("_NotFound");
            }
            ViewData["TableModel"] = Table;
            return View();
        }


        // POST: ArtPieces/Edit/5
       
        [HttpPost]
        public IActionResult Edit(int id, [Bind("Id,Name,DesignerName,Price,Image")] TableModel TableModel)
        {
            if (id != TableModel.Id)
            {
                return View("_NotFound");
            }

            if (ModelState.IsValid)
            {
                _db.TableModel.Update(TableModel);
                _db.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            return View(TableModel);
        }

        // GET: ArtPieces/Delete/5
        [Authorize]

        public IActionResult Delete(int? id)
        {

            var Table = _db.TableModel.ToList().FirstOrDefault(p => p.Id == id);
            if (id == null || Table == null)
            {
                return View("_NotFound");
            }
            _db.TableModel.Remove(Table);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

     
    }
}
