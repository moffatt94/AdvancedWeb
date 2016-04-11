﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using u1265196_MovieRentals.Models;
using u1265196_MovieRentals.DataAccess;

namespace u1265196_MovieRentals.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult ViewMovies()
        {
            MoviesDataAccess MoviesDA = new MoviesDataAccess();
            ModelState.Clear();
            return View(MoviesDA.GetAllMovies());

        }





        // GET: Movies/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Movies/Create
        public ActionResult AddMovie()
        {


            return View();
        }

        // POST: Movies/Create
        [HttpPost]
        public ActionResult AddMovie(Movies movies)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    MoviesDataAccess MoviesDA = new MoviesDataAccess();

                    if (MoviesDA.AddMovie(movies))
                    {
                        ViewBag.Message = "Movie added successfully";
                    }
                }
                return View();
            }
            catch

            {
                return View();
            
        }
    }

        // GET: Movies/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Movies/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Movies/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Movies/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}